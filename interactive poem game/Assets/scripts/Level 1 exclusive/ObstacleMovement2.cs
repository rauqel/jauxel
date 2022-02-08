using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleMovement2 : MonoBehaviour
{
    public Rigidbody2D destroyer;

    public float speed = 1.0f;
    public bool isDead;

    bool isRunning;
    float timePassed;

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.left;
        dir = dir.normalized;
        transform.position += dir * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            isDead = true;
            SceneManager.LoadScene("Death Screen");
        }
    }
}
