using System;
using Animancer;
using UnityEngine;

namespace PlayerLogic
{
    public class PlayerAnimationSwitcher : MonoBehaviour
    {
        [SerializeField] private AnimationClip _idleAnimation;
        [SerializeField] private AnimationClip _moveAnimation;
        [SerializeField] private AnimationClip _attackAnimation;

        private AnimancerComponent _animancer;

        
        private void Awake()
        {
            _animancer = GetComponent<AnimancerComponent>();
        }

        public void PlayIdle(Action? onComplete = null)
        {
            Play(_idleAnimation, onComplete);
        }

        public void PlayMove(Action? onComplete = null)
        {
            Play(_moveAnimation, onComplete);
        }

        public void PlayAttack(Action? onComplete = null)
        {
            Play(_attackAnimation, onComplete);
        }

        private void Play(AnimationClip clip, Action? onComplete)
        {
            AnimancerState state = _animancer.Play(clip);
            state.Events.NormalizedEndTime = clip.length;
            if (onComplete != null) 
                state.Events.OnEnd = onComplete;
        }
    }
}
