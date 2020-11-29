using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Enemy EnemyScript; 
    public List<GameObject> targets;
    public bool isGameActive;
    public GameObject TitleScreen;
    public TextMeshProUGUI score;
    public Button RestartButton;
    private float spawnRate = .5f;
    private Vector3[] spawnPos = new Vector3[4];
    public GameObject RestartScreen;
    private int scorepoint;
    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
       

        spawnPos[0] = new Vector3(-2.5f, 2, 45);
        spawnPos[1]=new Vector3(2.5f, 2, 45);;
        spawnPos[2]=new Vector3(6.5f, 2, 45);;
        spawnPos[3]=new Vector3(11.5f, 2, 45);;
        RestartButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame()
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
          UpdateScore();
            Instantiate(targets[index],RandomSpawnPos() , targets[index].transform.rotation);
            TitleScreen.gameObject.SetActive(false);
        }
    }

    
    
    private Vector3 RandomSpawnPos()
    {
       int index2 = Random.Range(0, spawnPos.Length);
        return spawnPos[index2];
    }

   public void UpdateScore()
    {
     
        {
            if (timer > 1f)
            {
                scorepoint += 10;
                timer = 0;

            }
            score.text = "Score: " + scorepoint;
        }
    }
    
    public void gameover()
    {
        isGameActive = false;
            RestartScreen.gameObject.SetActive(true);
    }
    
}
