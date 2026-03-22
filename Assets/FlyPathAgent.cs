using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;
    public float flySpeed = 2f; // Tốc độ bay

    private int nextIndex = 1;

    void Start()
    {
        // Khi vừa sinh ra, tự động di chuyển đến điểm đầu tiên của đường bay
        if (flyPath != null && flyPath.waypoints.Length > 0)
        {
            transform.position = flyPath[0];
        }
    }

    void Update()
    {
        if (flyPath == null) return;

        // Nếu đã bay đến điểm cuối cùng -> Tự hủy tàu
        if (nextIndex >= flyPath.waypoints.Length)
        {
            Destroy(gameObject);
            return;
        }

        // Nếu chưa đến điểm tiếp theo -> Tiếp tục bay và quay đầu nhìn về điểm đó
        if (transform.position != flyPath[nextIndex])
        {
            FlyToNextWaypoint();
            LookAt(flyPath[nextIndex]);
        }
        else // Đã đến nơi -> Chuyển mục tiêu sang điểm tiếp theo
        {
            nextIndex++;
        }
    }

    private void FlyToNextWaypoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, flyPath[nextIndex], flySpeed * Time.deltaTime);
    }

    private void LookAt(Vector2 destination)
    {
        Vector2 position = transform.position;
        var lookDirection = destination - position;
        if (lookDirection.magnitude < 0.01f) return;

        // Quay đầu tàu hướng về phía mục tiêu
        var angle = Vector2.SignedAngle(Vector3.down, lookDirection);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}