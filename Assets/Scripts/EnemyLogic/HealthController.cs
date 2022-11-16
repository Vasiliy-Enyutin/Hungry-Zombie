using UnityEngine;

namespace EnemyLogic
{
    public class HealthController : MonoBehaviour, IDamageable
    {
        [SerializeField] private float _health;
        
        
        public void TakeDamage(float damage)
        {
            _health -= damage;

            if (_health <= 0)
                Die();
        }

        private void Die()
        {
            // anim ?
            Destroy(gameObject);
        }
    }
}
