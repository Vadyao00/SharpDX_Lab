using System;
using SharpDX;
using SharpDX.Direct3D11;

namespace SimpleDXApp
{
    class Loader : IDisposable
    {
        private DirectX3DGraphics _directX3DGraphics;

        public Loader(DirectX3DGraphics directX3DGraphics)
        {
            _directX3DGraphics = directX3DGraphics;
        }

        public MeshObject MakeParal(Vector4 position, float yaw, float pitch, float roll)
        {
            Renderer.VertexDataStruct[] vertices =
                new Renderer.VertexDataStruct[24]
                {
                    new Renderer.VertexDataStruct // front 0
                    {
                        position = new Vector4(-1.0f, 1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.07f, 0.2f)
                    },
                    new Renderer.VertexDataStruct // front 1
                    {
                        position = new Vector4(-1.0f, -1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.07f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // front 2
                    {
                        position = new Vector4(1.0f, -1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.34f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // front 3
                    {
                        position = new Vector4(1.0f, 1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.34f, 0.2f)
                    },
                    new Renderer.VertexDataStruct // right 4
                    {
                        position = new Vector4(1.0f, 1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.34f, 0.2f)
                    },
                    new Renderer.VertexDataStruct // right 5
                    {
                        position = new Vector4(1.0f, -1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.34f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // right 6
                    {
                        position = new Vector4(1.0f, -1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.48f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // right 7
                    {
                        position = new Vector4(1.0f, 1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.48f, 0.2f)
                    },
                    new Renderer.VertexDataStruct // back 8
                    {
                        position = new Vector4(1.0f, 1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.48f, 0.2f)
                    },
                    new Renderer.VertexDataStruct // back 9
                    {
                        position = new Vector4(1.0f, -1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.48f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // back 10
                    {
                        position = new Vector4(-1.0f, -1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.78f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // back 11
                    {
                        position = new Vector4(-1.0f, 1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.78f, 0.2f)
                    },
                    new Renderer.VertexDataStruct // left 12
                    {
                        position = new Vector4(-1.0f, 1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.78f, 0.2f)
                    },
                    new Renderer.VertexDataStruct // left 13
                    {
                        position = new Vector4(-1.0f, -1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.78f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // left 14
                    {
                        position = new Vector4(-1.0f, -1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.94f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // left 15
                    {
                        position = new Vector4(-1.0f, 1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.94f, 0.2f)
                    },
                    new Renderer.VertexDataStruct // top 16
                    {
                        position = new Vector4(-1.0f, 1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.48f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // top 17
                    {
                        position = new Vector4(-1.0f, 1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.48f, 0.97f)
                    },
                    new Renderer.VertexDataStruct // top 18
                    {
                        position = new Vector4(1.0f, 1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.79f, 0.97f)
                    },
                    new Renderer.VertexDataStruct // top 19
                    {
                        position = new Vector4(1.0f, 1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.79f, 0.8f)
                    },
                    new Renderer.VertexDataStruct // bottom 20
                    {
                        position = new Vector4(-1.0f, -1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.79f, 0.2f)
                    },
                    new Renderer.VertexDataStruct // bottom 21
                    {
                        position = new Vector4(-1.0f, -1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.79f, 0.04f)
                    },
                    new Renderer.VertexDataStruct // bottom 22
                    {
                        position = new Vector4(1.0f, -1.5f, 0.5f, 1.0f),
                        texCoord = new Vector2(0.48f, 0.04f)
                    },
                    new Renderer.VertexDataStruct // bottom 23
                    {
                        position = new Vector4(1.0f, -1.5f, -0.5f, 1.0f),
                        texCoord = new Vector2(0.48f, 0.2f)
                    }
                };
            uint[] indices = new uint[36]
            {
                0, 1, 2,        2, 3, 0,
                4, 5, 6,        6, 7, 4,
                8, 9, 10,       10, 11, 8,
                12, 13, 14,     14, 15, 12,
                16, 17, 18,     18, 19, 16,
                22, 23, 20,     20, 21, 22,
            };

            Texture2D texture = TextureLoader.LoadTexture(_directX3DGraphics.Device, "D:\\Labs\\5sem\\ПГиЗ\\2\\фото\\razvertka.png");
            ShaderResourceView textureView = new ShaderResourceView(_directX3DGraphics.Device, texture);
            var samplerDescription = new SamplerStateDescription()
            {
                Filter = Filter.MinMagMipLinear, // Линейная фильтрация
                AddressU = TextureAddressMode.Mirror, // Зацикливание текстуры по оси U
                AddressV = TextureAddressMode.Mirror, // Зацикливание текстуры по оси V
                AddressW = TextureAddressMode.Mirror, // Зацикливание текстуры по оси W
                ComparisonFunction = Comparison.Never,
                MinimumLod = 0,
                MaximumLod = float.MaxValue
            };
            var samplerState = new SamplerState(_directX3DGraphics.Device, samplerDescription);
            _directX3DGraphics.DeviceContext.PixelShader.SetShaderResources(0, textureView);
            _directX3DGraphics.DeviceContext.PixelShader.SetSampler(0, samplerState);
            return new MeshObject(_directX3DGraphics, position,
                yaw, pitch, roll, vertices, indices);
        }

        public void Dispose()
        {

        }
    }
}
