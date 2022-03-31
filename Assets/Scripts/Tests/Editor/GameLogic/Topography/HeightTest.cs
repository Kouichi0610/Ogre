using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Ogre.GameLogic.Topography.Location;
using System.Linq;

public class HeightTest
{
    [Test]
    public void 高さ_実数の十分の一になっていること()
    {
        var height = new Height(151);
        Assert.That(height.ToFloat, Is.EqualTo(15.1f));
    }
    [Test]
    public void 高さ_マイナスにならないこと()
    {
        var height = new Height(-100);
        Assert.That(height.ToFloat, Is.Zero);
    }

    [Test]
    public void 高さ_加算()
    {
        var h = new Height(152);
        h += new Height(50);
        Assert.That(h.ToFloat, Is.EqualTo(20.2f));

        // オーバーフローを起こさないこと
        h += new Height(32767);
        Assert.That(h.ToFloat, Is.EqualTo(3276.7f));
    }
    [Test]
    public void 高さ_減算()
    {
        var h = new Height(152);
        h -= new Height(50);
        Assert.That(h.ToFloat, Is.EqualTo(10.2f));

        // 0未満にならないこと
        h -= new Height(200);
        Assert.That(h.ToFloat, Is.Zero);
    }
    [Test]
    public void 高さ_インクリメント_デクリメント()
    {
        var height = new Height(151);
        height++;
        Assert.That(height.ToFloat, Is.EqualTo(15.2f));

        height--;
        Assert.That(height.ToFloat, Is.EqualTo(15.1f));
    }

    [Test]
    public void 高さ_Equal()
    {
        var a = new Height(150);
        var b = new Height(150);

        Assert.That(a == b, Is.True);
        Assert.That(a != b, Is.False);

        b = new Height(151);
        Assert.That(a == b, Is.False);
        Assert.That(a != b, Is.True);
    }

    [Test]
    public void 高さ_比較()
    {
        var a = new Height(151);
        var b = new Height(150);

        Assert.That(a > b, Is.True);
        Assert.That(a >= b, Is.True);
        Assert.That(a < b, Is.False);
        Assert.That(a <= b, Is.False);

        b = new Height(151);
        Assert.That(a > b, Is.False);
        Assert.That(a >= b, Is.True);
        Assert.That(a < b, Is.False);
        Assert.That(a <= b, Is.True);

        b = new Height(152);
        Assert.That(a > b, Is.False);
        Assert.That(a >= b, Is.False);
        Assert.That(a < b, Is.True);
        Assert.That(a <= b, Is.True);
    }
}
