using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BuffReciever))]
public class BuffStorage : MonoBehaviour
{
    private BuffInvulnerability _buffInvulnerability;
    private BuffFastReloader _buffFastReloader;

    [SerializeField]
    private BuffReciever _buffReciever;

    private void OnEnable()
    {
        _buffReciever.BuffTouched += Activator;
    }
    private void OnDisable()
    {
        _buffReciever.BuffTouched -= Activator;
    }

    private void Start()
    {
        _buffInvulnerability = GetComponent<BuffInvulnerability>();
        _buffFastReloader = GetComponent<BuffFastReloader>();
    }

    private void Activator(BuffDealer buffDealer)
    {
        switch (buffDealer.BuffType)
        {
            case BuffType.FastReload:
                _buffFastReloader.ActivateBuff(buffDealer.TimeToDebuff);
                break;
            case BuffType.Invulnerability:
                _buffInvulnerability.ActivateBuff(buffDealer.TimeToDebuff);
                break;
        }
    }
}
