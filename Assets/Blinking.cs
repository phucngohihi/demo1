using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Đảo ngược trạng thái enabled của sprite mỗi khung hình
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}