using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RDM_spawn : MonoBehaviour
{
    public GameObject smallMeteorPrefab;  // Prefab pour les petites boules
    public GameObject bigMeteorPrefab;    // Prefab pour la grosse boule
    public float smallMeteorFallSpeed = 10f;  // Vitesse de chute des petites boules
    public float bigMeteorFallSpeed = 5f;    // Vitesse de chute de la grosse boule

    void Start()
    {
        InvokeRepeating("RepeatFunction", 0f, 0.7f);
        InvokeRepeating("SpawnBigMeteor", 0f, 4f); // Appeler la fonction SpawnBigMeteor toutes les 5 à 10 secondes
    }

    void RepeatFunction()
    {
        if (smallMeteorPrefab != null)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-30f, 30f), 19f, Random.Range(-0f, 0f));
            GameObject meteorInstance = Instantiate(smallMeteorPrefab, randomSpawnPosition, Quaternion.identity);
            Rigidbody2D meteorRigidbody = meteorInstance.GetComponent<Rigidbody2D>();
            meteorRigidbody.velocity = Vector2.down * smallMeteorFallSpeed;
        }
    }

    void SpawnBigMeteor()
    {
        if (bigMeteorPrefab != null)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-30f, 30f), 19f, Random.Range(-0f, 0f));
            GameObject bigMeteorInstance = Instantiate(bigMeteorPrefab, randomSpawnPosition, Quaternion.identity);
            Rigidbody2D bigMeteorRigidbody = bigMeteorInstance.GetComponent<Rigidbody2D>();
            bigMeteorRigidbody.velocity = Vector2.down * bigMeteorFallSpeed;
        }
    }
}
