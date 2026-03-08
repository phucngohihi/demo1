using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Cài đặt chung")]
    public GameObject explosionPrefab; // Kéo thả hiệu ứng nổ vào đây
    public int defaultHealthPoint;     // Máu mặc định thiết lập trên Inspector

    protected int healthPoint;         // Máu hiện tại khi đang chơi

    // Sự kiện báo tử (Thêm ở Part 6)
    public System.Action onDead;

    protected virtual void Start()
    {
        // Gán máu ban đầu bằng máu mặc định
        healthPoint = defaultHealthPoint;
    }

    // Hàm nhận sát thương
    public virtual void TakeDamage(int damage)
    {
        // Nếu đã hết máu từ trước thì bỏ qua (tránh trường hợp bị trừ âm máu hoặc chết 2 lần)
        if (healthPoint <= 0) return;

        // Trừ máu
        healthPoint -= damage;

        // Nếu máu tụt xuống 0 hoặc âm thì gọi hàm chết
        if (healthPoint <= 0)
        {
            Die();
        }
    }

    // Hàm xử lý khi chết
    protected virtual void Die()
    {
        // 1. Tạo hiệu ứng nổ (nếu có gắn Prefab)
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); // Xóa hiệu ứng nổ khỏi màn hình sau 1 giây cho đỡ nặng máy
        }

        // 2. Xóa chính vật thể này (Tàu địch hoặc Tàu người chơi) khỏi game
        Destroy(gameObject);

        // 3. Phát tín hiệu báo tử ra ngoài (Để ông quản lý BattleFlow nghe thấy và hiện Game Over)
        onDead?.Invoke();
    }
}