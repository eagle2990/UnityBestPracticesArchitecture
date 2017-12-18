using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using RealDreams.Studio.Engine;

public class FloatReferenceTests {

	[Test]
	public void FloatReferenceTest_ConstantIsTheSameValue() {
		float expected = 123f;
		FloatReference actual = new FloatReference(123f);
		Assert.IsTrue(actual.UseConstant);
		Assert.AreEqual(expected, actual.Value);
	}

	[Test]
	public void FloatReferenceTest_ConstantValueIsEqualToValue()
	{
		FloatReference actual = new FloatReference(123f);
		Assert.IsTrue(actual.UseConstant);
		Assert.AreEqual(actual.ConstantValue, actual.Value);
	}

	[Test]
	public void FloatReferenceTest_FloatVariableIsTheSameValue()
	{
		FloatVariable expected = ScriptableObject.CreateInstance<FloatVariable>();
		expected.SetValue(123f);

		FloatReference actual = new FloatReference();
		actual.UseConstant = false;
		actual.Variable = ScriptableObject.CreateInstance<FloatVariable>();
		actual.Variable.SetValue(123f);

		Assert.IsFalse(actual.UseConstant);
		Assert.AreEqual(expected.Value, actual.Value);
		Assert.IsInstanceOf<FloatVariable>(actual.Variable);
	}

	[Test]
	public void FloatReferenceTest_FloatVariableIsEqualToValue()
	{
		FloatReference actual = new FloatReference();
		actual.UseConstant = false;
		actual.Variable = ScriptableObject.CreateInstance<FloatVariable>();
		actual.Variable.SetValue(123f);

		Assert.IsFalse(actual.UseConstant);
		Assert.AreEqual(actual.Variable.Value, actual.Value);
	}

	[Test]
	public void FloatReferenceTest_ValueConvertsToFloatImplicitly()
	{
		float expected = 0f;
		FloatReference floatReference = new FloatReference();
		float actual = floatReference;
		Assert.AreEqual(expected, actual);
	}
}
