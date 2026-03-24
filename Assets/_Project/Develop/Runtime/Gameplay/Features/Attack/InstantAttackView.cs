using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using System;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Gameplay.Features.Attack
{
    [RequireComponent(typeof(Animator))]
    public class InstantAttackView : EntityView
    {
        private readonly int IsAttackKey = Animator.StringToHash("IsAttack");

        [SerializeField] private Animator _animator;

        private IReadOnlyVariable<bool> _inAttackProcess;

        private IDisposable _inAttackProcessChangedDisposable;

        private void OnValidate()
        {
            _animator ??= GetComponent<Animator>();
        }

        protected override void OnEntityStartedWork(Entity entity)
        {
            _inAttackProcess = entity.InAttackProcess;

            _inAttackProcessChangedDisposable = _inAttackProcess.Subscribe(OnAttackProcessChanged);

            UpdateInAttack(_inAttackProcess.Value);
        }

        public override void Cleanup(Entity entity)
        {
            base.Cleanup(entity);

            _inAttackProcessChangedDisposable.Dispose();
        }

        private void UpdateInAttack(bool value) => _animator.SetBool(IsAttackKey, value);

        private void OnAttackProcessChanged(bool arg1, bool inAttack) => UpdateInAttack(inAttack);
    }
}
