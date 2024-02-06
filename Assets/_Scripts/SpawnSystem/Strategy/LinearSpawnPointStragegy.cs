using UnityEngine;

public class LinearSpawnPointStragegy : ISpawnPointStrategy
{
    private int _index = 0;
    private Transform[] _spawnPoints;
    
    public LinearSpawnPointStragegy(Transform[] spawnPoints) 
    {
        _spawnPoints = spawnPoints;
    }
    
    public Transform NextSpawnPoint() 
    {
        Transform result = _spawnPoints[_index];
        _index = (_index + 1) % _spawnPoints.Length;
        
        return result;
    }
}