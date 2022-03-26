using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shoot
{
    public abstract class ShootBullet : MonoBehaviour
    {
        [SerializeField]
        private GameObject _bullet;
        [SerializeField]
        private GameObject[] _guns;
        private Team _team;
        private int _damage;

        public void Initialize(Team team, int damage)
        {
            _team = team;
            _damage = damage;
        }
        public void Shoot()
        {
            InitializeBullet();
        }
        private void InitializeBullet()
        {
            foreach (var gun in _guns)
            {
                Quaternion _bulletDirection = gun.transform.rotation;
                GameObject bullet = Instantiate(_bullet, gun.transform.position, _bulletDirection);        
                bullet.GetComponent<Bullet.BulletInitialize>().Initialize(_team, _damage);
            }
        }
    }   
}
