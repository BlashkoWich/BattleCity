using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shoot
{
    public class ShootTower : ShootBullet
    {
        [SerializeField]
        private float _timeBetweenShoot;
        private void Start()
        {
            InvokeRepeating(nameof(Shoot), _timeBetweenShoot, _timeBetweenShoot);
        }
    }
}
