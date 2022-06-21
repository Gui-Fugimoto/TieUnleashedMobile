using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDamage : MonoBehaviour
{

    
    private void OnParticelCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<PlayerStatics>().CurrentHP -= 1;
            Debug.Log("DeuDano");
        }
            
    }
    
}
