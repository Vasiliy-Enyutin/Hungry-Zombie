using Cinemachine;
using UnityEngine;
using Zenject;

namespace PlayerLogic
{
    [RequireComponent(typeof(CinemachineVirtualCamera))]
    public class CameraTargetSetter : MonoBehaviour
    {
        private CinemachineVirtualCamera _virtualCamera;
        
        private Transform _playerTransform;


        [Inject]
        private void Construct(PlayerMovement playerMovement)
        {
            _playerTransform = playerMovement.transform;
        }
        
        private void Awake()
        {
            _virtualCamera = GetComponent<CinemachineVirtualCamera>();

            _virtualCamera.Follow = _playerTransform;
            _virtualCamera.LookAt = _playerTransform;
        }
    }
}
