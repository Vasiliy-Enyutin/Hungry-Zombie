using UnityEngine;

namespace PlayerLogic
{
    public class Attacker : MonoBehaviour
    {
        [SerializeField] private float _damage;
        
        private CollisionDetector _collisionDetector;

        private bool _isAttacking = false;


        private void Awake()
        {
            _collisionDetector = GetComponent<CollisionDetector>();
        }

        private void OnEnable()
        {
            _collisionDetector.OnCollisionWithDamageable += TryAttack;
        }

        private void OnDisable()
        {
            _collisionDetector.OnCollisionWithDamageable -= TryAttack;
        }

        private void TryAttack(IDamageable damageableObject)
        {
            if (_isAttacking)
                return;
            
            // anim
            damageableObject.TakeDamage(_damage);
        }
    }
}
