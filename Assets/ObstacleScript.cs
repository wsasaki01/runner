using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = GameObject.FindGameObjectWithTag("GameController").GetComponent<SpawnerScript>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.left * Time.deltaTime * moveSpeed;

        if (transform.position.x < -10.5f)
        {
            Destroy(gameObject);
        }
    }
}
