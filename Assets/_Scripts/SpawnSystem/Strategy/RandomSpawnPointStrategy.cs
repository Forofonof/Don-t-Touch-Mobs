using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class RandomSpawnPointStrategy : ISpawnPointStrategy 
{
    private List<Transform> _unusedSpawnPoints;
    private Transform[] _spawnPoints;
    
    public RandomSpawnPointStrategy(Transform[] spawnPoints) 
    {
        _spawnPoints = spawnPoints;
        _unusedSpawnPoints = new List<Transform>(spawnPoints);
    }
    
    public Transform NextSpawnPoint() 
    {
        if (!_unusedSpawnPoints.Any()) 
        {
            _unusedSpawnPoints = new List<Transform>(_spawnPoints);
        }
        
        var randomIndex = Random.Range(0, _unusedSpawnPoints.Count);

        Transform result = _unusedSpawnPoints[randomIndex];
        _unusedSpawnPoints.RemoveAt(randomIndex);
        
        return result;
    }
}