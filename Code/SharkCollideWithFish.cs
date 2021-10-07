using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SharkCollideWithFish : MonoBehaviour
{
    int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit detected");
        Destroy(collision.gameObject);
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
