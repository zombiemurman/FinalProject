using Assets._Project.Develop.Runtime.Configs.Gameplay.Abilities;
using Assets._Project.Develop.Runtime.Configs.Gameplay.Levels;
using Assets._Project.Develop.Runtime.Configs.Gameplay.Loot;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesDropingFeatures;
using Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.AI;
using Assets._Project.Develop.Runtime.Gameplay.Features.Enemies;
using Assets._Project.Develop.Runtime.Gameplay.Features.InputFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.MainHero;
using Assets._Project.Develop.Runtime.Gameplay.Features.PauseFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.StageFeatures;
using Assets._Project.Develop.Runtime.Gameplay.States;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.UI;
using Assets._Project.Develop.Runtime.UI.Core;
using Assets._Project.Develop.Runtime.UI.Gameplay;
using Assets._Project.Develop.Runtime.Utilities.AssetsManagment;
using Assets._Project.Develop.Runtime.Utilities.ConfigsManagmet;
using Assets._Project.Develop.Runtime.Utilities.CoroutinesManagment;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Gameplay.Infrastructure
{
    public class GameplayContextRegistrations
    {
        private static GameplayInputArgs _inputArgs;

        public static void Process(DIContainer container, GameplayInputArgs args)
        {
            _inputArgs = args;

            container.RegisterAsSingle(CreateEntitiesFactory);
            container.RegisterAsSingle(CreateEntitiesLifeContext);
            container.RegisterAsSingle(CreateCollidersRegistryService);
            container.RegisterAsSingle(CreateBrainsFacttory);
            container.RegisterAsSingle(CreateAIBrainsContext);
            container.RegisterAsSingle(CreateMainHeroFactory);
            container.RegisterAsSingle(CreateEnemiesFactory);
            container.RegisterAsSingle(CreateStageFactory);
            container.RegisterAsSingle(CreateStageProviderService);
            container.RegisterAsSingle(CreatePreperationTriggerService);
            container.RegisterAsSingle(CreateGameplayStatesFactory);
            container.RegisterAsSingle(CreateGameplayStatesContext);
            container.RegisterAsSingle(CreateGameplayPresentersFactory);
            container.RegisterAsSingle(CreateGameplayPopupService);
            container.RegisterAsSingle(CreateAbilityFactory);
            container.RegisterAsSingle(CreateAbilityDropingRulesService);
            container.RegisterAsSingle(CreateAbilityDropService);
            container.RegisterAsSingle(CreateLootFactory);
            container.RegisterAsSingle(CreateDropLootService);
            
            container.RegisterAsSingle<IPauseService>(CreateTimeScalePauseService);
            container.RegisterAsSingle<IInputService>(CreateDesktopInput);
            
            container.RegisterAsSingle(CreateMomoEntitiesFactory).NonLazy();
            container.RegisterAsSingle(CreateMainHeroHolderService).NonLazy();
            container.RegisterAsSingle(CreateGameplayUIRoot).NonLazy();
            container.RegisterAsSingle(CreateGameplayScreenPresenter).NonLazy();
            container.RegisterAsSingle(CreateDropAbilityOnMainHeroLevelUpService).NonLazy();
            container.RegisterAsSingle(CreateLootPullingService).NonLazy();
        }

        private static LootPullingService CreateLootPullingService(DIContainer container)
        {
            return new LootPullingService(container.Resolve<EntitiesLifeContext>());
        }

        private static DropLootService CreateDropLootService(DIContainer container)
        {
            return new DropLootService(
                container.Resolve<ConfigsProviderService>().GetConfig<LootListConfig>(),
                container.Resolve<LootFactory>());
        }

        private static LootFactory CreateLootFactory(DIContainer container)
        {
            return new LootFactory(container);
        }

        private static TimeScalePauseService CreateTimeScalePauseService(DIContainer container)
        {
            return new TimeScalePauseService();
        }

        private static DropAbilityOnMainHeroLevelUpService CreateDropAbilityOnMainHeroLevelUpService(DIContainer container)
        {
            return new DropAbilityOnMainHeroLevelUpService(
                container.Resolve<MainHeroHolderService>(),
                container.Resolve<GameplayPopupService>(),
                container.Resolve<ICoroutinesPerformer>(),
                container.Resolve<IPauseService>());
        }

        private static AbilityDropService CreateAbilityDropService(DIContainer container)
        {
            return new AbilityDropService(
                container.Resolve<ConfigsProviderService>().GetConfig<AbilitiesConfigsContainer>(),
                container.Resolve<AbilityDropingRulesService>());
        }

        private static AbilityDropingRulesService CreateAbilityDropingRulesService(DIContainer container)
        {
            return new AbilityDropingRulesService();
        }

        private static AbilityFactory CreateAbilityFactory(DIContainer container)
        {
            return new AbilityFactory(container);
        }

        private static GameplayPopupService CreateGameplayPopupService(DIContainer container)
        {
            return new GameplayPopupService(
                container.Resolve<ViewsFactory>(),
                container.Resolve<ProjectPresentersFactory>(),
                container.Resolve<GameplayUIRoot>(),
                container.Resolve<GameplayPresentersFactory>());
        }

        private static GameplayUIRoot CreateGameplayUIRoot(DIContainer container)
        {
            ResourcesAssetsLoader resourcesAssetsLoader = container.Resolve<ResourcesAssetsLoader>();

            GameplayUIRoot gameplayUIRootPrefab = resourcesAssetsLoader
                .Load<GameplayUIRoot>("UI/Gameplay/GameplayUIRoot");

            return Object.Instantiate(gameplayUIRootPrefab);
        }

        private static GameplayScreenPresenter CreateGameplayScreenPresenter(DIContainer container)
        {
            GameplayUIRoot uiRoot = container.Resolve<GameplayUIRoot>();

            GameplayScreenView view = container
                .Resolve<ViewsFactory>()
                .Create<GameplayScreenView>(ViewIDs.GameplayScreen, uiRoot.HUDLayer);

            GameplayScreenPresenter presenter = container
                .Resolve<GameplayPresentersFactory>()
                .CreateGameplayScreenPresenter(view);

            return presenter;
        }

        private static GameplayPresentersFactory CreateGameplayPresentersFactory(DIContainer container)
        {
            return new GameplayPresentersFactory(container, _inputArgs);
        }

        private static GameplayStatesContext CreateGameplayStatesContext(DIContainer container)
        {
            return new GameplayStatesContext(
                container.Resolve<GameplayStatesFactory>().CreateGameplayStateMachine(_inputArgs));
        }

        private static GameplayStatesFactory CreateGameplayStatesFactory(DIContainer container)
        {
            return new GameplayStatesFactory(container);
        }

        private static MainHeroHolderService CreateMainHeroHolderService(DIContainer container)
        {
            return new MainHeroHolderService(container.Resolve<EntitiesLifeContext>());
        }

        private static PreperationTriggerService CreatePreperationTriggerService(DIContainer container)
        {
            return new PreperationTriggerService(
                container.Resolve<EntitiesFactory>(),
                container.Resolve<EntitiesLifeContext>());
        }

        private static StageProviderService CreateStageProviderService(DIContainer container)
        {
            return new StageProviderService(
                container.Resolve<ConfigsProviderService>().GetConfig<LevelsListConfig>().GetBy(_inputArgs.LevelNumber), 
                container.Resolve<StageFactory>());
        }

        private static StageFactory CreateStageFactory(DIContainer container)
        {
            return new StageFactory(container);
        }

        private static MainHeroFactory CreateMainHeroFactory(DIContainer container)
        {
            return new MainHeroFactory(container);
        }

        private static EnemiesFactory CreateEnemiesFactory(DIContainer container)
        {
            return new EnemiesFactory(container);
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
