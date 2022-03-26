using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInitialize : Initializer
{
    [SerializeField]
    private int _damage;

    public override void Start()
    {
        base.Start();
        GetComponent<Shoot.ShootBullet>().Initialize(_team, _damage);
    }
}
