using UnityEngine;

namespace RealDreams.Studio.Engine
{
	[CreateAssetMenu]
	public class StringVariable : ScriptableObject
	{
		[SerializeField]
		private string value = "";

		public string Value
		{
			get { return value; }
			set { this.value = value; }
		}

		public StringVariable(string Input)
		{
			Value = Input;
		}

		public StringVariable()
		{
		}
	}
}