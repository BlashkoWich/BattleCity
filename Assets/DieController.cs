using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Health
{
    [RequireComponent(typeof(HealthStorage))]
    public class DieController : MonoBehaviour
    {
        private HealthStorage _healthStorage;

        private void Start()
        {
            _healthStorage = GetComponent<HealthStorage>();
            _healthStorage.CurrentHealth += UpdateHealth;
        }
        private void OnDestroy()
        {
            _healthStorage.CurrentHealth -= UpdateHealth;
        }

        private void UpdateHealth(int currentHealth)
        {
            if(currentHealth == 0)
            {
                Destroy(gameObject);
            }
        }
    }   
}
