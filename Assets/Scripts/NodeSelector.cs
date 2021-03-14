using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeSelector : MonoBehaviour
{
    public static GameObject selectedObject;

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
                selectedObject = null;
                print (selectedObject);
                selected = false;
            }
            else
            {
                rend.sharedMaterial = materialSelected;
                selectedObject = gameObject;
                print (selectedObject);
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
