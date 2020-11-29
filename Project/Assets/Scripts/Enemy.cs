using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody targetRB;
    public GameManager gameManager;
    private float speed = 25.0f;
    void Start()
    {
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
        targetRB = GetComponent<Rigidbody>();
       
    }
    
    void Update()
    {
        if (gameManager.isGameActive)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
