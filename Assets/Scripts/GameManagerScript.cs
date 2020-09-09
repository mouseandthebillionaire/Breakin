using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public float score;
    public int numBricks;
    public int lives;

    public int totalBricks;
    public static GameManagerScript S;

    void Awake()
    {
        S = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        numBricks = 0;
        lives = 3;
        score = 0;
        DontDestroyOnLoad(this);
    }

    public void AddBrick()
    {
        numBricks++;
        if (numBricks >= totalBricks)
        {
            // You Win
            BrickLayerScript.S.LayBricks(5, 8);

        }
        Debug.Log(numBricks);
    }
    
    public void DecreaseLives()
    {
        lives--;
        if (lives < 0) {
            // Game is Over
            SceneManager.LoadScene("GameOver")
        }
        Debug.Log(lives);
    }

    public void Scorer(float scoreToAdd)
    {
        score += scoreToAdd;
        Debug.Log("Score: " + score);
    }

    public void AddToTotalBricks()
    {
        totalBricks++;
    }
    
    
    
    
    
    
    
    
}
