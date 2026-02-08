using UnityEngine;

public class EnemyHealth : Health
{
    protected override void Die()
    {
        base.Die();
        // Có thể thêm tính năng cộng điểm tại đây
        Debug.Log("Enemy died");
    }
}