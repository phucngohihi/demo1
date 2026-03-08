using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 2f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0) Die();
    }

    void Die()
    {
        // Phải hủy vật thể TRƯỚC khi bảo Trọng tài kiểm tra điều kiện thắng
        Destroy(gameObject);

        // Tìm ông Trọng tài để báo cáo
        BattleFlow flow = Object.FindAnyObjectByType<BattleFlow>();
        if (flow != null)
        {
            // Đợi 0.1s để Unity xóa hẳn vật thể rồi mới đếm số địch còn lại
            flow.Invoke("CheckWinCondition", 0.1f);
        }
    }
}