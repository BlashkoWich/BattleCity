using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet
{
public class BulletInitialize : MonoBehaviour
{
        private Team _team;
        public Team Team => _team;
    
        private int _damage;
        public int Damage => _damage;
    
        public void Initialize(Team team, int damage)
        {
            _team = team;
            _damage = damage;

            GetComponent<Damage.DamageDealer>().Initialize(_team, _damage);
        }
    }    
}
