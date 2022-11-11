using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class FloatingJoystickInstaller : MonoInstaller
    {
        [SerializeField] private Transform _canvasUI;
        [SerializeField] private GameObject _floatingJoystick;


        public override void InstallBindings()
        {
            FloatingJoystick joystickInstance = Container
                .InstantiatePrefabForComponent<FloatingJoystick>(_floatingJoystick, _canvasUI);

            Container
                .Bind<FloatingJoystick>()
                .FromInstance(joystickInstance)
                .AsSingle();
        }
    }
}
