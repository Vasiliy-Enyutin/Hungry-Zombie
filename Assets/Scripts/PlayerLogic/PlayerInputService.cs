using UnityEngine;

namespace PlayerLogic
{
    public class PlayerInputService : MonoBehaviour, IPlayerInputService
    {
        public Vector3 MoveDirection
        {
            get
            {
                if (SystemInfo.deviceType == DeviceType.Handheld)
                    return new();
                
                return new(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
            }
        }
    }
}
