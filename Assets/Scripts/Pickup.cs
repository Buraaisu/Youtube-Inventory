using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int itemID;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == GameManager.Instance.PM.gameObject)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                GameManager.Instance.PickupItem(itemID);
                Destroy(gameObject);
            }
        }
    }
}
