using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifiez si le météore entre en collision avec le joueur
        if (other.CompareTag("Playerr"))
        {
            // Mettez ici le code pour gérer la collision avec le joueur
            // Exemple : SceneManager.LoadScene("NomDeVotreScene");
            SceneManager.LoadScene("Scene_Perdu");
        }
    }
}
