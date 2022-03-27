using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerToList : MonoBehaviour
{
    private PlayerTowerList playerTowerList;
    private void Start()
    {
        
        playerTowerList = FindObjectOfType<PlayerTowerList>();
        playerTowerList.AddPlayer(gameObject);
    }
    private void OnDestroy()
    {
        playerTowerList.RemovePlayer();
    }
}
