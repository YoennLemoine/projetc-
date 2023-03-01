using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollision : MonoBehaviour
{
    public void WhenTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            PlayerStats.pStats.TakeDamage(25);
            Destroy(gameObject);

        }
    }

    public void WhenTriggerExit(Collider collider)
    {
        Debug.Log("caca");
    }
}
