namespace Assets._Project.Develop.Runtime.Gameplay.EntitiesCore
{
	public partial class Entity
	{
		public Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.BaseStats BaseStatsC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.BaseStats>();

		public System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single> BaseStats => BaseStatsC.Value;

		public bool TryGetBaseStats(out System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.BaseStats component);
			if(result)
				value = component.Value;
			else
				value = default(System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBaseStats()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.BaseStats() {Value = new System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBaseStats(System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.BaseStats() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.ModifiedStats ModifiedStatsC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.ModifiedStats>();

		public System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single> ModifiedStats => ModifiedStatsC.Value;

		public bool TryGetModifiedStats(out System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.ModifiedStats component);
			if(result)
				value = component.Value;
			else
				value = default(System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddModifiedStats()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.ModifiedStats() {Value = new System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddModifiedStats(System.Collections.Generic.Dictionary<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatTypes, System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.ModifiedStats() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffects StatsEffectsC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffects>();

		public Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffectsList StatsEffects => StatsEffectsC.Value;

		public bool TryGetStatsEffects(out Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffectsList value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffects component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffectsList);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStatsEffects()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffects() {Value = new Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffectsList() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStatsEffects(Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffectsList value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.StatsEffects() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.AttackPerSecond AttackPerSecondC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.AttackPerSecond>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackPerSecond => AttackPerSecondC.Value;

		public bool TryGetAttackPerSecond(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.AttackPerSecond component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackPerSecond()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.AttackPerSecond() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackPerSecond(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.StatsFeature.AttackPerSecond() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnInitialTime SpawnInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> SpawnInitialTime => SpawnInitialTimeC.Value;

		public bool TryGetSpawnInitialTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddSpawnInitialTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnInitialTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddSpawnInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnInitialTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnCurrentTime SpawnCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> SpawnCurrentTime => SpawnCurrentTimeC.Value;

		public bool TryGetSpawnCurrentTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddSpawnCurrentTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnCurrentTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddSpawnCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.SpawnCurrentTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.InSpawnProcess InSpawnProcessC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.InSpawnProcess>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InSpawnProcess => InSpawnProcessC.Value;

		public bool TryGetInSpawnProcess(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.InSpawnProcess component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInSpawnProcess()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.InSpawnProcess() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInSpawnProcess(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.SpawnFeatures.InSpawnProcess() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveDirection MoveDirectionC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveDirection>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> MoveDirection => MoveDirectionC.Value;

		public bool TryGetMoveDirection(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveDirection component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMoveDirection()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveDirection() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMoveDirection(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveDirection() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveSpeed MoveSpeedC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveSpeed>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> MoveSpeed => MoveSpeedC.Value;

		public bool TryGetMoveSpeed(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveSpeed component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMoveSpeed()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveSpeed() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMoveSpeed(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.MoveSpeed() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.IsMoving IsMovingC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.IsMoving>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsMoving => IsMovingC.Value;

		public bool TryGetIsMoving(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.IsMoving component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsMoving()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.IsMoving() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsMoving(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.IsMoving() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationDirection RotationDirectionC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationDirection>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> RotationDirection => RotationDirectionC.Value;

		public bool TryGetRotationDirection(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationDirection component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRotationDirection()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationDirection() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRotationDirection(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationDirection() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationSpeed RotationSpeedC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationSpeed>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> RotationSpeed => RotationSpeedC.Value;

		public bool TryGetRotationSpeed(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationSpeed component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRotationSpeed()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationSpeed() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRotationSpeed(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.RotationSpeed() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.CanMove CanMoveC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.CanMove>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanMove => CanMoveC.Value;

		public bool TryGetCanMove(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.CanMove component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanMove(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.CanMove() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.CanRotate CanRotateC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.CanRotate>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanRotate => CanRotateC.Value;

		public bool TryGetCanRotate(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.CanRotate component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanRotate(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures.CanRotate() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsPullable IsPullableC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsPullable>();

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsPullable()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsPullable() );
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsPullingProcess IsPullingProcessC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsPullingProcess>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsPullingProcess => IsPullingProcessC.Value;

		public bool TryGetIsPullingProcess(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsPullingProcess component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsPullingProcess()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsPullingProcess() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsPullingProcess(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsPullingProcess() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsCollected IsCollectedC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsCollected>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsCollected => IsCollectedC.Value;

		public bool TryGetIsCollected(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsCollected component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsCollected()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsCollected() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsCollected(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.IsCollected() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.Coins CoinsC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.Coins>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32> Coins => CoinsC.Value;

		public bool TryGetCoins(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.Coins component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCoins()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.Coins() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCoins(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.Coins() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.LootIsDropped LootIsDroppedC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.LootIsDropped>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> LootIsDropped => LootIsDroppedC.Value;

		public bool TryGetLootIsDropped(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.LootIsDropped component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddLootIsDropped()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.LootIsDropped() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddLootIsDropped(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.LootIsDropped() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.CanDropLoot CanDropLootC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.CanDropLoot>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanDropLoot => CanDropLootC.Value;

		public bool TryGetCanDropLoot(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.CanDropLoot component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanDropLoot(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LootFeature.CanDropLoot() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth CurrentHealthC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> CurrentHealth => CurrentHealthC.Value;

		public bool TryGetCurrentHealth(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentHealth()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentHealth(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.CurrentHealth() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth MaxHealthC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> MaxHealth => MaxHealthC.Value;

		public bool TryGetMaxHealth(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMaxHealth()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMaxHealth(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MaxHealth() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead IsDeadC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsDead => IsDeadC.Value;

		public bool TryGetIsDead(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsDead()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsDead(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.IsDead() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MustDie MustDieC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MustDie>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition MustDie => MustDieC.Value;

		public bool TryGetMustDie(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MustDie component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMustDie(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MustDie() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MustSelfReleased MustSelfReleasedC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MustSelfReleased>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition MustSelfReleased => MustSelfReleasedC.Value;

		public bool TryGetMustSelfReleased(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MustSelfReleased component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMustSelfReleased(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.MustSelfReleased() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesInitialTime DeathProcesInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> DeathProcesInitialTime => DeathProcesInitialTimeC.Value;

		public bool TryGetDeathProcesInitialTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathProcesInitialTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesInitialTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathProcesInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesInitialTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesCurrentTime DeathProcesCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> DeathProcesCurrentTime => DeathProcesCurrentTimeC.Value;

		public bool TryGetDeathProcesCurrentTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathProcesCurrentTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesCurrentTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathProcesCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DeathProcesCurrentTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess InDeathProcessC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InDeathProcess => InDeathProcessC.Value;

		public bool TryGetInDeathProcess(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInDeathProcess()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInDeathProcess(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.InDeathProcess() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath DisableCollidersOnDeathC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath>();

		public System.Collections.Generic.List<UnityEngine.Collider> DisableCollidersOnDeath => DisableCollidersOnDeathC.Value;

		public bool TryGetDisableCollidersOnDeath(out System.Collections.Generic.List<UnityEngine.Collider> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath component);
			if(result)
				value = component.Value;
			else
				value = default(System.Collections.Generic.List<UnityEngine.Collider>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDisableCollidersOnDeath()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath() {Value = new System.Collections.Generic.List<UnityEngine.Collider>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDisableCollidersOnDeath(System.Collections.Generic.List<UnityEngine.Collider> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.DisableCollidersOnDeath() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.HealthBarPoint HealthBarPointC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.HealthBarPoint>();

		public UnityEngine.Transform HealthBarPoint => HealthBarPointC.Value;

		public bool TryGetHealthBarPoint(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.HealthBarPoint component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddHealthBarPoint(UnityEngine.Transform value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LifeCycle.HealthBarPoint() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Experience ExperienceC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Experience>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> Experience => ExperienceC.Value;

		public bool TryGetExperience(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Experience component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddExperience()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Experience() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddExperience(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Experience() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Level LevelC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Level>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32> Level => LevelC.Value;

		public bool TryGetLevel(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Level component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddLevel()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Level() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddLevel(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.LevelUPFeature.Level() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContacDamage BodyContacDamageC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContacDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> BodyContacDamage => BodyContacDamageC.Value;

		public bool TryGetBodyContacDamage(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContacDamage component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBodyContacDamage()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContacDamage() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBodyContacDamage(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.ContactTakeDamage.BodyContacDamage() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsMainHero IsMainHeroC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsMainHero>();

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsMainHero()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsMainHero() );
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Components.BodyCollider BodyColliderC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Components.BodyCollider>();

		public UnityEngine.CapsuleCollider BodyCollider => BodyColliderC.Value;

		public bool TryGetBodyCollider(out UnityEngine.CapsuleCollider value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Components.BodyCollider component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.CapsuleCollider);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBodyCollider(UnityEngine.CapsuleCollider value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.BodyCollider() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactsDetectingMask ContactsDetectingMaskC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactsDetectingMask>();

		public UnityEngine.LayerMask ContactsDetectingMask => ContactsDetectingMaskC.Value;

		public bool TryGetContactsDetectingMask(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactsDetectingMask component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddContactsDetectingMask(UnityEngine.LayerMask value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactsDetectingMask() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactCollidersBuffer ContactCollidersBufferC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactCollidersBuffer>();

		public Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> ContactCollidersBuffer => ContactCollidersBufferC.Value;

		public bool TryGetContactCollidersBuffer(out Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactCollidersBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddContactCollidersBuffer(Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactCollidersBuffer() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactEntitiesBuffer ContactEntitiesBufferC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactEntitiesBuffer>();

		public Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity> ContactEntitiesBuffer => ContactEntitiesBufferC.Value;

		public bool TryGetContactEntitiesBuffer(out Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactEntitiesBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddContactEntitiesBuffer(Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.ContactEntitiesBuffer() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Components.DeathMask DeathMaskC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Components.DeathMask>();

		public UnityEngine.LayerMask DeathMask => DeathMaskC.Value;

		public bool TryGetDeathMask(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Components.DeathMask component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddDeathMask(UnityEngine.LayerMask value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.DeathMask() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchDeatMask IsTouchDeatMaskC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchDeatMask>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsTouchDeatMask => IsTouchDeatMaskC.Value;

		public bool TryGetIsTouchDeatMask(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchDeatMask component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsTouchDeatMask()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchDeatMask() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsTouchDeatMask(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchDeatMask() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchAnotherTeam IsTouchAnotherTeamC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchAnotherTeam>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsTouchAnotherTeam => IsTouchAnotherTeamC.Value;

		public bool TryGetIsTouchAnotherTeam(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchAnotherTeam component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsTouchAnotherTeam()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchAnotherTeam() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsTouchAnotherTeam(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.IsTouchAnotherTeam() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Components.Team TeamC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Components.Team>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.Features.TeamsFeature.Teams> Team => TeamC.Value;

		public bool TryGetTeam(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.Features.TeamsFeature.Teams> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Components.Team component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.Features.TeamsFeature.Teams>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTeam()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.Team() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.Features.TeamsFeature.Teams>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTeam(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.Features.TeamsFeature.Teams> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Components.Team() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.LayerToBounceReaction LayerToBounceReactionC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.LayerToBounceReaction>();

		public UnityEngine.LayerMask LayerToBounceReaction => LayerToBounceReactionC.Value;

		public bool TryGetLayerToBounceReaction(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.LayerToBounceReaction component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddLayerToBounceReaction(UnityEngine.LayerMask value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.LayerToBounceReaction() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceEvent BounceEventC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<UnityEngine.RaycastHit> BounceEvent => BounceEventC.Value;

		public bool TryGetBounceEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<UnityEngine.RaycastHit> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<UnityEngine.RaycastHit>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBounceEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<UnityEngine.RaycastHit>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBounceEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<UnityEngine.RaycastHit> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceEvent() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceCount BounceCountC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceCount>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32> BounceCount => BounceCountC.Value;

		public bool TryGetBounceCount(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceCount component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBounceCount()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceCount() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddBounceCount(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Int32> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.BounceFeature.BounceCount() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.IsProjectile IsProjectileC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.IsProjectile>();

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddIsProjectile()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.IsProjectile() );
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest StartAttackRequestC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent StartAttackRequest => StartAttackRequestC.Value;

		public bool TryGetStartAttackRequest(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStartAttackRequest()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStartAttackRequest(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackRequest() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent StartAttackEventC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent StartAttackEvent => StartAttackEventC.Value;

		public bool TryGetStartAttackEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStartAttackEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddStartAttackEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.StartAttackEvent() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.CanStartAttack CanStartAttackC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.CanStartAttack>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanStartAttack => CanStartAttackC.Value;

		public bool TryGetCanStartAttack(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.CanStartAttack component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanStartAttack(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.CanStartAttack() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent EndAttackEventC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent EndAttackEvent => EndAttackEventC.Value;

		public bool TryGetEndAttackEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEndAttackEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddEndAttackEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.EndAttackEvent() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime AttackProcessInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackProcessInitialTime => AttackProcessInitialTimeC.Value;

		public bool TryGetAttackProcessInitialTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessInitialTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessInitialTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessModifiedTime AttackProcessModifiedTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessModifiedTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackProcessModifiedTime => AttackProcessModifiedTimeC.Value;

		public bool TryGetAttackProcessModifiedTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessModifiedTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessModifiedTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessModifiedTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessModifiedTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessModifiedTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime AttackProcessCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackProcessCurrentTime => AttackProcessCurrentTimeC.Value;

		public bool TryGetAttackProcessCurrentTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessCurrentTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackProcessCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackProcessCurrentTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess InAttackProcessC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InAttackProcess => InAttackProcessC.Value;

		public bool TryGetInAttackProcess(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInAttackProcess()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInAttackProcess(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackProcess() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime AttackDelayTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackDelayTime => AttackDelayTimeC.Value;

		public bool TryGetAttackDelayTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayModifiedTime AttackDelayModifiedTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayModifiedTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackDelayModifiedTime => AttackDelayModifiedTimeC.Value;

		public bool TryGetAttackDelayModifiedTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayModifiedTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayModifiedTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayModifiedTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayModifiedTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayModifiedTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent AttackDelayEndEventC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent AttackDelayEndEvent => AttackDelayEndEventC.Value;

		public bool TryGetAttackDelayEndEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayEndEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackDelayEndEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackDelayEndEvent() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage InstantAttackDamageC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> InstantAttackDamage => InstantAttackDamageC.Value;

		public bool TryGetInstantAttackDamage(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInstantAttackDamage()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInstantAttackDamage(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InstantAttackDamage() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.ShootPoint ShootPointC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.ShootPoint>();

		public UnityEngine.Transform ShootPoint => ShootPointC.Value;

		public bool TryGetShootPoint(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.ShootPoint component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddShootPoint(UnityEngine.Transform value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.ShootPoint() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.MustCancelAttack MustCancelAttackC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.MustCancelAttack>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition MustCancelAttack => MustCancelAttackC.Value;

		public bool TryGetMustCancelAttack(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.MustCancelAttack component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddMustCancelAttack(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.MustCancelAttack() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCancelEvent AttackCancelEventC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCancelEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent AttackCancelEvent => AttackCancelEventC.Value;

		public bool TryGetAttackCancelEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCancelEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCancelEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCancelEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCancelEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCancelEvent() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime AttackCooldownInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackCooldownInitialTime => AttackCooldownInitialTimeC.Value;

		public bool TryGetAttackCooldownInitialTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownInitialTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownInitialTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownModifiedTime AttackCooldownModifiedTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownModifiedTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackCooldownModifiedTime => AttackCooldownModifiedTimeC.Value;

		public bool TryGetAttackCooldownModifiedTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownModifiedTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownModifiedTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownModifiedTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownModifiedTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownModifiedTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurentTime AttackCooldownCurentTimeC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackCooldownCurentTime => AttackCooldownCurentTimeC.Value;

		public bool TryGetAttackCooldownCurentTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurentTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownCurentTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurentTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAttackCooldownCurentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.AttackCooldownCurentTime() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown InAttackCooldownC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InAttackCooldown => InAttackCooldownC.Value;

		public bool TryGetInAttackCooldown(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInAttackCooldown()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInAttackCooldown(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InAttackCooldown() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InstanShootingDirection InstanShootingDirectionC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InstanShootingDirection>();

		public Assets._Project.Develop.Runtime.Gameplay.Features.Attack.Shoot.InstantShootingDirectionArgs InstanShootingDirection => InstanShootingDirectionC.Value;

		public bool TryGetInstanShootingDirection(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.Shoot.InstantShootingDirectionArgs value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InstanShootingDirection component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Gameplay.Features.Attack.Shoot.InstantShootingDirectionArgs);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddInstanShootingDirection(Assets._Project.Develop.Runtime.Gameplay.Features.Attack.Shoot.InstantShootingDirectionArgs value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.Attack.InstanShootingDirection() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest TakeDamageRequestC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> TakeDamageRequest => TakeDamageRequestC.Value;

		public bool TryGetTakeDamageRequest(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTakeDamageRequest()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTakeDamageRequest(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageRequest() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent TakeDamageEventC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> TakeDamageEvent => TakeDamageEventC.Value;

		public bool TryGetTakeDamageEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTakeDamageEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTakeDamageEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.TakeDamageEvent() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.CanApplyDamage CanApplyDamageC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.CanApplyDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanApplyDamage => CanApplyDamageC.Value;

		public bool TryGetCanApplyDamage(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.CanApplyDamage component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCanApplyDamage(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.ApplyDamage.CanApplyDamage() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.AI.CurrentTarget CurrentTargetC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.AI.CurrentTarget>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity> CurrentTarget => CurrentTargetC.Value;

		public bool TryGetCurrentTarget(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.AI.CurrentTarget component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentTarget()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.AI.CurrentTarget() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddCurrentTarget(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.AI.CurrentTarget() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilitiesComponent AbilitiesC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilitiesComponent>();

		public Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilityList Abilities => AbilitiesC.Value;

		public bool TryGetAbilities(out Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilityList value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilitiesComponent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilityList);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAbilities()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilitiesComponent() {Value = new Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilityList() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddAbilities(Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilityList value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Features.AbilitiesFeature.AbilitiesComponent() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Common.RigidbodyComponent RigidbodyC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Common.RigidbodyComponent>();

		public UnityEngine.Rigidbody Rigidbody => RigidbodyC.Value;

		public bool TryGetRigidbody(out UnityEngine.Rigidbody value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Common.RigidbodyComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Rigidbody);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddRigidbody(UnityEngine.Rigidbody value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Common.RigidbodyComponent() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Common.TransformComponent TransformC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Common.TransformComponent>();

		public UnityEngine.Transform Transform => TransformC.Value;

		public bool TryGetTransform(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Common.TransformComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddTransform(UnityEngine.Transform value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Common.TransformComponent() {Value = value});
		}

		public Assets._Project.Develop.Runtime.Gameplay.Common.Owner OwnerC => GetComponent<Assets._Project.Develop.Runtime.Gameplay.Common.Owner>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity> Owner => OwnerC.Value;

		public bool TryGetOwner(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.Gameplay.Common.Owner component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity>);
			return result;
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddOwner()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Common.Owner() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity>() });
		}

		public Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity AddOwner(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.Gameplay.EntitiesCore.Entity> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Gameplay.Common.Owner() {Value = value});
		}

	}
}
