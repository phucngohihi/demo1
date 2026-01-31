using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab; // Biến để chứa prefab vụ nổ

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        // 1. Tạo vụ nổ tại vị trí của máy bay trước khi chết
        if (explosionPrefab != null)
        {
            GameObject no = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(no, 1f); // Dọn dẹp vụ nổ sau 1 giây (để đỡ nặng máy)
        }

        // 2. Xóa máy bay
        Destroy(gameObject);
    }
}