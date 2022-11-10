using System;
using UnityEngine;

namespace PlayerLogic
{
    public class AnimationManager : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private Animator _animator;

        private readonly int _moveHash = Animator.StringToHash("Walking");
        private readonly int _idleStateHash = Animator.StringToHash("Idling");

        private Action _currentAnimationEndCallback;

        public void ResetToIdle()
        {
            _animator.Play(_idleStateHash, -1);
        }

        private void Update()
        {
            _animator.SetFloat(_moveHash, _characterController.velocity.magnitude, 0.1f, Time.deltaTime);
        }

        // Triggered from animation
        private void CallbackAnimationEnd()
        {
            _currentAnimationEndCallback?.Invoke();
            _currentAnimationEndCallback = null;
        }
    }
}
