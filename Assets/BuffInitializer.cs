using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BuffDealer))]
public class BuffInitializer : MonoBehaviour
{
    [SerializeField]
    private BuffDealer _buffDealer;
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    
    [Tooltip("1 - FastReloader, 2 - Invulnerability")]
    [SerializeField]
    private Sprite[] _buffSprites;

    private BuffSpawner _buffSpawner;
    
    public void Initialize(BuffType buffType)
    {
        SpriteSelecter(buffType);
        _buffDealer.Initialize(buffType);
    }
    
    public void Initialize(BuffSpawner buffSpawner, BuffType buffType)
    {
        _buffSpawner = buffSpawner;
        SpriteSelecter(buffType);
        _buffDealer.Initialize(buffType);
    }
    public void Initialize(BuffType buffType, float timeToDebuff)
    {
        SpriteSelecter(buffType);
        _buffDealer.Initialize(buffType, timeToDebuff);
    }
    public void Initialize(BuffSpawner buffSpawner, BuffType buffType, float timeToDebuff)
    {
        _buffSpawner = buffSpawner;
        SpriteSelecter(buffType);
        _buffDealer.Initialize(buffType, timeToDebuff);
    }

    private void SpriteSelecter(BuffType buffType)
    {
        switch (buffType)
        {
            case BuffType.FastReload:
                _spriteRenderer.sprite = _buffSprites[0];
                break;
            case BuffType.Invulnerability:
                _spriteRenderer.sprite = _buffSprites[1];
                break;
        }
    }

    private void OnDestroy()
    {
        if(_buffSpawner != null)
        {
            _buffSpawner.AddSpawnpoint(gameObject);
        }
    }
}
