using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _readySpawnpoint;
    private Dictionary<GameObject, GameObject> _notReadySpawnPoint = new Dictionary<GameObject, GameObject>();
    [SerializeField]
    private GameObject _buffPrefab;
    
    [SerializeField]
    private float _timeBetweenSpawn;
    private void Start()
    {
        InvokeRepeating(nameof(SpawnBuff), _timeBetweenSpawn, _timeBetweenSpawn);
    }
    private void SpawnBuff()
    {
        if(_readySpawnpoint.Count > 0)
        {
            int selectSpawnPoint = Random.Range(0, _readySpawnpoint.Count);
            GameObject buff = Instantiate(_buffPrefab, _readySpawnpoint[selectSpawnPoint].transform.position, Quaternion.identity);
            
            int selectBuffType = Random.Range(0, 2);
            buff.GetComponent<BuffInitializer>().Initialize(this, (BuffType)selectBuffType);
            
            _notReadySpawnPoint.Add(buff,_readySpawnpoint[selectSpawnPoint]);
            _readySpawnpoint.RemoveAt(selectSpawnPoint);
        }
    }

    public void AddSpawnpoint(GameObject buff)
    {
        _readySpawnpoint.Add(_notReadySpawnPoint[buff]);
    }
}
