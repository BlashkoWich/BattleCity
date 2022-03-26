using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Damage
{
    public class DamageDealer : MonoBehaviour
    {
        private Team _team;
        public Team Team => _team;
        private int _damage;
        public int Damage => _damage;

        public void Initialize(Team team, int damage)
        {
            _team = team;
            _damage = damage;
        }
    }    
}
