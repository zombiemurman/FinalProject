using Assets._Project.Develop.Runtime.Gameplay.EntitiesCore;
using Assets._Project.Develop.Runtime.Gameplay.Features.AI;
using Assets._Project.Develop.Runtime.Gameplay.Features.AI.States;
using Assets._Project.Develop.Runtime.Gameplay.Features.MovementFeatures;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Gameplay
{
    public class TestGameplay : MonoBehaviour
    {
        private DIContainer _container;

        private EntitiesFactory _entitiesFactory;
        private BrainsFacttory _brainsFacttory;

        private Entity _entity;
        private Entity _ghost;

        private bool _isRunning;

        public void Initialize(DIContainer container)
        {
            _container = container;

            _entitiesFactory = _container.Resolve<EntitiesFactory>();
            _brainsFacttory = _container.Resolve<BrainsFacttory>();
        }

        public void Run()
        {
            _entity = _entitiesFactory.CreateHeroEntity(Vector3.zero);
            _entity.AddCurrentTarget();
            _brainsFacttory.CreateMainHeroBrain(_entity, new NearestDamageableTargetSelector(_entity));

            
            _ghost = _entitiesFactory.CreateGhostEntity(Vector3.zero + Vector3.forward * 5);

            _isRunning = true;
        }

        public void Update()
        {
            if (_isRunning == false) 
                return;

            //if(Input.GetKeyDown(KeyCode.Space))
            //{
            //    _entity.TakeDamageRequest.Invoke(50);
            //}

            //if (Input.GetKeyDown(KeyCode.R))
            //{
            //    _entity.StartAttackRequest.Invoke();
            //}

            if(Input.GetKeyDown(KeyCode.B))
            {
                _brainsFacttory.CreateGhostBrain(_ghost);
            }

            Debug.Log(_ghost.CurrentHealth.Value);
        }

    }
}
