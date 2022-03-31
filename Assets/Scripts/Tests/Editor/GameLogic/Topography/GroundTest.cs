using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Ogre.GameLogic.Topography;
using Ogre.GameLogic.Topography.Location;
using System.Runtime.InteropServices;
using Ogre.Infra.File;

public class GroundTest
{
    [Test]
    public void Groundサイズチェック()
    {
        var g = new Ground(10, 10);
        Assert.That(Marshal.SizeOf(g), Is.EqualTo(4));
    }

    [Test]
    public void BinaryReadWriter()
    {
        byte[] a;
        using (var w = new BinaryWriter())
        {
            w.Write(15);
            w.Write(65535);

            a = w.Binary;

            Assert.That(a.Length, Is.EqualTo(8));
        }
        using (var r = new BinaryReader(a))
        {
            var x = r.Read<int>();
            var y = r.Read<int>();

            Assert.That(x, Is.EqualTo(15));
            Assert.That(y, Is.EqualTo(65535));
        }
    }
    [Test]
    public void BinaryReadWriter_Array()
    {
        byte[] bytes;
        var e = new Vector3[3];
        for (int i = 0; i < e.Length; i++)
        {
            e[i] = new Vector3(i, i + 1, 10 + i);
        }
        using (var w = new BinaryWriter())
        {
            w.WriteArray(e);
            bytes = w.Binary;
        }
        using (var r = new BinaryReader(bytes))
        {
            var a = r.ReadArray<Vector3>();
            Assert.That(e.Length, Is.EqualTo(a.Length));

            Assert.That(e, Is.EqualTo(a));
        }
    }
    [Test]
    public void BinaryReadWriter_ArraySquare()
    {
        byte[] bytes;
        var e = new Vector3[4, 2];
        for (int i = 0; i < e.GetLength(0); i++)
        {
            for (int j = 0; j < e.GetLength(1); j++)
            {
                e[i, j] = new Vector3(i + 1, j + 5, i * j);
            }
        }
        using (var w = new BinaryWriter())
        {
            w.WriteArraySquare(e);
            bytes = w.Binary;
        }
        using (var r = new BinaryReader(bytes))
        {
            var a = r.ReadArraySquare<Vector3>();

            Assert.That(e.GetLength(0), Is.EqualTo(a.GetLength(0)));
            Assert.That(e.GetLength(1), Is.EqualTo(a.GetLength(1)));
            Assert.That(a, Is.EqualTo(e));
        }
    }
}
