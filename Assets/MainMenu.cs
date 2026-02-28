using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có thư viện này

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        // Chữ "Battle" dưới đây là tên của màn hình bắn nhau. 
        // Nếu Scene bắn nhau của bạn tên là "SampleScene" thì phải sửa lại chữ ở đây nhé!
        SceneManager.LoadScene("Battle");
    }
}