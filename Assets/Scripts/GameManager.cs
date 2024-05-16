using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    private int _score = 0;
    public int score
    { get {
            return _score; } 
        set {
            _score = value; 
            scoreLabel.text = _score.ToString();
        } 
    }

    public GameObject gameOverScreen;

    public Text scoreLabel;

    public GameObject playerPrefab;

    public void PlayerDestroyed()
    {
        gameOverScreen.SetActive(true);
        score = 0;
    }

    public void AsteroidDestroyed()
    {
        score += 200;
    }

    public void NewGame()
    {
        gameOverScreen.SetActive(false);
        score = 0;

        Instantiate(playerPrefab);
    }

    // Start is called before the first frame update
    void Start()
    {
        NewGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
