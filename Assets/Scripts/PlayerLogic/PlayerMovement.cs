using UnityEngine;

namespace PlayerLogic
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerMovement : MonoBehaviour
    {
        private CharacterController _characterController;
        private PlayerStats _playerStats;
        
        private Vector3 _moveDirection;


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
            _moveDirection = PlayerInputReader.Instance.MoveDirection;
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
