using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this);
    }
}
