using FSM;
using PlayerLogic.States;
using UnityEngine;

namespace PlayerLogic
{
    [RequireComponent(typeof(PlayerAnimationSwitcher))]
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(CollisionDetector))]
    public class PlayerStateMachine : StateMachine
    {
        private IdleState _idleState;
        private MoveState _moveState;
        private AttackState _attackState;
        
        private PlayerAnimationSwitcher _animationSwitcher;
        private CharacterController _characterController;
        private CollisionDetector _collisionDetector;

        private const float VELOCITY_FOR_MOVE_STATE = 0.1f;

        private void Awake()
        {
            _animationSwitcher = GetComponent<PlayerAnimationSwitcher>();
            _characterController = GetComponent<CharacterController>();
            _collisionDetector = GetComponent<CollisionDetector>();

            ConfigureStates();
			
            AddTransition(_idleState, _moveState, () => _characterController.velocity.magnitude >= VELOCITY_FOR_MOVE_STATE);
            AddTransition(_moveState, _idleState, () => _characterController.velocity.magnitude < VELOCITY_FOR_MOVE_STATE);
            //AddTransition(_moveState, _attackState, _collisionDetector.OnCollisionWithDamageable);
        }

        private void Start()
        {
            SetState(_idleState);
        }

        private void ConfigureStates()
        {
            _idleState = new IdleState(_animationSwitcher);
            _moveState = new MoveState(_animationSwitcher);
            _attackState = new AttackState(_animationSwitcher);
        }
    }
}
