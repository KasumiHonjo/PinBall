using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TotalScore : MonoBehaviour {
    private GameObject scoreText;
    private int score;

	// Use this for initialization
	void Start () {
        this.scoreText = GameObject.Find("ScoreText");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Addscore(int plus) {
        score += plus;
        scoreText.GetComponent<Text>().text = "Score : " + score;
    }
}
