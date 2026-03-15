using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    [Header("Kéo HealthBarValue vào đây:")]
    public RectTransform mask;

    [Header("Kéo con Enemy gốc vào đây:")]
    public EnemyHealth enemyHealth;

    private float originalWidth;

    void Start()
    {
        if (mask != null) originalWidth = mask.sizeDelta.x;
        UpdateHealthValue();

        // Lắng nghe sự kiện mất máu của con quái này
        if (enemyHealth != null)
        {
            enemyHealth.onHealthChanged += UpdateHealthValue;
        }
    }

    private void UpdateHealthValue()
    {
        if (enemyHealth == null || mask == null) return;

        float healthPercent = enemyHealth.health / enemyHealth.maxHealth;
        healthPercent = Mathf.Clamp01(healthPercent);

        mask.sizeDelta = new Vector2(healthPercent * originalWidth, mask.sizeDelta.y);
    }
}