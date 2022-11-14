using PlayerLogic;
using Zenject;

namespace Infrastructure
{
    public class PlayerInputServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.
                Bind<IPlayerInputService>().
                To<PlayerInputService>().
                AsSingle();
        }
    }
}
