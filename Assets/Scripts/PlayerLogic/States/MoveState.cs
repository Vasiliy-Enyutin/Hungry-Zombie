using FSM;

namespace PlayerLogic.States
{
    public class MoveState : State
    {
        private readonly PlayerAnimationSwitcher _animationSwitcher;
        
        
        public MoveState(PlayerAnimationSwitcher animationSwitcher)
        {
            _animationSwitcher = animationSwitcher;
        }

        public override void OnEnter()
        {
            _animationSwitcher.PlayMove();
        }

        public override void OnExit()
        {
        }

        public override string Name => "Move";
    }
}
