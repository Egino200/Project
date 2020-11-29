using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalInput;
    public GameObject missile;
    private float spaceInput;
    private float speed = 20.0f;
    private float forwardInput;
    private Rigidbody playerRb;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive == true)
        {
            horizontalInput = Input.GetAxis("Horizontal");

            if (Input.GetKeyDown("space"))
            {
                Instantiate(missile, transform.position, transform.rotation);
            }

            transform.Translate(Vector3.back * Time.deltaTime * speed * horizontalInput);
        }
    }
    
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameManager.gameover();
            
            
        }
    }
    
}
