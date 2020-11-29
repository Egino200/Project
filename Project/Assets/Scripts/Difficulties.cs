using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class Difficulties : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    private GameManager gameManager;
    public Button restart;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setDifficulty()
    {
        gameManager.StartGame();
    }
}
