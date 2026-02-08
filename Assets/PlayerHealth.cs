using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();
        // Bạn có thể thêm code hiển thị màn hình Game Over tại đây
        Debug.Log("Player died");
    }
}