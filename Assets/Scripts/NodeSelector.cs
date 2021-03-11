using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeSelector : MonoBehaviour
{
    static GameObject[] objects;

    public Material materialStd;

    public Material materialHover;

    public Material materialSelected;

    bool selected;

    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        if (!selected)
        {
            rend.sharedMaterial = materialHover;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (selected)
            {
                rend.sharedMaterial = materialHover;
                selected = false;
            }
            else
            {
                rend.sharedMaterial = materialSelected;
                selected = true;
            }
        }
    }

    private void OnMouseExit()
    {
        if (!selected)
        {
            rend.sharedMaterial = materialStd;
        }
    }
}
