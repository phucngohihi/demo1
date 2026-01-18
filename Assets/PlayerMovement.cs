using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        // Chuyển đổi vị trí chuột trên màn hình sang tọa độ thế giới (World Point)
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Đặt lại Z = 0 để đảm bảo tàu vẫn ở mặt phẳng 2D nhìn thấy được
        worldPoint.z = 0;

        // Gán vị trí mới cho tàu
        transform.position = worldPoint;
    }
}