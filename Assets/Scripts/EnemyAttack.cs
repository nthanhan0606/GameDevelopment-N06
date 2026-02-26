using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerHealth>(out var playerHealth))
        {
            playerHealth.TakeDamage(damage);
            health.TakeDamage(1000);
        }
    }
}
