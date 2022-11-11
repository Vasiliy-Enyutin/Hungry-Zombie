using UnityEngine;

namespace PlayerLogic
{
    public class PlayerInputService : MonoBehaviour, IPlayerInputService
    {
        public Vector3 MoveDirection => new(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
    }
}
