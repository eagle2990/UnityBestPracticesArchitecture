using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RealDreams.Studio.Engine
{
	public class UnitHealth : MonoBehaviour
	{
		public FloatVariable HP;
		public FloatReference StartingHP;
		public UnityEvent DamageEvent;
		public UnityEvent DeathEvent;

		void Start()
		{
			if (HP.Value <= 0)
			{
				HP.SetValue(StartingHP.Value);
			}
		}
	}
}
