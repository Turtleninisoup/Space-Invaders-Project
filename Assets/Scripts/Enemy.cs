using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Variables
    Score score;
    public int worth;
    float speed = 1;
    bool moveRight = true;
    double lbounds = -7.5;
    double rbounds = 7.5;
    Vector3 moveDown = new Vector3(0f, -0.5f, 0f);
    public Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Manager").GetComponent<Score>();
    }

    // Update is called once per frame
    private void Update()
    {
        if ((transform.position.x >= rbounds) || (transform.position.x <= lbounds))
        {
            moveRight = !moveRight;
            DownMovement();
            print("Switching directions; now moving " + (moveRight ? "Right" : "Left"));
        }
        Movement(moveRight);
    }

    //Method for shooting enemy
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        score.setScore(score.getScore() + worth);
        Debug.Log("Ouch!");
    }

    //Movement methods
    void Movement(bool right)
    {
        float movementX = right ? speed : -speed;
        transform.Translate(new Vector3(movementX * Time.deltaTime, 0, 0));
    }

    void DownMovement()
    {
        transform.Translate(moveDown);
    }
}
