using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTrigger : MonoBehaviour
{
      
    // Update is called once per frame
    public void WhenTopTriggerEnter(Collider collider)
    {
        Debug.Log("caca");
        Destroy(gameObject);
    }
    public void WhenTopTriggerExit(Collider collider)
    {
        Debug.Log("non");
        Destroy(this) ;
    }
}
