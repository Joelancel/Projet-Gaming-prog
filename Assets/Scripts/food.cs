using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] Collider2D zoneSpawn;
    public string trapTag = "Piege";

    void Start()
    {
        SpawnFood();
    }

    void SpawnFood()
    {
        Bounds bounds = zoneSpawn.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        x = Mathf.Round(x);
        y = Mathf.Round(y);

        Vector2 spawnPosition = new Vector2(x, y);

        // Vérifier si la position générée est à proximité d'un objet avec le tag "piege"
        Collider2D[] colliders = Physics2D.OverlapCircleAll(spawnPosition, 1f);
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag(trapTag))
            {
                // La position générée est à proximité d'un piège, réessayer
                print("t proche poto");
                SpawnFood();
                return;
            }
        }

        // Si la boucle se termine, la position est sûre et la pomme peut être générée
        transform.position = spawnPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    if (collision.gameObject.CompareTag("Playerr"))
        {
        // Ajoutez ici le code à exécuter lorsqu'un autre objet entre en collision avec la pomme
        // Par exemple, vous pouvez détruire la pomme ou incrémenter un score
            SpawnFood(); // Pensez à respawn la pomme après la collision si nécessaire
        }
    }
}