using UnityEngine;
using Utilities;

namespace PlayerLogic
{
    public class PlayerInputReader : Singleton<PlayerInputReader>
    {
        public Vector3 MoveDirection
        {
            get
            {
                return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
            }
        }
    }
}
