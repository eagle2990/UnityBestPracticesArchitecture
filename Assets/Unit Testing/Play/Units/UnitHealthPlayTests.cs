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
	GameObject enemy;

	[OneTimeSetUp]
	public void Init()
	{
		PlayerPrefab = Resources.Load<GameObject>("Units/Player/Player");
		bot = CreateGameObject(PlayerPrefab);
	}

	[UnityTest]
	public IEnumerator UnitHealtTest_StartsWithMaxHP() {
		yield return null;
		UnitData botStats = bot.GetComponent<UnitHealth>().BaseStats;
		Assert.AreEqual(botStats.MaxHP.Value, botStats.HP.Value);
	}

	[UnityTest]
	public IEnumerator UnitHealtTest_RecievesDamage()
	{
		CreateEnemy();
		bot.transform.position = enemy.transform.position;
		yield return null;
		UnitData enemyStats = enemy.GetComponent<UnitHealth>().BaseStats;
		Assert.AreNotEqual(enemyStats.MaxHP.Value, enemyStats.HP.Value);
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

	private GameObject CreateGameObject(GameObject prefab)
	{
		GameObject character = GameObject.Instantiate(prefab);
		return character;
	}

	private void CreateEnemy()
	{
		EnemyPrefab = Resources.Load<GameObject>("Units/Enemies/DumbEnemy/DumbEnemy");
		enemy = CreateGameObject(EnemyPrefab);
	}
}