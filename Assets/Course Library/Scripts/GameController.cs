using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public List<GameObject> targets;

    public Button restartButton;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;

    private int score;
    private float spawnRate = 1f;

    void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void UpdateScore(int scoreToUpdate)
    {
        score += scoreToUpdate;
        scoreText.text = $"Score: {score}";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Capacity);

            Instantiate(targets[index]);
        }
    }
}
