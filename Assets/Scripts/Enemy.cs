using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Variables
    Score score;
    public int worth;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Manager").GetComponent<Score>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        score.setScore(score.getScore() + worth);
        Debug.Log("Ouch!");
    }
}
