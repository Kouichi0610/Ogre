using System;
using System.Runtime.InteropServices;

namespace Ogre.Infra.File
{
    public class BinaryWriter : IDisposable
    {
        readonly int maxSize = 32;
        int current;
        byte[] bytes = new byte[0];
        IntPtr ptr;

        public byte[] Binary => bytes;

        public BinaryWriter(int maxSize = 32)
        {
            this.maxSize = maxSize;
            current = 0;
            ptr = Marshal.AllocCoTaskMem(maxSize);
        }

        public void Write<T>(T d) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            if (size > maxSize) throw new ArgumentOutOfRangeException();
            Array.Resize(ref bytes, bytes.Length + size);

            Marshal.StructureToPtr(d, ptr, true);
            Marshal.Copy(ptr, bytes, current, size);
            current += size;
        }

        public void WriteArray<T>(T[] d) where T : struct
        {
            Write(d.Length);
            for (int i = 0; i < d.Length; i++)
            {
                Write(d[i]);
            }
        }
        public void WriteArraySquare<T>(T[,] d) where T : struct
        {
            var height = d.GetLength(0);
            var width = d.GetLength(1);
            Write(width);
            Write(height);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Write(d[i, j]);
                }
            }
        }

        void IDisposable.Dispose()
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }
}
