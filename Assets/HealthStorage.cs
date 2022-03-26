using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Health
{
    [RequireComponent(typeof(Damage.DamageReciever))]
    public class HealthStorage : MonoBehaviour
    {
        public event Action<int> CurrentHealth;
        private int _maxHealth;
        private int _currentHealth;
    
        private Team _team;

        private Damage.DamageReciever _damageReciever;
        void OnDestroy()
        {
            _damageReciever.DamageTouched -= TakeDamage;
        }
        private void Start()
        {
            _damageReciever = GetComponent<Damage.DamageReciever>();
            _damageReciever.DamageTouched += TakeDamage;
            _currentHealth = _maxHealth;
        }
        public void Initialize(Team team, int maxHealth)
        {
            _maxHealth = maxHealth;
            _team = team;
            _currentHealth = _maxHealth;
            CurrentHealth?.Invoke(_currentHealth);
        }

        public void TakeDamage(Damage.DamageDealer damageDealer)
        {
            if(damageDealer.Team == _team)
            {
                return;
            }
            _currentHealth -= damageDealer.Damage;
            CurrentHealth?.Invoke(_currentHealth);
        }
    }   
}
