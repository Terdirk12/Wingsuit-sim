using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] public playerMovement movement;
    [SerializeField] public GameObject distanceScore;
    public float score = 1;
    public Text scoreText;
    public float highscore;
    int forwards;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        forwards = PlayerPrefs.GetInt("Forwards");
    }

    // Update is called once per frame
    void Update()
    {
        if (!movement.death)
        {
            dist = Vector3.Distance(distanceScore.transform.position, this.transform.position);
            score = dist;

            scoreText.text = "Your Score: " + ((int)score).ToString();
        }

        highscore = PlayerPrefs.GetFloat("Highscore");
        if (score > highscore)
        {
            PlayerPrefs.SetFloat("Highscore", score);
        }
    }
}
