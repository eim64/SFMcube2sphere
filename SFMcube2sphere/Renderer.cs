using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL4;
using OpenTK;
using OpenTK.Graphics;
using System.IO;
using System.Drawing;

namespace SFMcube2sphere
{
    public class Renderer
    {
        const string VertexShaderPath = @".\shader.vert";


        static int Width;
        static int Height;
        static GameWindow wnd;
        static int _vertexbuffer;
        static int _cubemapHandle;
        static int _shaderProgram;
        static int _vertexarray;
        static int _uniformWidth;
        static int _uniformHeight;
        static int _FBO;
        static int _RBO;


        static readonly float[] _vertices =
        {
            -1f, -1f, 0.0f, 
             1f, -1f, 0.0f, 
             -1f,  1f, 0.0f, 

             1f, 1f, 0.0f, 
             1f, -1f, 0.0f,
             -1f,  1f, 0.0f
        };


        public static void Start(int width, int height, string shaderpath)
        {
            if (wnd != null) throw new Exception("You gotta stop the damn thing before you start it again!");

            wnd = new GameWindow(width,height, new GraphicsMode());
            wnd.Visible = false;
            //Too lazy to make my own context
            wnd.MakeCurrent();

            Width = width;
            Height = height;
            GL.Viewport(0,0,width,height);

            _FBO = GL.GenFramebuffer();
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, _FBO);

            _RBO = GL.GenRenderbuffer();
            GL.BindRenderbuffer(RenderbufferTarget.RenderbufferExt, _RBO);

            GL.RenderbufferStorage(RenderbufferTarget.RenderbufferExt, RenderbufferStorage.Rgba8, width, height);
            GL.FramebufferRenderbuffer(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, RenderbufferTarget.RenderbufferExt, _FBO);



            _vertexbuffer = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexbuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);

            _cubemapHandle = GL.GenTexture();
            GL.BindTexture(TextureTarget.TextureCubeMap,_cubemapHandle);

            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapR, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            int   vshader = GL.CreateShader(ShaderType.VertexShader)
                , fshader = GL.CreateShader(ShaderType.FragmentShader);

            GL.ShaderSource(vshader, File.ReadAllText(VertexShaderPath));
            GL.ShaderSource(fshader, File.ReadAllText(shaderpath));

            GL.CompileShader(vshader);
            GL.CompileShader(fshader);

            string errmessage = "";
            GL.GetShaderInfoLog(fshader, out errmessage);
            System.Diagnostics.Debug.WriteLine(errmessage);

            _shaderProgram = GL.CreateProgram();
            GL.AttachShader(_shaderProgram, vshader);
            GL.AttachShader(_shaderProgram, fshader);

            GL.LinkProgram(_shaderProgram);

            GL.DetachShader(_shaderProgram, vshader);
            GL.DetachShader(_shaderProgram, fshader);
            GL.DeleteShader(vshader);
            GL.DeleteShader(fshader);

            _uniformWidth = GL.GetUniformLocation(_shaderProgram,"width");
            _uniformHeight = GL.GetUniformLocation(_shaderProgram, "height");

            _vertexarray = GL.GenVertexArray();
            GL.BindVertexArray(_vertexarray);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);

            GL.EnableVertexAttribArray(0);
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexbuffer);
        }

        public static void RenderImages(string[] bitmaps, string output)
        {
            wnd.MakeCurrent();
            GL.UseProgram(_shaderProgram);
            GL.Uniform1(_uniformWidth, Width);
            GL.Uniform1(_uniformHeight, Height);

            GL.BindTexture(TextureTarget.TextureCubeMap, _cubemapHandle);
            for (int i = 0; i < bitmaps.Length; i++)
            {
                using (Bitmap bmp = new Bitmap(bitmaps[i]))
                {
                    var data = bmp.LockBits(new Rectangle((bmp.Width - bmp.Height) / 2, 0, bmp.Height, bmp.Height),
                        System.Drawing.Imaging.ImageLockMode.ReadOnly,
                        System.Drawing.Imaging.PixelFormat.Format32bppArgb);


                    GL.TexImage2D(
                        TextureTarget.TextureCubeMapPositiveX + i, 0,
                        PixelInternalFormat.Rgba,
                        data.Width,
                        data.Height, 0,
                        PixelFormat.Bgra, 
                        PixelType.UnsignedByte, 
                        data.Scan0);

                    bmp.UnlockBits(data);
                }
            }

            GL.BindVertexArray(_vertexbuffer);
            GL.ActiveTexture(TextureUnit.Texture0);

            GL.BindFramebuffer(FramebufferTarget.DrawFramebuffer, _FBO);
            GL.BindRenderbuffer(RenderbufferTarget.RenderbufferExt, _RBO);

            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

            using (Bitmap bmp = new Bitmap(Width,Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            {
                var data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
                GL.ReadBuffer(ReadBufferMode.ColorAttachment0);
                GL.ReadPixels(0, 0, Width, Height, PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
                bmp.UnlockBits(data);

                bmp.Save(output);
            }

            GL.BindRenderbuffer(RenderbufferTarget.RenderbufferExt, 0);
            wnd.SwapBuffers();
        }

        public static void Stop()
        {
            GL.DeleteBuffer(_vertexbuffer);
            GL.DeleteTexture(_cubemapHandle);
            GL.DeleteFramebuffer(_FBO);
            GL.DeleteRenderbuffer(_RBO);

            GL.DeleteProgram(_shaderProgram);

            wnd.Close();
            wnd.Dispose();
            wnd = null;
        }
    }
}
