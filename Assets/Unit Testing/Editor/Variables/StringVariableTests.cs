using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using RealDreams.Studio.Engine;

public class StringVariableTests {

	[Test]
	public void StringVariableTest_AreTheSameValueFromConstructor() {
		string expected = "randomString";
		StringVariable variable = new StringVariable("randomString");
		Assert.AreEqual(expected, variable.Value);
	}

	[Test]
	public void StringVariableTest_AreTheSameValue()
	{
		string expected = "randomString";
		StringVariable variable = new StringVariable();
		variable.Value = "randomString";
		Assert.AreEqual(expected, variable.Value);
	}
}
