using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;

    // Hàm này tự động gom các điểm Waypoint con vào danh sách
    private void Reset() => waypoints = GetComponentsInChildren<Waypoint>();

    // Trả về vị trí của điểm bay theo số thứ tự (Indexer)
    public Vector3 this[int index] => waypoints[index].transform.position;

    // Vẽ đường nối màu xanh lá cây giữa các điểm để dễ nhìn
    private void OnDrawGizmos()
    {
        if (waypoints == null) return;
        Gizmos.color = Color.green;
        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position);
        }
    }
}