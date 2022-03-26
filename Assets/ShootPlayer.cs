using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shoot
{
    public class ShootPlayer : ShootBullet
    {
        [SerializeField]
        private float _timeReloadDefault;
        public float TimeReloadDefault => _timeReloadDefault;
        [HideInInspector]
        public float currentTimeReload;

        private void Start()
        {
            currentTimeReload = _timeReloadDefault;
        }

        private bool _isReady = true;
        private void Update()
        {
            if(Input.GetMouseButtonDown(0) && _isReady == true)
            {
                _isReady = false;
                Shoot();
                StartCoroutine(Reload());
            }
        }

        private IEnumerator Reload()
        {
            yield return new WaitForSeconds(currentTimeReload);
            _isReady = true;
        }
    }   
}
