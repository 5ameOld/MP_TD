using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    private GameObject UI;
    private Transform Canvas;

    void Start()
    {
        UI = gameObject;
        Canvas = UI.transform.GetChild(0);
    }

    void Update()
    {
        
    }

    public void SetUI(string buildingTag)
    {
        for(int i = 0; i < Canvas.childCount; i++)
        {
            var child = Canvas.GetChild(i);
            if(child.transform.tag == "Panel")
            {
                child.gameObject.SetActive(false);
            }

            if(child.transform.name == buildingTag + "Panel")
            {
                child.gameObject.SetActive(true);
            }
        }
    }

    public void RemoveUI()
    {
        for (int i = 0; i < Canvas.childCount; i++)
        {
            var child = Canvas.GetChild(i);
            if (child.transform.tag == "Panel")
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}

