using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Health
{
    public class HealthObserver : MonoBehaviour
    {
        [SerializeField]
        private RawImage[] _hearthUI;
        [SerializeField]
        private HealthStorage _healthStorage;

        private void OnEnable()
        {
            _healthStorage.CurrentHealth +=  UpdateHealth;
        }
        private void OnDisable()
        {
            _healthStorage.CurrentHealth -= UpdateHealth;
        }

        private void UpdateHealth(int currentHealth)
        {
            foreach (var hearth in _hearthUI)
            {
                hearth.enabled = false;
            }
            for (int i = 0; i < currentHealth; i++)
            {
                _hearthUI[i].enabled = true;
            }
        }
    }   
}
