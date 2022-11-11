using UnityEngine;
using Zenject;

namespace PlayerLogic
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerMovement : MonoBehaviour
    {
        private CharacterController _characterController;
        private PlayerStats _playerStats;

        private IPlayerInputService _playerInputService;
        
        private Vector3 _moveDirection;

        
        [Inject]
        private void Construct(IPlayerInputService playerInputService)
        {
            _playerInputService = playerInputService;
        }
        
        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            _playerStats = GetComponent<PlayerStats>();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            _moveDirection = _playerInputService.MoveDirection;
            if (_moveDirection.magnitude > 1)
            {
                _moveDirection.Normalize();
            }
            _characterController.Move(_moveDirection * _playerStats.MoveSpeed * Time.deltaTime);
            RotatePlayerInMoveDirection();
        }

        private void RotatePlayerInMoveDirection()
        {
            if (_moveDirection != Vector3.zero)
                transform.forward = _moveDirection;
        }
    }
}
