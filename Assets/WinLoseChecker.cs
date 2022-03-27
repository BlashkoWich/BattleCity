using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseChecker : MonoBehaviour
{
    [SerializeField]
    private PlayerTowerList _playerTowerList;

    [SerializeField]
    private GameObject _mainPanel;
    [SerializeField]
    private GameObject _winPanel;
    [SerializeField]
    private GameObject _losePanel;
    private void OnEnable()
    {
        _playerTowerList.PlayerDie += LoseGame;
        _playerTowerList.CountTower += WinGame;
    }
    private void OnDisable()
    {
        _playerTowerList.PlayerDie -= LoseGame;
        _playerTowerList.CountTower -= WinGame;
    }

    private void WinGame(int towerCount)
    {
        if(towerCount == 0)
        {
            _mainPanel.SetActive(false);
            _winPanel.SetActive(true);
        }
    }
    private void LoseGame()
    {
        _mainPanel.SetActive(false);
        _losePanel.SetActive(true);
    }
}
