using UnityEngine;

namespace PlayerLogic
{
    [RequireComponent(typeof(CharacterController))]
    public class GravityModifier : MonoBehaviour
    {
        private readonly Vector3 _gravity = Physics.gravity;
        private CharacterController _characterController;


        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            if (_characterController.isGrounded)
                return;
            
            ApplyGravity();
        }

        private void ApplyGravity()
        {
            _characterController.Move(_gravity * Time.deltaTime);
        }
    }
}
