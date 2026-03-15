using UnityEngine;
using System; // Bắt buộc phải có dòng này để dùng Action

public class EnemyHealth : MonoBehaviour
{
    public float health = 2f;
    public float maxHealth = 2f; // Đã thêm biến này cho thanh máu

    public Action onHealthChanged; // Đã thêm sự kiện này cho thanh máu

    void Start()
    {
        // Khi vừa sinh ra, quái vật sẽ được bơm đầy máu
        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        // Gọi thanh máu trên đầu quái vật tụt xuống
        onHealthChanged?.Invoke();

        if (health <= 0) Die();
    }

    void Die()
    {
        Destroy(gameObject);

        // Báo cho Trọng tài kiểm tra xem đã chết hết quái chưa để Win
        BattleFlow flow = FindObjectOfType<BattleFlow>();
        if (flow != null)
        {
            flow.Invoke("CheckWinCondition", 0.1f);
        }
    }
}