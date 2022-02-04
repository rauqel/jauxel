using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementL2 : MonoBehaviour
{
    public Rigidbody2D[] destroyer;

    public float speed = 1.0f;

    bool firstWave;
    bool secondWave;
    bool thirdWave;
    float timePassed;

    public TimeManager script;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (script.timePassed < 15)
        {
            Debug.Log("1");
            firstWave = true;
            if (firstWave)
            {
                transform.position += Vector3.down * Time.deltaTime * speed;
            }
        }
        if (script.timePassed >= 15 && script.timePassed < 30)
        {
            Debug.Log("2");
            secondWave = true;
            if (secondWave)
            {
                transform.position += Vector3.right * Time.deltaTime * speed;
                firstWave = false;
                thirdWave = false;
            }
        }
        if (script.timePassed >= 30 && script.timePassed < 45)
        {
            Debug.Log("3");
            thirdWave = true;
            if (thirdWave)
            {
                transform.position += Vector3.left * Time.deltaTime * speed;
                secondWave = false;
            }
        }
        if (script.timePassed >= 45 && script.timePassed < 60)
        {
            Debug.Log("4");
            secondWave = true;
        }
    }
}
