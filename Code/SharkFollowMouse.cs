using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkFollowMouse : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition.x = Input.mousePosition.x;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
    }
}
