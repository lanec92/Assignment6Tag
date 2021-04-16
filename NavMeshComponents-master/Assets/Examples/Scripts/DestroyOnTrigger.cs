using UnityEngine;
using UnityEngine.SceneManagement;

// Destroy owning GameObject if any collider with a specific tag is trespassing
public class DestroyOnTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ogre")
        {
            Destroy(gameObject);
            Lives.lives--;
            SceneManager.LoadScene(0);
        }
    }
}
