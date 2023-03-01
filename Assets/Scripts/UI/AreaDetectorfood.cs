using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDetectorfood : MonoBehaviour
{
    public void WhenTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            PlayerStats.pStats.Eat(25);
            Destroy(gameObject);

        }


    }

    public void WhenTriggerExit(Collider collider)
    {
        Debug.Log("caca");
    }
}
