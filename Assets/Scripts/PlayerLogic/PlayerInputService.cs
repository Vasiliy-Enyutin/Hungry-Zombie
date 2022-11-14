using UnityEngine;

namespace PlayerLogic
{
    public class PlayerInputService : IPlayerInputService
    {
        private FloatingJoystick _joystick;

        
        public PlayerInputService(FloatingJoystick joystick)
        {
            _joystick = joystick;
        }
        
        
        public Vector3 MoveDirection
        {
            get
            {
                if (SystemInfo.deviceType == DeviceType.Handheld)
                    return new Vector3(_joystick.Horizontal, 0f, _joystick.Vertical);

                return new(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
            }
        }
    }
}
