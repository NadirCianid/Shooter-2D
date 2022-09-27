using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float xBorders;
    [SerializeField] public float yBorders;
    
    [SerializeField] private float moveSpeed = 1;

    [SerializeField] private GameObject laserBeam;
    [SerializeField] private Transform laserGun;
    [SerializeField] private float shootingDelay = 0.2f;

    Vector3 transition;
    
    void Start()
    {
       transform.position = new Vector3(0, 0, 0); 
    }

    
    void Update()
    {
       
        TranslatePlayer();
        ClampPosition();
        ShootLaser();
    }

    private void ClampPosition()
    {
        float xPos = Mathf.Clamp(transform.position.x, -xBorders, xBorders);
        float yPos = Mathf.Clamp(transform.position.y, -yBorders, yBorders);

        transform.position = new Vector3(xPos, yPos, 0);
    }

    private void TranslatePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * Time.deltaTime * moveSpeed);
    }
    private bool isFiring = false;
    private void ShootLaser()
    {
        

        if(Input.GetKeyDown(KeyCode.Space) && !isFiring)
        {
            isFiring = true;
            Invoke("Fire", shootingDelay);
        }

    }

    private void Fire()
    {
        Instantiate(laserBeam, laserGun.position, Quaternion.identity);
        isFiring = false;
    }
}
