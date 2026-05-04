using Assets._Project.Develop.Runtime.Configs.Gameplay.Entities;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Systems;
using Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage;
using Assets._Project.Develop.Runtime.Gameplay.Features.Attack;
using Assets._Project.Develop.Runtime.Gameplay.Features.Attack.Shoot;
using Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.ContactTakeDamage;
using Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle;
using Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures;
using Assets._Project.Develop.Runtime.Gameplay.Features.Sensors;
using Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures;
using Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature;
using Assets._Project.Develop.Runtime.Gameplay.Features.TeamsFeature;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using System.Collections.Generic;
using UnityEngine;

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

        public Entity CreateGhostEntity(Vector3 position, GhostConfig ghostConfig)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, ghostConfig.PrefabPath);

            entity
                .AddMoveDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(ghostConfig.MoveSpeed))
                .AddIsMoving()
                .AddRotationDirection()
                .AddRotationSpeed(new ReactiveVariable<float>(ghostConfig.RotationSpeed))
                .AddMaxHealth(new ReactiveVariable<float>(ghostConfig.MaxHealth))
                .AddCurrentHealth(new ReactiveVariable<float>(ghostConfig.MaxHealth))
                .AddIsDead()
                .AddInDeathProcess()
                .AddDeathProcesInitialTime(new ReactiveVariable<float>(ghostConfig.DeathProcessTime))
                .AddDeathProcesCurrentTime()
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddContactsDetectingMask(Layers.CharactersMask)
                .AddContactCollidersBuffer(new Buffer<Collider>(64))
                .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                .AddBodyContacDamage(new ReactiveVariable<float>(ghostConfig.BodyContactDamage))
                .AddSpawnInitialTime(new ReactiveVariable<float>(ghostConfig.SpawnProcessTime))
                .AddSpawnCurrentTime()
                .AddInSpawnProcess();

            ICompositCondition canMove = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value == false))
                .Add(new FuncCondition(() => entity.InSpawnProcess.Value == false));

            ICompositCondition canRotate = new CompositeCondition()
                .Add(new FuncCondition(() => entity.InSpawnProcess.Value == false))
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition mustDie = new CompositeCondition()
                .Add(new FuncCondition(() => entity.CurrentHealth.Value <= 0));

            ICompositCondition mustSelfReleased = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsDead.Value))
                .Add(new FuncCondition(() => entity.InDeathProcess.Value == false));

            ICompositCondition canApplyDamage = new CompositeCondition()
                .Add(new FuncCondition(() => entity.InSpawnProcess.Value == false))
                .Add(new FuncCondition(() => entity.IsDead.Value == false));

            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddMustDie(mustDie)
                .AddMustSelfReleased(mustSelfReleased)
                .AddCanApplyDamage(canApplyDamage);

            entity
                .AddSystem(new SpawnProcessTimerSystem())
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


            return entity;
        }

        public Entity CreateHeroEntity(Vector3 position, HeroConfig heroConfig, Dictionary<StatTypes, float> baseStats)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, heroConfig.PrefabPath);

            Dictionary<StatTypes, float> modifiedStats = new(baseStats);

            entity
                .AddStatsEffects()
                .AddBaseStats(baseStats)
                .AddModifiedStats(modifiedStats)
                .AddMoveDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(baseStats[StatTypes.MoveSpeed]))
                .AddIsMoving()
                .AddRotationDirection()
                .AddRotationSpeed(new ReactiveVariable<float>(heroConfig.RotationSpeed))
                .AddMaxHealth(new ReactiveVariable<float>(baseStats[StatTypes.MaxHealth]))
                .AddCurrentHealth(new ReactiveVariable<float>(baseStats[StatTypes.MaxHealth]))
                .AddIsDead()
                .AddInDeathProcess()
                .AddDeathProcesInitialTime(new ReactiveVariable<float>(heroConfig.DeathProcessTime))
                .AddDeathProcesCurrentTime()
                .AddTakeDamageRequest()
                .AddTakeDamageEvent()
                .AddAttackProcessInitialTime(new ReactiveVariable<float>(heroConfig.AttackProcessTime))
                .AddAttackProcessModifiedTime(new ReactiveVariable<float>(heroConfig.AttackProcessTime))
                .AddAttackProcessCurrentTime()
                .AddInAttackProcess()
                .AddInstanShootingDirection(new InstantShootingDirectionArgs(
                    new InstantShotDirectionArgs(0, 3)))
                .AddStartAttackRequest()
                .AddStartAttackEvent()
                .AddEndAttackEvent()
                .AddAttackDelayTime(new ReactiveVariable<float>(heroConfig.AttackDelayTime))
                .AddAttackDelayModifiedTime(new ReactiveVariable<float>(heroConfig.AttackDelayTime))
                .AddAttackDelayEndEvent()
                .AddInstantAttackDamage(new ReactiveVariable<float>(baseStats[StatTypes.Damage]))
                .AddAttackCancelEvent()
                .AddAttackCooldownInitialTime(new ReactiveVariable<float>(heroConfig.AttackCooldown))
                .AddAttackCooldownModifiedTime(new ReactiveVariable<float>(heroConfig.AttackCooldown))
                .AddAttackCooldownCurentTime()
                .AddInAttackCooldown()
                .AddAttackPerSecond(new ReactiveVariable<float>(baseStats[StatTypes.AttackPerSecond]));

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
                .AddSystem(new StateEffectApplierSystem())
                .AddSystem(new AttackPerSecondStatSynchronizerSystem())
                .AddSystem(new AttackTimeByAttackSpeedStatSyncronizerSystem())
                .AddSystem(new MoveSpeedStatSynchronizerSystem())
                .AddSystem(new DamageStatSynchronizerSystem())
                .AddSystem(new MaxHealthStatSynchronizerSystem())
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new AttackCancelSystem())
                .AddSystem(new StartAttackSystem())
                .AddSystem(new AttackProcessTimerSystem())
                .AddSystem(new AttackDelayEndTriggerSystem())
                .AddSystem(new DirectionsInstantShootSystem(this))
                .AddSystem(new EndAttackSystem())
                .AddSystem(new AttackCooldownTimerSystem())
                .AddSystem(new ApplyDamageSystem())
                .AddSystem(new DeathSystem())
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new DeathProcessTimerSystem())
                .AddSystem(new SelfRealeseSystem(_entitiesLifeContext));

            return entity;
        }

        public Entity CreateProjectile(Vector3 position, Vector3 direction, float damage, Entity owner)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, "Entities/Projectile");

            entity
                .AddIsProjectile()
                .AddOwner(new ReactiveVariable<Entity>(owner))
                .AddMoveDirection(new ReactiveVariable<Vector3>(direction))
                .AddMoveSpeed(new ReactiveVariable<float>(25))
                .AddIsMoving()
                .AddRotationDirection(new ReactiveVariable<Vector3>(direction))
                .AddRotationSpeed(new ReactiveVariable<float>(9999))
                .AddIsDead()
                .AddContactsDetectingMask(Layers.CharactersMask | Layers.EnviromentMask)
                .AddContactCollidersBuffer(new Buffer<Collider>(64))
                .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                .AddBodyContacDamage(new ReactiveVariable<float>(damage))
                .AddDeathMask(Layers.EnviromentMask)
                .AddIsTouchDeatMask()
                .AddIsTouchAnotherTeam()
                .AddTeam(new ReactiveVariable<Teams>(owner.Team.Value));

            ICompositCondition canMove = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition canRotate = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositCondition mustDie = new CompositeCondition()
                            .Add(new FuncCondition(() => entity.IsTouchDeatMask.Value), 0)
                            .Add(new FuncCondition(() => entity.IsTouchAnotherTeam.Value), 10, LogicOperations.Or);

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
                .AddSystem(new AnotherTeamTouchDetectorSystem())
                .AddSystem(new DeathSystem())
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new SelfRealeseSystem(_entitiesLifeContext));

            _entitiesLifeContext.Add(entity);

            return entity;
        }

        public Entity CreateContactTrigger(Vector3 position)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, "Entities/ContactTrigger");

            entity
                .AddContactsDetectingMask(Layers.CharactersMask)
                .AddContactCollidersBuffer(new Buffer<Collider>(64))
                .AddContactEntitiesBuffer(new Buffer<Entity>(64));

            entity
                .AddSystem(new BodyContactsDetectingSystem())
                .AddSystem(new BodyContactsEntitiesFilterSystem(_collidersRegistryService));

            _entitiesLifeContext.Add(entity);

            return entity;
        }

        public Entity CreatePullable(string prefabPath, Vector3 position)
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, prefabPath);

            entity
                .AddIsPullable()
                .AddIsPullingProcess()
                .AddInSpawnProcess(new ReactiveVariable<bool>(true))
                .AddCurrentTarget(new ReactiveVariable<Entity>(null))
                .AddMoveDirection()
                .AddMoveSpeed(new ReactiveVariable<float>(12))
                .AddIsMoving()
                .AddIsCollected();

            ICompositCondition moveCondition = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsPullingProcess.Value))
                .Add(new FuncCondition(() => entity.InSpawnProcess.Value == false));

            ICompositCondition mustSelfRelease = new CompositeCondition()
                .Add(new FuncCondition(() => entity.IsCollected.Value));

            entity
                .AddCanMove(moveCondition)
                .AddMustSelfReleased(mustSelfRelease);

            entity
                .AddSystem(new GenerateMoveDirectionToTargetSystem())
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new CollectedOnNearToTargetSystem())
                .AddSystem(new SelfRealeseSystem(_entitiesLifeContext));

            return entity;
        }

        private Entity CreateEmpty() => new Entity();
    }
}
