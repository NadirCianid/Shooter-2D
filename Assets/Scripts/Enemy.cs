using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float lifeTime = 2.5f;
    [SerializeField] private float moovingSpeed = 4f;
    Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
        Destroy(gameObject, lifeTime);
    }

    private void Update() {
        transform.Translate(Vector3.down*moovingSpeed*Time.deltaTime);
        if(transform.position.y <= -player.yBorders-2)
        {
            transform.position = new Vector3(transform.position.x, player.yBorders+3, 0);
        }
    }

}
