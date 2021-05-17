using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public Text score;
    public Text highScore;
    public GameObject player;
    public int scoreCapture = 0;
    public int highScoreCapture;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        score.text = scoreCapture.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreCapture > highScoreCapture)
        {
            highScoreCapture = scoreCapture;
            highScore.text = highScoreCapture.ToString();
        }
    }

    void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.tag == "Enemy" && player != null)
        {
            scoreCapture += 1; 
        }

        score.text = scoreCapture.ToString();
    }
}
