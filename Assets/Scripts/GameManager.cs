using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> enemies;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public bool isGameActive;
    private float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnRandomEnemies());
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawn random enemies
    IEnumerator SpawnRandomEnemies()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnInterval);
            int enemyIndex = Random.Range(0, enemies.Count);
            Instantiate(enemies[enemyIndex]);
          //  Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
          //  Instantiate(enemiesPrefab[enemyIndex], spawnPos, enemiesPrefab[enemyIndex].transform.rotation);
        }
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
