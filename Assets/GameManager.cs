using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện để chuyển màn chơi

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel; // Chỗ để gắn cái bảng Game Over vào

    void Start()
    {
        // 1. Khi game bắt đầu, tự động ẩn bảng Game Over đi
        gameOverPanel.SetActive(false);
    }

    public void ShowGameOver()
    {
        // 2. Hàm này được gọi khi Player chết -> Hiện bảng lên
        gameOverPanel.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        // 3. Hàm này cho nút bấm -> Quay về Menu chính (sẽ làm Menu sau)
        // Tạm thời cho nó tải lại màn chơi hiện tại để test nhé
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}