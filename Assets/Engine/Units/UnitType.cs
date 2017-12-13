using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RealDreams.Studio.Engine
{
	[CreateAssetMenu]
	public class UnitType : ScriptableObject
	{
		public List<UnitType> InjuredBy = new List<UnitType>();
		public List<UnitType> AdvantageOver = new List<UnitType>();
	}
}


