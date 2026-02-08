using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public int damage = 1; // Sát thương của đạn

    void Update()
    {
        // Code bay lên cũ của bạn giữ nguyên ở đây
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject); // Hủy viên đạn sau khi va chạm
    }
}