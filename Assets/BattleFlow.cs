using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameWinUI;

    void Start()
    {
        Time.timeScale = 1;
        if (gameOverUI) gameOverUI.SetActive(false);
        if (gameWinUI) gameWinUI.SetActive(false);
    }

    // Bắt buộc phải có chữ public ở trước các hàm dưới đây
    public void CheckWinCondition()
    {
        GameObject enemy = GameObject.FindWithTag("Enemy");
        if (enemy == null) OnGameWin();
    }

    public void OnGameOver()
    {
        if (gameOverUI) gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void OnGameWin()
    {
        if (gameWinUI) gameWinUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}