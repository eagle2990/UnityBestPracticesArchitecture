using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using RealDreams.Studio.Engine;

public class UnitTypeTests {

	UnitType water;
	UnitType fire;
	UnitType grass;

	[OneTimeSetUp]
	public void Init()
	{
		water = ScriptableObject.CreateInstance<UnitType>();
		fire = ScriptableObject.CreateInstance<UnitType>();
		grass = ScriptableObject.CreateInstance<UnitType>();

		water.InjuredBy.Add(grass);
		water.AdvantageOver.Add(fire);

		fire.InjuredBy.Add(water);
		fire.AdvantageOver.Add(grass);

		grass.InjuredBy.Add(fire);
		grass.AdvantageOver.Add(water);
	}

	[Test]
	public void UnitTypeTest_IsInjuredBy() {
		Assert.IsTrue(fire.IsInjuredBy(water));
	}

	[Test]
	public void UnitTypeTest_HasAdvantageOver()
	{
		Assert.IsTrue(fire.HasAdvantageOver(grass));
	}

	[Test]
	public void UnitTypeTest_IsNotInjuredBy()
	{
		Assert.IsFalse(fire.IsInjuredBy(grass));
	}

	[Test]
	public void UnitTypeTest_HasNotAdvantageOver()
	{
		Assert.IsFalse(fire.HasAdvantageOver(water));
	}
}
