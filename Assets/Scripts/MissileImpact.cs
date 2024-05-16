using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileImpact : MonoBehaviour
{

    void OnCollisionEnter (Collision collision)
    {
        GameObject collidenWith = collision.gameObject;

        if (collidenWith.CompareTag("Asteroid"))
        {
            GameManager.Instance.AsteroidDestroyed();

            Destroy (collidenWith);
            Destroy(gameObject);
        }
    }
}
