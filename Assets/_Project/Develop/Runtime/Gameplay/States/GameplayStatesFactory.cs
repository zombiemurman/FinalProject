using Assets._Project.Develop.Runtime.Gameplay.Features.InputFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.MainHero;
using Assets._Project.Develop.Runtime.Gameplay.Features.StageFeatures;
using Assets._Project.Develop.Runtime.Gameplay.Infrastructure;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Meta.Features.LevelsProgression;
using Assets._Project.Develop.Runtime.UI.Gameplay;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using Assets._Project.Develop.Runtime.Utilities.CoroutinesManagment;
using Assets._Project.Develop.Runtime.Utilities.DataManagment.DataProviders;
using Assets._Project.Develop.Runtime.Utilities.SceneManagment;

namespace Assets._Project.Develop.Runtime.Gameplay.States
{
    public class GameplayStatesFactory
    {
        private readonly DIContainer _container;

        public GameplayStatesFactory(DIContainer container)
        {
            _container = container;
        }

        public PreperationState CreatePreperationState()
        {
            return new PreperationState(_container.Resolve<PreperationTriggerService>());
        }

        public StageProcessState CreateStageProcessState()
        {
            return new StageProcessState(_container.Resolve<StageProviderService>());
        }

        public WinState CreateWinState(GameplayInputArgs gameplayInputArgs)
        {
            return new WinState(
                _container.Resolve<IInputService>(),
                _container.Resolve<LevelsProgressionService>(),
                gameplayInputArgs,
                _container.Resolve<PlayerDataProvider>(),
                _container.Resolve<ICoroutinesPerformer>(),
                _container.Resolve<GameplayPopupService>());
        }

        public DefeatState CreateDefeatState()
        {
            return new DefeatState(
                _container.Resolve<IInputService>(),
                _container.Resolve<GameplayPopupService>());
        }

        public GameplayStateMachine CreateCoreLoopState()
        {
            PreperationTriggerService preperationTriggerService = _container.Resolve<PreperationTriggerService>();

            StageProviderService stageProviderService = _container.Resolve<StageProviderService>();

            PreperationState preperationState = CreatePreperationState();

            StageProcessState stageProcessState = CreateStageProcessState();

            ICompositCondition preperationToStageProcessCondition = new CompositeCondition()
                .Add(new FuncCondition(() => preperationTriggerService.HasMainHeroContact.Value))
                .Add(new FuncCondition(() => stageProviderService.HasNextStage()));

            FuncCondition stageProcessToPreperationCondition =
                new FuncCondition(() => stageProviderService.CurrentStageResult.Value == StageResults.Complited);

            GameplayStateMachine coreLoopState = new GameplayStateMachine();

            coreLoopState.AddState(preperationState);
            coreLoopState.AddState(stageProcessState);

            coreLoopState.AddTransition(preperationState, stageProcessState, preperationToStageProcessCondition);
            coreLoopState.AddTransition(stageProcessState, preperationState, stageProcessToPreperationCondition);

            return coreLoopState;
        }

        public GameplayStateMachine CreateGameplayStateMachine(GameplayInputArgs gameplayInputArgs)
        {
            PreperationTriggerService preperationTriggerService = _container.Resolve<PreperationTriggerService>();

            StageProviderService stageProviderService = _container.Resolve<StageProviderService>();

            MainHeroHolderService mainHeroHolderService = _container.Resolve<MainHeroHolderService>();

            GameplayStateMachine coreLoopState = CreateCoreLoopState();

            DefeatState defeatState = CreateDefeatState();

            WinState winState = CreateWinState(gameplayInputArgs);

            ICompositCondition coreLoopToWinStateCondition = new CompositeCondition()
                .Add(new FuncCondition(() => preperationTriggerService.HasMainHeroContact.Value))
                .Add(new FuncCondition(() => stageProviderService.CurrentStageResult.Value == StageResults.Complited))
                .Add(new FuncCondition(() => stageProviderService.HasNextStage() == false));

            ICompositCondition coreLoopToDefeatStateCondition = new CompositeCondition()
                .Add(new FuncCondition(() =>
                {
                    if(mainHeroHolderService.MainHero != null)
                        return mainHeroHolderService.MainHero.IsDead.Value; 

                    return false;
                }));

            GameplayStateMachine gameplayCycle = new GameplayStateMachine();

            gameplayCycle.AddState(coreLoopState);
            gameplayCycle.AddState(defeatState);
            gameplayCycle.AddState(winState);

            gameplayCycle.AddTransition(coreLoopState, winState, coreLoopToWinStateCondition);
            gameplayCycle.AddTransition(coreLoopState, defeatState, coreLoopToDefeatStateCondition);

            return gameplayCycle;
        }
    }
}
