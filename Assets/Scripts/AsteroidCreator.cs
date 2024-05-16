using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class AsteroidCreator : MonoBehaviour
{

    public GameObject asteroidPrefab;

    public Vector3 spawnSize = new Vector3(5, 5, 1);

    public float spawnRate = 5.0f;

    public float minimumScale = 1.0f;
    public float maximumScale = 2.0f;

    public float minimumSpeed = 10.00f;
    public float maximumSpeed = 50.0f;

    IEnumerator CreateAsteroids()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnSize.x / 2.0f, spawnSize.x / 2.0f),
                                                Random.Range(-spawnSize.y / 2.0f, spawnSize.y / 2.0f),
                                                Random.Range(-spawnSize.z / 2.0f, spawnSize.z / 2.0f));

            spawnPosition += transform.position;

            GameObject asteroid = Instantiate(asteroidPrefab, spawnPosition, Random.rotation) as GameObject;

            float scale = Random.Range(minimumScale, maximumScale);
            float speed = Random.Range(minimumSpeed, maximumSpeed);

            asteroid.transform.localScale *= scale;
            asteroid.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, -speed);

            yield return new WaitForSeconds(1.0f / spawnRate);

                
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CreateAsteroids");
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, spawnSize);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
