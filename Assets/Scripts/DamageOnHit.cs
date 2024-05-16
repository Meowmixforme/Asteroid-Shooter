using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        GameObject hitObject = collision.gameObject;

        if (hitObject.CompareTag("Asteroid") == true)
        {
            GameManager.Instance.PlayerDestroyed();

            Destroy(gameObject);
            Destroy(hitObject);
        }
    }
    
}
