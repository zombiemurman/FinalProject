using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using Assets._Project.Develop.Runtime.Gameplay.Features.AI;
using Assets._Project.Develop.Runtime.Gameplay.Features.InputFeature;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.AssetsManagment;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Gameplay.Infrastructure
{
    public class GameplayContextRegistrations
    {
        public static void Process(DIContainer container, GameplayInputArgs args)
        {
            container.RegisterAsSingle(CreateEntitiesFactory);
            container.RegisterAsSingle(CreateEntitiesLifeContext);
            container.RegisterAsSingle(CreateCollidersRegistryService);
            container.RegisterAsSingle(CreateBrainsFacttory);
            container.RegisterAsSingle(CreateAIBrainsContext);
            
            container.RegisterAsSingle<IInputService>(CreateDesktopInput);
            
            container.RegisterAsSingle(CreateMomoEntitiesFactory).NonLazy();
        }

        private static DesktopInput CreateDesktopInput(DIContainer container)
        {
            return new DesktopInput();
        }

        private static AIBrainsContext CreateAIBrainsContext(DIContainer container)
        {
            return new AIBrainsContext();
        }

        private static BrainsFacttory CreateBrainsFacttory(DIContainer container)
        {
            return new BrainsFacttory(container);
        }

        private static CollidersRegistryService CreateCollidersRegistryService(DIContainer container)
        {
            return new CollidersRegistryService();
        }

        private static MonoEntitiesFactory CreateMomoEntitiesFactory(DIContainer container)
        {
            return new MonoEntitiesFactory(
                container.Resolve<ResourcesAssetsLoader>(),
                container.Resolve<EntitiesLifeContext>(),
                container.Resolve<CollidersRegistryService>());
        }

        private static EntitiesLifeContext CreateEntitiesLifeContext(DIContainer container)
        {
            return new EntitiesLifeContext();
        }

        private static EntitiesFactory CreateEntitiesFactory(DIContainer container)
        {
            return new EntitiesFactory(container);
        }
    }
}
