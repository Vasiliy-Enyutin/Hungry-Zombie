using UnityEngine;
using Zenject;

namespace PlayerLogic
{
    public class PlayerInputService : MonoBehaviour, IPlayerInputService
    {
        private FloatingJoystick _joystick;


        [Inject]
        private void Construct(FloatingJoystick joystick)
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
