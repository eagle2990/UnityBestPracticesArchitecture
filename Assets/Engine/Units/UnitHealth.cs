using UnityEngine;
using UnityEngine.Events;

namespace RealDreams.Studio.Engine
{
	public class UnitHealth : MonoBehaviour
	{
		public UnitData BaseStats;
		public bool RestartHP;
		public UnityEvent DamageEvent;
		public UnityEvent DeathEvent;
		
		void Start()
		{

			if (BaseStats.HP.Value <= 0 || RestartHP)
			{
				BaseStats.HP.SetValue(BaseStats.MaxHP.Value);
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			GotHitBy(other.gameObject);
		}

		private void OnCollisionEnter(Collision collision)
		{
			GotHitBy(collision.gameObject);
		}

		private void GotHitBy(GameObject other)
		{
			DamageDealer damage = GetDamageDealer(other);
			CalculateDamage(damage, other);
			CheckDeath();
		}

		private UnitType GetCollidedUnitType(GameObject other)
		{
			UnitHealth unitHealth = other.GetComponent<UnitHealth>() ?? other.GetComponentInParent<UnitHealth>();
			if (unitHealth != null)
			{
				return unitHealth.BaseStats.Type;
			}
			return null;
		}

		private void CalculateDamage(DamageDealer damage, GameObject other)
		{
			if (damage != null)
			{
				UnitType otherUnitType = GetCollidedUnitType(other.gameObject);
				if (IsOpposite(otherUnitType))
				{
					ApplyDamage(damage.DamageAmount);
				}
			}
		}

		private void CheckDeath()
		{
			if (BaseStats.HP.Value <= 0.0f)
			{
				DeathEvent.Invoke();
			}
		}

		private bool IsOpposite(UnitType oppositeType)
		{
			return BaseStats.Type.InjuredBy.Contains(oppositeType);
		}

		private void ApplyDamage(FloatReference amount)
		{
			BaseStats.HP.Add(-amount);
			DamageEvent.Invoke();
		}

		private DamageDealer GetDamageDealer(GameObject prefab)
		{
			DamageDealer damage = prefab.GetComponent<DamageDealer>() ?? prefab.GetComponentInParent<DamageDealer>();
			return damage;
		}

		
	}
}
