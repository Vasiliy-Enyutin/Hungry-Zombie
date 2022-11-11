using PlayerLogic;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class PlayerInputServiceInstaller : MonoInstaller
    {
        [SerializeField] private PlayerInputService _playerInputService;
        
        public override void InstallBindings()
        {
            Container.
                Bind<IPlayerInputService>().
                To<PlayerInputService>().
                FromComponentInNewPrefab(_playerInputService).
                AsSingle();
        }
    }
}
