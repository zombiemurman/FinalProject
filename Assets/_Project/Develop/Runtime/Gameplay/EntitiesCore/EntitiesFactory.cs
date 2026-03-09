using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage;
using Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle;
using Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using Assets._Project.Develop.Runtime.Utilities;
using UnityEngine;
using Assets._Project.Develop.Runtime.Gameplay.Features.Sensors;
using Assets._Project.Develop.Runtime.Gameplay.Features.ContactTakeDamage;
using Assets._Project.Develop.Runtime.Gameplay.Features.Attack;
using Assets._Project.Develop.Runtime.Gameplay.Features.Attack.Shoot;

namespace Assets._Project.Develop.Runtime.Gameplay.EntitiesCore
{
    public class EntitiesFactory
    {
        private readonly DIContainer _container;

        private readonly EntitiesLifeContext _entitiesLifeContext;

        private readonly MonoEntitiesFactory _monoEntitiesFactory;

        private readonly CollidersRegistryService _collidersRegistryService;

        public EntitiesFactory(DIContainer container)
        {
            _container = container;
            _entitiesLifeContext = _container.Resolve<EntitiesLifeContext>();
            _monoEntitiesFactory = _container.Resolve<MonoEntitiesFactory>();
            _collidersRegistryService = _container.Resolve<CollidersRegistryService>();
        }

        public Entity CreateGhostEntity(Vector3 position)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, "Entities/Ghost");

            entity
                .AddMoveDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(10))
                .AddIsMoving()
                .AddRotationDirection()
                .AddRotationSpeed(new ReactiveVariable<float>(900))
                .AddMaxHealth(new ReactiveVariable<float>(100))
                .AddCurrentHealth(new ReactiveVariable<float>(100))
                .AddIsDead()
                .AddInDeathProcess()
                .AddDeathProcesInitialTime(new ReactiveVariable<float>(2))
                .AddDeathProcesCurrentTime()
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddContactsDetectingMask(1 << LayerMask.NameToLayer("Characters"))
                .AddContactCollidersBuffer(new Buffer<Collider>(64))
                .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                .AddBodyContacDamage(new ReactiveVariable<float>(50));

            ICompositCondition canMove = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition canRotate = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition mustDie = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.CurrentHealth.Value <= 0));

            ICompositCondition mustSelfReleased = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.IsDead.Value))
                            .Add(new FuncCondition(() => entity.InDeathProcess.Value == false));

            ICompositCondition canApplyDamage = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddMustDie(mustDie)
                .AddMustSelfReleased(mustSelfReleased)
                .AddCanApplyDamage(canApplyDamage);

            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new BodyContactsDetectingSystem())
                .AddSystem(new BodyContactsEntitiesFilterSystem(_collidersRegistryService))
                .AddSystem(new DealDamageOnContactSystem())
                .AddSystem(new ApplyDamageSystem())
                .AddSystem(new DeathSystem())
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new DeathProcessTimerSystem())
                .AddSystem(new SelfRealeseSystem(_entitiesLifeContext));

            _entitiesLifeContext.Add(entity);

            return entity;
        }

        public Entity CreateHeroEntity(Vector3 position)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, "Entities/Hero");

            entity
                .AddMoveDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(10))
                .AddIsMoving()
                .AddRotationDirection()
                .AddRotationSpeed(new ReactiveVariable<float>(900))
                .AddMaxHealth(new ReactiveVariable<float>(100))
                .AddCurrentHealth(new ReactiveVariable<float>(100))
                .AddIsDead()
                .AddInDeathProcess()
                .AddDeathProcesInitialTime(new ReactiveVariable<float>(2))
                .AddDeathProcesCurrentTime()
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddAttackProcessInitialTime(new ReactiveVariable<float>(3))
                .AddAttackProcessCurrentTime()
                .AddInAttackProcess()
                .AddStartAttackRequest()
                .AddStartAttackEvent()
                .AddEndAttackEvent()
                .AddAttackDelayTime(new ReactiveVariable<float>(1))
                .AddAttackDelayEndEvent()
                .AddInstantAttackDamage(new ReactiveVariable<float>(50))
                .AddAttackCancelEvent()
                .AddAttackCooldownInitialTime(new ReactiveVariable<float>(2))
                .AddAttackCooldownCurentTime()
                .AddInAttackCooldown();

            ICompositCondition canMove = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition canRotate = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition mustDie = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.CurrentHealth.Value <= 0));

            ICompositCondition mustSelfReleased = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.IsDead.Value))
                            .Add(new FuncCondition(() => entity.InDeathProcess.Value == false));

            ICompositCondition canApplyDamage = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition canStartAttack = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false))
                .Add(new FuncCondition(() => entity.InAttackCooldown.Value == false))
                .Add(new FuncCondition(() => entity.InAttackProcess.Value == false))
                .Add(new FuncCondition(() => entity.IsMoving.Value == false));

            ICompositCondition mustCancelAttack = new CompositeCondition(LogicOperations.Or)
                .Add(new FuncCondition(() => entity.IsDead.Value))
                .Add(new FuncCondition(() => entity.IsMoving.Value));

            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddMustDie(mustDie)
                .AddMustSelfReleased(mustSelfReleased)
                .AddCanApplyDamage(canApplyDamage)
                .AddCanStartAttack(canStartAttack)
                .AddMustCancelAttack(mustCancelAttack);

            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new AttackCancelSystem())
                .AddSystem(new StartAttackSystem())
                .AddSystem(new AttackProcessTimerSystem())
                .AddSystem(new AttackDelayEndTriggerSystem())
                .AddSystem(new InstantShootSystem(this))
                .AddSystem(new EndAttackSystem())
                .AddSystem(new AttackCooldownTimerSystem())
                .AddSystem(new ApplyDamageSystem())
                .AddSystem(new DeathSystem())
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new DeathProcessTimerSystem())
                .AddSystem(new SelfRealeseSystem(_entitiesLifeContext));

            _entitiesLifeContext.Add(entity);

            return entity;
        }


        public Entity CreateProjectile(Vector3 position, Vector3 direction, float damage)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, "Entities/Projectile");

            entity
                .AddMoveDirection(new ReactiveVariable<Vector3>(direction))
                .AddMoveSpeed(new ReactiveVariable<float>(10))
                .AddIsMoving()
                .AddRotationDirection(new ReactiveVariable<Vector3>(direction))
                .AddRotationSpeed(new ReactiveVariable<float>(9999))
                .AddIsDead()
                .AddContactsDetectingMask(1 << LayerMask.NameToLayer("Characters"))
                .AddContactCollidersBuffer(new Buffer<Collider>(64))
                .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                .AddBodyContacDamage(new ReactiveVariable<float>(damage))
                .AddDeathMask(1 << LayerMask.NameToLayer("Characters"))
                .AddIsTouchDeatMask();

            ICompositCondition canMove = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition canRotate = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition mustDie = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.IsTouchDeatMask.Value));

            ICompositCondition mustSelfReleased = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.IsDead.Value));

            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddMustDie(mustDie)
                .AddMustSelfReleased(mustSelfReleased);

            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new BodyContactsDetectingSystem())
                .AddSystem(new BodyContactsEntitiesFilterSystem(_collidersRegistryService))
                .AddSystem(new DealDamageOnContactSystem())
                .AddSystem(new DeathMaskTouchDetectorSystem())
                .AddSystem(new DeathSystem())
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new SelfRealeseSystem(_entitiesLifeContext));

            _entitiesLifeContext.Add(entity);

            return entity;
        }

        private Entity CreateEmpty() => new Entity();
    }
}
