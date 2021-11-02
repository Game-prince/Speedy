using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene("Levelclear");
        }
    }
}
