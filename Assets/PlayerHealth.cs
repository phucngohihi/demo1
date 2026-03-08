using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 3f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        // Tìm ông Trọng tài để báo Game Over
        BattleFlow flow = Object.FindAnyObjectByType<BattleFlow>();
        if (flow != null)
        {
            flow.OnGameOver();
        }
    }
}