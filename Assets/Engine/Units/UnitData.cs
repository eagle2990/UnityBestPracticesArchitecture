using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RealDreams.Studio.Engine
{
	public class UnitData : ScriptableObject
	{
		public string Name;
		public FloatReference MaxHP;
		public FloatReference MoveSpeed;
		public FloatVariable HP;
		public UnitType Type;
	}
}
