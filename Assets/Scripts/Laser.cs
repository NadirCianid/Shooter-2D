using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float laserBeamSpeed = 1f;
    [SerializeField] private float lifeTime = 2f;
    private void Start() 
    {
        Destroy(gameObject, lifeTime);
    }
    void Update()
    {
        transform.Translate(Vector3.up*laserBeamSpeed*Time.deltaTime);   
    }
}
