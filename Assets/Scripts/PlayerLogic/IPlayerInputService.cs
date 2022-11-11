using UnityEngine;

namespace PlayerLogic
{
    public interface IPlayerInputService
    {
        Vector3 MoveDirection { get; }
    }
}
