using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour {
    private GameObject scoreText;

    private int add;
    int i=0;

    // Use this for initialization
    void Start() {
        if (tag == "SmallStarTag")
        {
            add = 10;
        }
        else if (tag == "LargeStarTag")
        {
            add =20;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            add = 30;
        }

        this.scoreText = GameObject.Find("ScoreText");
        
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log(score);
        
        
    }

    void OnCollisionEnter(Collision other)
    {
        this.scoreText.GetComponent<TotalScore>().Addscore(add);
        //Debug.Log(score);

    }
    
}
