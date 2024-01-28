using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionAsteroid : MonoBehaviour
{
    void Update()
    {
        if (gameObject.CompareTag("asteroid") && transform.position.y < -30)
        {
            Destroy(gameObject);
        }
    }
} 