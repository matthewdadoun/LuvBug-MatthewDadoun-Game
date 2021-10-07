using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeployFish : MonoBehaviour { 

    public GameObject fishPrefab;
    public GameObject gameCanvas;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    int scoreAmount; 
    public TextMeshProUGUI scoreDisplay; 

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(FishWave());
        scoreAmount = 0;
        Screen.SetResolution(1024, 768, false);
    }

    //gets called every second to spawn a fish
    private void spawnFish()
    {
        GameObject a = Instantiate(fishPrefab) as GameObject;
        a.transform.SetParent(gameCanvas.transform);
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }

    //the function which spawns the fish
    IEnumerator FishWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnFish();
        }
    }

}
