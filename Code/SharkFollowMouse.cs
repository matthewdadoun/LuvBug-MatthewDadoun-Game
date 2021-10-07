using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkFollowMouse : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 10f;

    // follows the mouse on the x position
    void Update()
    {
        mousePosition.x = Input.mousePosition.x;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
    }
}
