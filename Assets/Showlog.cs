using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // Start được gọi trước khung hình đầu tiên
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update được gọi mỗi khung hình
    void Update()
    {
        // Dùng để so sánh sự khác biệt giữa Start và Update
        // Debug.Log("Update called! " + Time.frameCount);
    }
}