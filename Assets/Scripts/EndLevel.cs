using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    void OnCollisionEnter(UnityEngine.Collision other) {
        
        if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene("Levelclear");
        }
    }
}
