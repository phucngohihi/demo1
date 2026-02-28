using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();

        // Tìm ông GameManager và bảo ông ấy hiện bảng Game Over lên
        FindObjectOfType<GameManager>().ShowGameOver();

        Debug.Log("Player died");
    }
}