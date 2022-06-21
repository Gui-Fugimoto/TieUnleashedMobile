using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDamage : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<PlayerStatics>().CurrentHP -= 1;
            Debug.Log("DeuDano");
        }

    }

    private void OnParticleCollision(GameObject other)
    {
        FindObjectOfType<PlayerStatics>().points += 100;
        Destroy(gameObject, 0.1f);
    }
}
