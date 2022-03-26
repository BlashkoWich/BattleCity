using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffDealer : MonoBehaviour
{
    private BuffType _buffType;
    public BuffType BuffType => _buffType;
    [SerializeField]
    private float _timeToDebuff;
    public float TimeToDebuff => _timeToDebuff;
    public void Initialize(BuffType buffType)
    {
        _buffType = buffType;
    }
    public void Initialize(BuffType buffType, float timeToDebuff)
    {
        _buffType = buffType;
        _timeToDebuff = timeToDebuff;
    }
    
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.TryGetComponent<BuffReciever>(out BuffReciever buffReciever))
        {
            Destroy(gameObject);
        }
    } 
}
public enum BuffType
{
    FastReload,
    Invulnerability
}
