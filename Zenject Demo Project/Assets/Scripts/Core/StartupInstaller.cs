using Core.Services.UpdateService;
using UnityEngine.Experimental.PlayerLoop;
using Zenject;

namespace Core
{
    public class StartupInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IUpdateService>().To<UpdateService>().AsSingle();
            StartApplication();
        }

        private void StartApplication()
        {
            Container.Instantiate<UpdateService>().UpdateContent();
        }
    }
}