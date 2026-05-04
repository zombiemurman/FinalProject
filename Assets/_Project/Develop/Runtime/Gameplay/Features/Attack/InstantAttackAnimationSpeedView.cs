using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using System;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Gameplay.Features.Attack
{
    [RequireComponent(typeof(Animator))]
    public class InstantAttackAnimationSpeedView : EntityView
    {
        private readonly int _attackAnimationSpeedMultiplierKey = Animator.StringToHash("AttackAnimationSpeedMultiplier");

        [SerializeField] private AnimationClip _animationClip;
        [SerializeField] private Animator _animator;

        private ReactiveVariable<float> _attackProcessInitialTime;
        private ReactiveVariable<float> _attackProcessModofoedTime;

        private IDisposable _attackProcessTimeChangedDisposable;

        private void OnValidate()
        {
            _animator ??= GetComponent<Animator>();
        }

        protected override void OnEntityStartedWork(Entity entity)
        {
            _attackProcessInitialTime = entity.AttackProcessInitialTime;
            _attackProcessModofoedTime = entity.AttackProcessModifiedTime;

            _attackProcessTimeChangedDisposable = _attackProcessModofoedTime.Subscribe(OnAttackProcessTimeChanged);

            OnAttackProcessTimeChanged(0, _attackProcessModofoedTime.Value);
        }

        private void OnAttackProcessTimeChanged(float arg1, float currenAttackProcessTime)
        {
            _animator.SetFloat(_attackAnimationSpeedMultiplierKey, _attackProcessInitialTime.Value / currenAttackProcessTime);
        }
    }
}
