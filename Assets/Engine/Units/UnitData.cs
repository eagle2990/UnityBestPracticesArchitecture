using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RealDreams.Studio.Engine
{
	public abstract class UnitData : ScriptableObject
	{
		public string Name = "Unit";
		public FloatReference MaxHP;
		public FloatReference MoveSpeed;
		public FloatVariable HP;
		public UnitType Type;
	}
}
