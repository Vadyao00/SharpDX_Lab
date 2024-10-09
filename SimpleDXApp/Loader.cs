using System;
using System.Collections.Generic;
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

        public MeshObject MakePlane(Vector4 position, float yaw, float pitch, float roll, uint n)
        {
            n++;
            Renderer.VertexDataStruct[] vertices = FillPlane(n, 20.0f / n);
            uint[] indices = FillIndices(n);
            return new MeshObject(_directX3DGraphics, position,
                yaw, pitch, roll, vertices, indices);
        }
        private Renderer.VertexDataStruct[] FillPlane(uint n, float step)
        {
            var verts = new Renderer.VertexDataStruct[n * n];
            float size = (n - 1) * step;
            float curX = -size / 2;
            float curY = -size / 2;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    verts[n * i + j] = new Renderer.VertexDataStruct() { position = new Vector4(curX + i * step, 0, curY + j * step, 1), color = new Vector4(0, 0,0,0) };
            return verts;
        }
        private uint[] FillIndices(uint n)
        {
            List<uint> indices = new List<uint>();
            uint ptr = 0;
            for (uint j = 0; j < (n - 1) * ((n - 1) * 6); j += (n - 1) * 6)
            {

                for (uint i = 0; i < (n - 1) * 6; i += 6)
                {
                    indices.Add(i / 6 + ptr);
                    indices.Add(i / 6 + n + ptr);
                    indices.Add(i / 6 + n + 1 + ptr);
                    indices.Add(i / 6 + ptr);
                    indices.Add(i / 6 + n + 1 + ptr);
                    indices.Add(i / 6 + 1 + ptr);
                }
                ptr += n;
            }
            return indices.ToArray();
        }

        public void Dispose()
        {

        }
    }
}
