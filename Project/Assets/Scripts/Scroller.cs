using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    private Vector3 startpos;
    private float repeatWidth;
    private float speed = 20.0f;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        repeatWidth = GameObject.Find("aCTUAL rOAD").transform.position.z/2;
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);

            if (transform.position.z < -21.7)
            {
                transform.position = startpos;
            }
        }
    }
}
