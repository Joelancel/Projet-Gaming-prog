using UnityEngine;
using UnityEngine.UI;

public class GameOverScene : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        // Afficher le score dans le Text
        scoreText.text = "Score: " + PlayerPrefs.GetInt("FinalScore", 0).ToString();
    }
}
