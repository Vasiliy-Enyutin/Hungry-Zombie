using System;
using UnityEngine;

namespace PlayerLogic
{
    public class PlayerAnimationSwitcher : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private Animator _animator;

        private readonly int _moveHash = Animator.StringToHash("Running");

        private Action _currentAnimationEndCallback;

        private void Update()
        {
            _animator.SetFloat(_moveHash, _characterController.velocity.magnitude, 0.1f, Time.deltaTime);
        }
    }
}
