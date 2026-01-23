using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed; // Biến tốc độ bay [cite: 51]

    void Update()
    {
        // Tạo vị trí mới dựa trên vị trí hiện tại
        var newPosition = transform.position;

        // Tăng tọa độ Y để đạn bay lên trên theo thời gian
        newPosition.y += Time.deltaTime * flySpeed; // [cite: 55]

        // Gán lại vị trí mới cho viên đạn
        transform.position = newPosition; // [cite: 56]
    }
}