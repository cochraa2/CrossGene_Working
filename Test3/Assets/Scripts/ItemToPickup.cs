using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToPickup : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
