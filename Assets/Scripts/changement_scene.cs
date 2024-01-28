using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    public string sceneToLoad = "Scene_Perdu";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Playerr"))
        {
            // Collision avec le joueur, changer de scène
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
