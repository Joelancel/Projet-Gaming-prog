using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dir_Snake : MonoBehaviour
{
    Vector2 dir;
    List<Transform> segments = new List<Transform>();
    [SerializeField] Transform segmentPrefab;
    public static int finalScore;
    private int score = 0;
    public Text scoreText; // Ajout d'une référence au composant Text

    void Start()
    {
        Time.timeScale = 0.25f;
        dir = Vector2.right;
        segments.Add(transform);

        // Remarque : La boucle Grow() a été modifiée pour ajouter des segments au lieu d'en créer 10 au même emplacement.
        for (int i = 0; i < 5; i++)
        {
            Grow();
        }
    }

    void Update()
    {
          if (Input.GetKeyDown(KeyCode.UpArrow) && dir.x != 0)
        {
            dir = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && dir.x != 0)
        {
            dir = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && dir.y != 0)
        {
            dir = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && dir.y != 0)
        {
            dir = Vector2.right;
        }
    }

    private void FixedUpdate()
    {
        for (int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].position = segments[i - 1].position;
        }

        float x = Mathf.Round(transform.position.x) + dir.x;
        float y = Mathf.Round(transform.position.y) + dir.y;
        transform.position = new Vector2(x, y);
    }

    private void Grow()
    {
        Transform segment = Instantiate(segmentPrefab);
        segment.position = segments[segments.Count - 1].position;
        segments.Add(segment);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "food")
        {
            Debug.Log("OnTriggerEnter2D called t'a + 5 ");
            Grow();

            // Ajouter 5 au score à chaque fois que le joueur mange une pomme
            score += 5;

            // Mettre à jour le texte du score
            UpdateScoreText();
        }
    } 

    private void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.tag != "food")
    {
        Debug.Log("OnTriggerEnter2D called juste food contacte");
        // Enregistre le score dans PlayerPrefs
        PlayerPrefs.SetInt("FinalScore", score);
        PlayerPrefs.Save();

        // Met à jour la variable finalScore
        finalScore = score;

        // Charge la scène GameOverScene
        SceneManager.LoadScene("Scene_Perdu");
    }
    }

    private void UpdateScoreText()
    {
        Debug.Log("OnTriggerEnter2D called a jour oklm");
        // Met à jour le texte d'affichage du score
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}