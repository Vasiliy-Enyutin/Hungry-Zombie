using System.Collections.Generic;
using UnityEngine;

namespace EnemyLogic
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _meleeEnemyPrefab;
        [SerializeField] private List<Transform> _enemySpawnPoints;

        private void Awake()
        {
            SpawnEnemies();
        }

        private void SpawnEnemies()
        {
            _enemySpawnPoints.ForEach(spawnPoint => Instantiate(_meleeEnemyPrefab, spawnPoint.position, Quaternion.identity));
        }
    }
}
