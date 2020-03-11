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
    double lbounds = -7.7;
    double rbounds = 7.7;
    Vector3 moveDown = new Vector3(0f, -0.5f, 0f);
    public Transform transform;
    public GameObject bullet;
    public Transform shottingOffset;

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
        }
        Movement(moveRight);

    }

    //Method for shooting enemy
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            score.setScore(score.getScore() + worth);
            speed = speed + 0.1f;
        }

        if (col.gameObject.tag == "Shield")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

    public void shootshoot()
    {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Destroy(shot, 3f);
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
