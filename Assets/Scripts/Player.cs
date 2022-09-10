using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float xBorders;
    [SerializeField] private float yBorders;
    
    [SerializeField] private float moveSpeed = 1;

    Vector3 transition;
    
    void Start()
    {
       transform.position = new Vector3(0, 0, 0); 
    }

    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction*Time.deltaTime*moveSpeed);
        
        
        float xPos = Mathf.Clamp(transform.position.x, -xBorders, xBorders);
        float yPos = Mathf.Clamp(transform.position.y, -yBorders, yBorders);

        transform.position = new Vector3(xPos, yPos, 0);
    }
}
