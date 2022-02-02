using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementL2 : MonoBehaviour
{
    public Rigidbody2D destroyer;

    public BoxCollider2D[] walls;
    public BoxCollider2D obstacle;

    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int selection = Random.Range(0, walls.Length);

        if (collision.gameObject.tag == "player")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "border")
        {
            Physics2D.IgnoreCollision(walls[selection], obstacle);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime * speed;
    }
}
