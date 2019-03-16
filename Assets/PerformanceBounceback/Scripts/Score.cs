using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    public Text text;
    private int initialScore = 0;

	// Use this for initialization
	void Start () {
        text.text = "Score: " + gameManager.score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        if (gameManager.score != initialScore)
        {
            initialScore = gameManager.score;
            ScoreChange();
        }
		
	}
    private void ScoreChange()
    {
        text.text = "Score: " + gameManager.score.ToString();
    }
}


