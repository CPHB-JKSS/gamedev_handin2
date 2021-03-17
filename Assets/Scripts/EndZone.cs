using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    public GameObject endZone;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == endZone.name)
        {
            Destroy(this.gameObject);
            Debug.Log(this.gameObject.name + " entered the endzone...");
        }
    }

}
