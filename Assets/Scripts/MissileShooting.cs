using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MissileShooting : MonoBehaviour
{

    public GameObject missliePrefab;
    public float timeBetweenShots = 0.25f;

    void ShootMissile()
    {
        Vector3 shootingPoint = transform.position + new Vector3(0, 0, 2);

        Instantiate(missliePrefab, shootingPoint, transform.rotation);
    }

    IEnumerator StartShooting()
    {
        while (true)
        {
            if (Input.GetButton("Fire1") == true)
            {
                ShootMissile();
            }
            yield return new WaitForSeconds(timeBetweenShots);
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartShooting");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
