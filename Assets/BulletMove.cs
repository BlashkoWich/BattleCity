using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet
{
    public class BulletMove : MonoBehaviour
    {
        [SerializeField]
        private float _speed;
        private Rigidbody2D _rigidbody2D;

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            if(_rigidbody2D.bodyType != RigidbodyType2D.Static)
            {
                _rigidbody2D.velocity = _rigidbody2D.transform.up * _speed;
            }
        }
    }   
}
