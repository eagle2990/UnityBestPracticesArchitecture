using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RealDreams.Studio.Engine
{
	public class UnitHealth : MonoBehaviour
	{
		public UnitData UnitBaseStats;
		public UnityEvent DamageEvent;
		public UnityEvent DeathEvent;

		void Start()
		{

			if (UnitBaseStats.HP.Value <= 0)
			{
				UnitBaseStats.HP.SetValue(UnitBaseStats.MaxHP.Value);
			}
		}
	}
}
