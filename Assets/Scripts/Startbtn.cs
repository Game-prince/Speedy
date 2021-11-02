using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbtn : MonoBehaviour
{
    // When user clicks on the start button on welcome screen this function is triggered
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
