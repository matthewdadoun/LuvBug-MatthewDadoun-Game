using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SharkCollideWithFish : MonoBehaviour
{
    int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
    }

    //when the shark collides with the fish, it deletes the fish and adds 1 point
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit detected");
        Destroy(collision.gameObject);
        score++;
    }


    //updates the score amount on the text
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
