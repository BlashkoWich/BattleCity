using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuffObserver : MonoBehaviour
{
    [SerializeField]
    private BuffStorage _buffStorage;
    
    [SerializeField]
    private TextMeshProUGUI _buffInvulnerabilityTxt;
    [SerializeField]
    private TextMeshProUGUI _buffFastReloaderTxt;
    private void OnEnable()
    {
        _buffStorage.TakeBuff += BuffVisualisator;
    }
    private void OnDisable()
    {
        _buffStorage.TakeBuff -= BuffVisualisator;
    }
    private void BuffVisualisator(BuffDealer buffDealer)
    {
        switch (buffDealer.BuffType)
        {
            case BuffType.FastReload:
                _buffFastReloaderTxt.enabled = true;
                StartCoroutine(Deactivate(buffDealer, _buffFastReloaderTxt));
                break;
            case BuffType.Invulnerability:
                _buffInvulnerabilityTxt.enabled = true;
                StartCoroutine(Deactivate(buffDealer, _buffInvulnerabilityTxt));
                break;
        }
    }
    private IEnumerator Deactivate(BuffDealer buffDealer, TextMeshProUGUI text)
    {
        yield return new WaitForSeconds(buffDealer.TimeToDebuff);
        text.enabled = false;
    }
}
