using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
public class BulletDestoy : MonoBehaviour
{
        [SerializeField]
        private ParticleSystem _explosionEffect;

        private BoxCollider2D _collider2D;
        private SpriteRenderer _spriteRenderer;
        private Rigidbody2D _rigidbody2D;

        private void Start()
        {
            _collider2D = GetComponent<BoxCollider2D>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _rigidbody2D.bodyType = RigidbodyType2D.Static;
            _spriteRenderer.enabled = false;
            _collider2D.enabled = false;
            _explosionEffect.Play();
            Destroy(gameObject, 1);
        }
    }    
}
