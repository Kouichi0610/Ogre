using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Ogre.GameLogic.Topography;
using System.Linq;

public class TopographyTest
{
    [Test]
    public void Directions()
    {
        var movers = Direction.GetAll();
        Assert.That(movers.Count(), Is.EqualTo(6));
        Assert.That(movers.ElementAt(0).ToString(), Is.EqualTo("1������"));
        Assert.That(movers.ElementAt(1).ToString(), Is.EqualTo("3������"));
        Assert.That(movers.ElementAt(2).ToString(), Is.EqualTo("5������"));
        Assert.That(movers.ElementAt(3).ToString(), Is.EqualTo("7������"));
        Assert.That(movers.ElementAt(4).ToString(), Is.EqualTo("9������"));
        Assert.That(movers.ElementAt(5).ToString(), Is.EqualTo("11������"));
    }
    [Test]
    public void �ꎞ����()
    {
        var d = Direction.One;
        var t = d.From(new Position(0, 0));
        Assert.That(t, Is.EqualTo(new Position(0, 1)));
        t = d.From(new Position(0, 1));
        Assert.That(t, Is.EqualTo(new Position(1, 2)));
    }
    [Test]
    public void �O������()
    {
        var d = Direction.Three;
        var t = d.From(new Position(0, 0));
        Assert.That(t, Is.EqualTo(new Position(1, 0)));
        t = d.From(new Position(1, 1));
        Assert.That(t, Is.EqualTo(new Position(2, 1)));
    }
    [Test]
    public void �܎�����()
    {
        var d = Direction.Five;
        var t = d.From(new Position(1, 1));
        Assert.That(t, Is.EqualTo(new Position(2, 0)));
        t = d.From(new Position(1, 2));
        Assert.That(t, Is.EqualTo(new Position(1, 1)));
    }
    [Test]
    public void ��������()
    {
        var d = Direction.Seven;
        var t = d.From(new Position(1, 1));
        Assert.That(t, Is.EqualTo(new Position(1, 0)));
        t = d.From(new Position(1, 2));
        Assert.That(t, Is.EqualTo(new Position(0, 1)));
    }

    [Test]
    public void �㎞����()
    {
        var d = Direction.Nine;
        var t = d.From(new Position(1, 0));
        Assert.That(t, Is.EqualTo(new Position(0, 0)));
        t = d.From(new Position(1, 1));
        Assert.That(t, Is.EqualTo(new Position(0, 1)));
    }
    [Test]
    public void �\�ꎞ����()
    {
        var d = Direction.Eleven;
        var t = d.From(new Position(1, 0));
        Assert.That(t, Is.EqualTo(new Position(0, 1)));
        t = d.From(new Position(0, 1));
        Assert.That(t, Is.EqualTo(new Position(0, 2)));
    }

    // TODO:�͈͊O
}
