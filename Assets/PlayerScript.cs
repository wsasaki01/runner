using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public GameObject footCollider;
    public float jumpPower = 5;
    private bool onGround = true;
    private bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRigidbody.velocity = Vector3.up * jumpPower;
            onGround = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == footCollider)
        {
            onGround = true;
        } else if (collision.gameObject.tag == "Obstacle")
        {
            alive = false;
        }
    }
}
