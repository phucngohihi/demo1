using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{
    public float health = 3f;
    public float maxHealth = 3f;
    public Action onHealthChanged;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        onHealthChanged?.Invoke();

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);

        // Đã sửa dòng lỗi ở đây:
        BattleFlow flow = FindObjectOfType<BattleFlow>();
        if (flow != null)
        {
            flow.OnGameOver();
        }
    }
}