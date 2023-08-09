using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject tallBlockPrefab;
    public float speed = 8f;
    private float timerVariance = 1f;
    public float timerVarianceUpperLimit = 2f;
    public float timer = 0f;
    public float spawnRate = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate+timerVariance)
        {
            timer += Time.deltaTime;
        } else
        {
            Instantiate(tallBlockPrefab, gameObject.transform.position, gameObject.transform.rotation);
            timer = 0f;
            speed += 0.8f;
            timerVariance = Random.Range(0, timerVarianceUpperLimit);
        }
    }
}
