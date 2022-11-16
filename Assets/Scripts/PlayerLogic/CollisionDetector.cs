using System;
using UnityEngine;

namespace PlayerLogic
{
    public class CollisionDetector : MonoBehaviour
    {
        public event Action<IDamageable> OnCollisionWithDamageable;
        
        
        private void OnTriggerStay(Collider other)
        {
            if (other.TryGetComponent(out IDamageable damageableObject))
                OnCollisionWithDamageable?.Invoke(damageableObject);
        }

        private void OnTriggerExit(Collider other)
        {
            // stop attack
        }
    }
}
