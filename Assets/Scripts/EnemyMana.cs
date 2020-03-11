using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMana : MonoBehaviour
{
    float bulletTime;
    float bulletTimeLeft;
    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        bulletTimeLeft -= Time.deltaTime;

        if (bulletTimeLeft < 0)
        {
            int anEnemy = Random.Range(0, enemies.Length);
            enemies[anEnemy].GetComponent<Enemy>().shootshoot();
            bulletTime = Random.Range(2, 5);
            bulletTimeLeft = bulletTime;
        }
        
    }
}
