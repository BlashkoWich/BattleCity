using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BuffStorage))]
public class BuffFastReloader : MonoBehaviour
{
    private Shoot.ShootPlayer _shootPlayer;
    private void Start()
    {
        _shootPlayer = GetComponent<Shoot.ShootPlayer>();
    }
    public void ActivateBuff(float timeToDebuff)
    {
        _shootPlayer.currentTimeReload /= 2;
        Invoke(nameof(DeactivateBuff), timeToDebuff);
    }
    private void DeactivateBuff()
    {
        _shootPlayer.currentTimeReload = _shootPlayer.TimeReloadDefault;
    }
}
