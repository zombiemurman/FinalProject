using Assets._Project.Develop.Runtime.Gameplay.Features.InputFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.PauseFeature;
using Assets._Project.Develop.Runtime.UI.Gameplay;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;


namespace Assets._Project.Develop.Runtime.Gameplay.States
{
    public class DefeatState : EndGameStage, IUpdatableState
    {

        private readonly GameplayPopupService _gameplayPopupService;

        public DefeatState(
            IInputService inputService, IPauseService pauseService, GameplayPopupService gameplayPopupService) : base(inputService, pauseService)
        {
            _gameplayPopupService = gameplayPopupService;
        }

        public override void Enter()
        {
            base.Enter();

            Debug.Log("DEFEAT DEFEAT DEFEAT");

            _gameplayPopupService.OpenDefeatPopup();
        }

        public void Update(float deltaTime)
        {
        }
    }
}
