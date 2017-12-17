using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using RealDreams.Studio.Engine;

public class FloatVariableTests {

	[Test]
	public void FloatVariableTest_AreTheSameValue() {
		float expected = 123f;
		FloatVariable actual = new FloatVariable();
		actual.SetValue(123f);
		Assert.AreEqual(expected, actual.Value);
	}

	[Test]
	public void FloatVariableTest_AreDifferentValues()
	{
		float expected = 123f;
		FloatVariable actual = new FloatVariable();
		actual.SetValue(4f);
		Assert.AreNotSame(expected, actual.Value);
	}

	[Test]
	public void FloatVariableTest_Adds()
	{
		float expected = 123f;
		FloatVariable actual = new FloatVariable();
		actual.Add(123f);
		Assert.AreEqual(expected, actual.Value);
	}

	[Test]
	public void FloatVariableTest_Subtracts()
	{
		float expected = -123f;
		FloatVariable actual = new FloatVariable();
		actual.Add(-123f);
		Assert.AreEqual(expected, actual.Value);
	}
}
