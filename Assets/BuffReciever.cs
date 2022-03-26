using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BuffReciever : MonoBehaviour
{
    public event Action<BuffDealer> BuffTouched;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.TryGetComponent<BuffDealer>(out BuffDealer buffDealer))
        {
            BuffTouched?.Invoke(buffDealer);
        }
    } 
}
