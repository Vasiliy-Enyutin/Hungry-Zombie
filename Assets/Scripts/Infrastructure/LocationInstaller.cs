using PlayerLogic;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class LocationInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private Transform _playerSpawnPoint;
        
        [SerializeField] private Transform _canvasUI;
        [SerializeField] private GameObject _floatingJoystick;

        public override void InstallBindings()
        {
            BindJoystick();
            //BindPlayerInputService();
            BindPlayer();
        }

        private void BindJoystick()
        {
            FloatingJoystick joystickInstance = Container
                .InstantiatePrefabForComponent<FloatingJoystick>(_floatingJoystick, _canvasUI);

            Container
                .Bind<FloatingJoystick>()
                .FromInstance(joystickInstance)
                .AsSingle();
        }

        private void BindPlayerInputService()
        {
            Container.Bind<IPlayerInputService>().To<PlayerInputService>().AsSingle();
        }

        private void BindPlayer()
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
