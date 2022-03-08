using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Ogre.GameLogic.Topography;
using System.Linq;

public class DirectionTest
{
    [Test]
    public void Directions()
    {
        var movers = Direction.GetAll();
        Assert.That(movers.Count(), Is.EqualTo(6));
        Assert.That(movers.ElementAt(0).ToString(), Is.EqualTo("1時方向"));
        Assert.That(movers.ElementAt(1).ToString(), Is.EqualTo("3時方向"));
        Assert.That(movers.ElementAt(2).ToString(), Is.EqualTo("5時方向"));
        Assert.That(movers.ElementAt(3).ToString(), Is.EqualTo("7時方向"));
        Assert.That(movers.ElementAt(4).ToString(), Is.EqualTo("9時方向"));
        Assert.That(movers.ElementAt(5).ToString(), Is.EqualTo("11時方向"));
    }
    [Test]
    public void 一時方向()
    {
        var d = Direction.One;
        var t = d.From(new Position(0, 0));
        Assert.That(t, Is.EqualTo(new Position(0, 1)));
        t = d.From(new Position(0, 1));
        Assert.That(t, Is.EqualTo(new Position(1, 2)));
    }
    [Test]
    public void 三時方向()
    {
        var d = Direction.Three;
        var t = d.From(new Position(0, 0));
        Assert.That(t, Is.EqualTo(new Position(1, 0)));
        t = d.From(new Position(1, 1));
        Assert.That(t, Is.EqualTo(new Position(2, 1)));
    }
    [Test]
    public void 五時方向()
    {
        var d = Direction.Five;
        var t = d.From(new Position(1, 1));
        Assert.That(t, Is.EqualTo(new Position(2, 0)));
        t = d.From(new Position(1, 2));
        Assert.That(t, Is.EqualTo(new Position(1, 1)));
    }
    [Test]
    public void 七時方向()
    {
        var d = Direction.Seven;
        var t = d.From(new Position(1, 1));
        Assert.That(t, Is.EqualTo(new Position(1, 0)));
        t = d.From(new Position(1, 2));
        Assert.That(t, Is.EqualTo(new Position(0, 1)));
    }

    [Test]
    public void 九時方向()
    {
        var d = Direction.Nine;
        var t = d.From(new Position(1, 0));
        Assert.That(t, Is.EqualTo(new Position(0, 0)));
        t = d.From(new Position(1, 1));
        Assert.That(t, Is.EqualTo(new Position(0, 1)));
    }
    [Test]
    public void 十一時方向()
    {
        var d = Direction.Eleven;
        var t = d.From(new Position(1, 0));
        Assert.That(t, Is.EqualTo(new Position(0, 1)));
        t = d.From(new Position(0, 1));
        Assert.That(t, Is.EqualTo(new Position(0, 2)));
    }

    // TODO:範囲外
}
