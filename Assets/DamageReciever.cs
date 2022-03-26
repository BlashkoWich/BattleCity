using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Damage;

namespace Damage
{
    [RequireComponent(typeof(Health.HealthStorage))]
    public class DamageReciever : MonoBehaviour
    {
        public event Action<Damage.DamageDealer> DamageTouched;
        [HideInInspector]
        public bool isInvulnerability;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(isInvulnerability == true)
            {
                return;
            }
            if (collision.gameObject.TryGetComponent<Damage.DamageDealer>(out Damage.DamageDealer damageDealer))
            {
                DamageTouched?.Invoke(damageDealer);
            }
        }
    }    
}
