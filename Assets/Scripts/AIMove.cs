using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public GameObject waypointParent;

    private Animator anim;

    int current = 0;
    public float speed = 10f;
    float radius = 1;


    void start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Vector3.Distance(waypointParent.transform.GetChild(current).transform.position, transform.position) < radius)
        {
            current++;
            
        }
        transform.position = Vector3.MoveTowards(transform.position, waypointParent.transform.GetChild(current).transform.position, Time.deltaTime * speed);
    }
}
