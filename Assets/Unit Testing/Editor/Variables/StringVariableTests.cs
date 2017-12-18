using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using RealDreams.Studio.Engine;
using UnityEngine;

public class StringVariableTests {

	[Test]
	public void StringVariableTest_AreTheSameValue()
	{
		string expected = "randomString";
		StringVariable actual = ScriptableObject.CreateInstance<StringVariable>();
		actual.Value = "randomString";
		Assert.AreEqual(expected, actual.Value);
	}
}
