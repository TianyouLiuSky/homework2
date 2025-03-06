using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Life playerLife;
    [SerializeField] private Life playerBaseLife;

    void Update()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 && WavesManager.instance.waves.Count <= 0) {
            SceneManager.LoadScene("WinScene");
        } 

        if(playerLife.amount <= 0) {
            SceneManager.LoadScene("LoseScene");
        }
    }
    void Awake()
    {
        playerLife.onDeath.AddListener(OnPlayerDied);
        playerBaseLife.onDeath.AddListener(OnPlayerDied);
    }
    void OnPlayerDied() {
        SceneManager.LoadScene("LoseScreen");
    }
}
