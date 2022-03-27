using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTowerToList : MonoBehaviour
{
    private PlayerTowerList playerTowerList;
    private void Start()
    {
        playerTowerList = FindObjectOfType<PlayerTowerList>();
        playerTowerList.AddTower(gameObject);
    }
    private void OnDestroy()
    {
        playerTowerList.RemoveTower(gameObject);
    }
}
