using FSM;

namespace PlayerLogic.States
{
    public class IdleState : State
    {
        private readonly PlayerAnimationSwitcher _animationSwitcher;
        
        
        public IdleState(PlayerAnimationSwitcher animationSwitcher)
        {
            _animationSwitcher = animationSwitcher;
        }

        public override void OnEnter()
        {
            _animationSwitcher.PlayIdle();
        }

        public override void OnExit()
        {
        }

        public override string Name => "Idle";
    }
}
