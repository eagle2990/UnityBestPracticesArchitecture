using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using RealDreams.Studio.Engine;
using System;

public class UnitHealthPlayTests {

	GameObject PlayerPrefab;
	GameObject EnemyPrefab;

	GameObject bot;
	UnitData botStats;
	FloatVariable botHP;

	GameObject enemy;
	EnemyData enemyStats;

	[OneTimeSetUp]
	public void Init()
	{
		PlayerPrefab = Resources.Load<GameObject>("Units/Player/Player");
		EnemyPrefab = Resources.Load<GameObject>("Units/Enemies/DumbEnemy/DumbEnemy");

		//botHP = ScriptableObject.CreateInstance<FloatVariable>();

		//botStats = ScriptableObject.CreateInstance<PlayerData>();
		//botStats.MaxHP = new FloatReference(120f);
		//botStats.HP = botHP;

		bot = CreateGameObject(PlayerPrefab, botStats);
	}

	[UnityTest]
	public IEnumerator UnitHealtTest_StartsWithMaxHP() {
		yield return null;
		botStats = bot.GetComponent<UnitHealth>().BaseStats;
		Assert.AreEqual(botStats.MaxHP.Value, botStats.HP.Value);
	}

	[Test]
	public void UnitHealtTest_RecievesDamage()
	{
		throw new NotImplementedException();
	}

	[Test]
	public void UnitHealtTest_DeathEventInvoked()
	{
		throw new NotImplementedException();
	}

	[Test]
	public void UnitHealtTest_DamageEventInvoked()
	{
		throw new NotImplementedException();
	}

	private GameObject CreateGameObject(GameObject prefab, UnitData stats)
	{
		GameObject character = GameObject.Instantiate(prefab);
		//UnitHealth health = character.GetComponent<UnitHealth>();
		//health.BaseStats = stats;
		return character;
	}
}
