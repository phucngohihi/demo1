using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.1f;
    public Vector3 bulletOffset; // Thêm biến này để chỉnh vị trí
    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    void ShootBullet()
    {
        if (bulletPrefab != null)
        {
            // Cộng thêm bulletOffset vào vị trí hiện tại
            Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
        }
    }
}