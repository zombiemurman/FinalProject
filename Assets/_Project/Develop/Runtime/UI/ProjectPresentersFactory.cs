using Assets._Project.Develop.Runtime.Configs.Meta.Stats;
using Assets._Project.Develop.Runtime.Configs.Meta.Wallet;
using Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Meta.Features.LevelsProgression;
using Assets._Project.Develop.Runtime.Meta.Features.StatsUpgrade;
using Assets._Project.Develop.Runtime.Meta.Features.Wallet;
using Assets._Project.Develop.Runtime.UI.CommonViews;
using Assets._Project.Develop.Runtime.UI.Core;
using Assets._Project.Develop.Runtime.UI.Core.TestPopup;
using Assets._Project.Develop.Runtime.UI.LevelsMenuPopup;
using Assets._Project.Develop.Runtime.UI.StatsUpgradePopup;
using Assets._Project.Develop.Runtime.UI.Wallet;
using Assets._Project.Develop.Runtime.Utilities.ConfigsManagmet;
using Assets._Project.Develop.Runtime.Utilities.CoroutinesManagment;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using Assets._Project.Develop.Runtime.Utilities.SceneManagment;
using Assets.CourseGame.Develop.MainMenu.StatsUpgradeFeature;

namespace Assets._Project.Develop.Runtime.UI
{
    public class ProjectPresentersFactory
    {
        private readonly DIContainer _container;

        public ProjectPresentersFactory(DIContainer container)
        {
            _container = container;
        }

        public StatsUpgradePopupPresenter CreateStatsUpgradePopupPresenter(StatsUpgradePopupView view)
        {
            return new StatsUpgradePopupPresenter(
                _container.Resolve<ICoroutinesPerformer>(),
                view,
                _container.Resolve<ProjectPresentersFactory>(),
                _container.Resolve<StatsUpgradeService>(),
                _container.Resolve<ViewsFactory>());
        }

        public UpgradableStatPresenter CreateUpgradableStatPresenter(UpgradableStatView view, StatTypes statTypes)
        {
            return new UpgradableStatPresenter(
                view,
                statTypes,
                _container.Resolve<ConfigsProviderService>().GetConfig<StatsViewConfig>(),
                _container.Resolve<StatsUpgradeService>(),
                _container.Resolve<WalletService>(),
                _container.Resolve<ConfigsProviderService>().GetConfig<CurrencyIconsConfig>());
        }

        public CurrencyPresenter CreateCurrencyPresenter(
            IconTextView view,
            IReadOnlyVariable<int> currency,
            CurrencyTypes currencyType)
        {
            return new CurrencyPresenter(
                currency, 
                currencyType, 
                _container.Resolve<ConfigsProviderService>().GetConfig<CurrencyIconsConfig>(),
                view);
        }

        public WalletPresenter CreateWalletPresenter(IconTextListView iconTextListView)
        {
            return new WalletPresenter(
                _container.Resolve<WalletService>(),
                this,
                _container.Resolve<ViewsFactory>(),
                iconTextListView);
        }

        public TestPopupPresenter CreateTestPopupPresenter(TestPopupView view) 
        {
            return new TestPopupPresenter(view, _container.Resolve<ICoroutinesPerformer>());
        }

        public LevelTilePresenter CreateLevelTilePresenter(LevelTileView view, int levelNumber)
        {
            return new LevelTilePresenter(
                _container.Resolve<LevelsProgressionService>(),
                _container.Resolve<SceneSwitcherService>(),
                _container.Resolve<ICoroutinesPerformer>(),
                levelNumber,
                view);
        }

        public LevelsMenuPopupPresenter CreateLevelsMenuPopupPresenter(LevelsMenuPopupView view)
        {
            return new LevelsMenuPopupPresenter(
                _container.Resolve<ICoroutinesPerformer>(),
                _container.Resolve<ConfigsProviderService>(),
                this,
                _container.Resolve<ViewsFactory>(),
                view);
        }

        public CharacterPreviewPresenter CreateCharacterPreviewPresenter()
        {
            return new CharacterPreviewPresenter(
                _container.Resolve<SceneLoaderService>(),
                _container.Resolve<ICoroutinesPerformer>());
        }
    }
}
