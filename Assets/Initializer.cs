using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Initializer : MonoBehaviour
{
    [SerializeField]
    protected Team _team;
    [SerializeField]
    private int _maxHealth;

    public virtual void Start()
    {
        GetComponent<Health.HealthStorage>().Initialize(_team, _maxHealth);
    }
}
