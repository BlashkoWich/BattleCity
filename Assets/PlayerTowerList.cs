using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerTowerList : MonoBehaviour
{
    public event Action<int> CountTower;
    public event Action PlayerDie;
    private List<GameObject> _towerList = new List<GameObject>();
    public List<GameObject> TowerList => _towerList;

    private GameObject _player;
    public GameObject Player => _player;
    public void AddTower(GameObject tower)
    {
        _towerList.Add(tower);
    }
    public void AddPlayer(GameObject player)
    {
        _player = player;
    }

    public void RemoveTower(GameObject tower)
    {
        _towerList.RemoveAt(_towerList.IndexOf(tower));
        CountTower?.Invoke(_towerList.Count);
    }
    public void RemovePlayer()
    {
        PlayerDie?.Invoke();
    }
}
