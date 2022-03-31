using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

namespace Ogre.Infra.File
{
    public class BinaryReader : IDisposable
    {
        readonly int maxSize = 32;
        int current;
        byte[] bytes;
        IntPtr ptr;

        public BinaryReader(byte[] bytes, int maxSize = 32)
        {
            current = 0;
            this.bytes = bytes;
            this.maxSize = maxSize;
            ptr = Marshal.AllocCoTaskMem(maxSize);
        }

        public T Read<T>() where T : struct
        {
            var size = Marshal.SizeOf<T>();
            if (size > maxSize) throw new ArgumentOutOfRangeException();
            Marshal.Copy(bytes, current, ptr, size);
            var res = Marshal.PtrToStructure<T>(ptr);
            current += size;
            return res;
        }
        // TODO:名称変更？(System.IOと被る)
        public T[] ReadArray<T>() where T : struct
        {
            var length = Read<int>();
            var res = new T[length];
            for (int i = 0; i < length; i++)
            {
                res[i] = Read<T>();
            }
            return res;
        }
        public T[,] ReadArraySquare<T>() where T : struct
        {
            var width = Read<int>();
            var height = Read<int>();
            var res = new T[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    res[i, j] = Read<T>();
                }
            }
            return res;
        }

        void IDisposable.Dispose()
        {
            Marshal.FreeCoTaskMem(ptr);

        }
    }
}
