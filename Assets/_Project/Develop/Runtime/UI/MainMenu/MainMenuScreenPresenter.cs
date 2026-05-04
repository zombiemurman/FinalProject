using Assets._Project.Develop.Runtime.UI.Core;
using Assets._Project.Develop.Runtime.UI.Wallet;
using System;
using System.Collections.Generic;

namespace Assets._Project.Develop.Runtime.UI.MainMenu
{
    public class MainMenuScreenPresenter : IPresenter
    {
        private readonly MainMenuScreenView _mainMenuScreenView;

        private readonly ProjectPresentersFactory _projectPresentersFactory;

        private readonly MainMenuPopupService _popupService;

        private readonly List<IPresenter> _childPresenters = new();

        public MainMenuScreenPresenter(
            MainMenuScreenView mainMenuScreenView,
            ProjectPresentersFactory projectPresentersFactory,
            MainMenuPopupService popupService)
        {
            _mainMenuScreenView = mainMenuScreenView;
            _projectPresentersFactory = projectPresentersFactory;
            _popupService = popupService;
        }

        public void Initialize()
        {
            _mainMenuScreenView.OpenLevelsMenuButtonClicked += OnOpenLevelsMenuButtonClicked;
            _mainMenuScreenView.OpenStatsUpgradeButtonClicked += OnOpenStatsUpgradeButtonClicked;

            CreateWallet();

            foreach(IPresenter presenter in _childPresenters)
                presenter.Initialize();
        }

        public void Dispose()
        {
            _mainMenuScreenView.OpenLevelsMenuButtonClicked -= OnOpenLevelsMenuButtonClicked;
            _mainMenuScreenView.OpenStatsUpgradeButtonClicked -= OnOpenStatsUpgradeButtonClicked;

            foreach (IPresenter presenter in _childPresenters)
                presenter.Dispose();

            _childPresenters.Clear();
        }

        private void CreateWallet()
        {
            WalletPresenter walletPresenter = _projectPresentersFactory.CreateWalletPresenter(_mainMenuScreenView.WalletView);

            _childPresenters.Add(walletPresenter);
        }

        private void OnOpenLevelsMenuButtonClicked()
        {
            _popupService.OpenLevelsMenuPopup();
        }

        private void OnOpenStatsUpgradeButtonClicked()
        {
            _popupService.OpenStatsUpgradePopup();
        }

    }
}
