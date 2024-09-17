using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Receive_Dame : MonoBehaviour
{

    [Header("---------- Show GameOver ----------")]
    public GameObject SpawnCoints;
    public GameObject SpawnEnemy;
    public GameObject gameOver;

    private Data data;
    private Data_Enemy data_enemy;

    public static float currentHealth_Player;

    private void Start()
    {

        data = GameObject.FindAnyObjectByType<Data>().GetComponent<Data>();       
        data_enemy = GameObject.FindAnyObjectByType<Data_Enemy>().GetComponent<Data_Enemy>();             
        currentHealth_Player = data.maxHealth_Player;
        data_enemy.currentHealth_Enemy = data_enemy.maxHealth_Enemy;        
    }

    public void Player_ReceiveDame(int dame)
    {
        currentHealth_Player -= dame;
        if (currentHealth_Player <= 0)
        {
            Destroy(SpawnCoints);
            Destroy(SpawnEnemy);
            StartCoroutine(ShowGameOver());
        }
    }

    public void Enemy_ReceiveDame(GameObject enemy,int dame)
    {
        data_enemy.currentHealth_Enemy -= dame;
        if (data_enemy.currentHealth_Enemy == 0)
        {
            Courotine_Coint.instance.killEnemy();
            Destroy(enemy);
            data_enemy.currentHealth_Enemy = 3;
        }
    }

    
    IEnumerator ShowGameOver()
    {
        yield return new WaitForSeconds(1f);
        gameOver.SetActive(true);            
    }
}
