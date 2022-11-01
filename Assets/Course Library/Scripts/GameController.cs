using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;

    private int score;
    private float spawnRate = 1f;

    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
    }

    private IEnumerator SpawnTarget()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Capacity);

            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToUpdate)
    {
        score += scoreToUpdate;
        scoreText.text = $"Score: {score}";
    }
}
