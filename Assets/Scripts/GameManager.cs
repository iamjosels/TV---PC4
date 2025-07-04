using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public TextMeshProUGUI scoreText;

    private int score = 0;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();

        if (score < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "Puntaje: " + score;
    }
}
