using PlayerLogic;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private Transform _playerSpawnPoint;

        public override void InstallBindings()
        {
            PlayerMovement playerInstance = Container
                .InstantiatePrefabForComponent<PlayerMovement>(_player, _playerSpawnPoint.position, Quaternion.identity, null);
            
            Container
                .Bind<PlayerMovement>()
                .FromInstance(playerInstance)
                .AsSingle();
        }
    }
}
