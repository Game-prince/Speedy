using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{
    public int currentlevel;
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
