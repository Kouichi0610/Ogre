using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HelloTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void HelloTestSimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.That(1 + 2, Is.EqualTo(3));
    }

}
