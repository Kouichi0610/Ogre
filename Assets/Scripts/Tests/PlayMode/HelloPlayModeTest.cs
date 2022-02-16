using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

// テスト試作
public class HelloPlayModeTest
{
    [SetUp]
    public void Init()
    {
        SceneManager.LoadScene("HelloTest");
    }
    [TearDown]
    public void Finish()
    {

    }
    // A Test behaves as an ordinary method
    [Test]
    public void HelloPlayModeTestSimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.That(3 * 4, Is.EqualTo(12));
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator HelloPlayModeTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
