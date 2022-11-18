using FSM;

namespace PlayerLogic.States
{
    public class AttackState : State
    {
        private readonly PlayerAnimationSwitcher _animationSwitcher;
        
        
        public AttackState(PlayerAnimationSwitcher animationSwitcher)
        {
            _animationSwitcher = animationSwitcher;
        }

        public override void OnEnter()
        {
            _animationSwitcher.PlayAttack();
        }

        public override void OnExit()
        {
        }

        public override string Name => "Attack";
    }
}
