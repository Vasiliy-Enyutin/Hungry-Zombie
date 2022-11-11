using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Transform _player;
        [SerializeField] private Transform _playerSpawnPoint;

        public override void InstallBindings()
        {
            Container.InstantiatePrefab(_player, _playerSpawnPoint.position, Quaternion.identity, null);
        }
    }
}
