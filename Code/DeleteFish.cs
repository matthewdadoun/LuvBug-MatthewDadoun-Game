using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteFish : MonoBehaviour
{

    public float swimSpeed = 1.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, swimSpeed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // deletes fish once it hits the bounds of the screen
    void Update()
    {
        if (transform.position.y > screenBounds.y * 1.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
