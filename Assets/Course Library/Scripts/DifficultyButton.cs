using System;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameController game;

    public int difficulty;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        game = FindObjectOfType<GameController>();
    }

    private void SetDifficulty()
    {
        game.StartGame(difficulty);
    }
}
