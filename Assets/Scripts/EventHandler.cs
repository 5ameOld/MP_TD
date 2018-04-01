using MP_TD.App.Services;
using MP_TD.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class EventHandler : MonoBehaviour
{
    public GameObject UI;
    Ray mouseRay;
    RaycastHit hit;
    private BuildingService buildingService;
    private List<Building> buildings;

    void Start()
    {
        buildingService = new BuildingService();
        buildings = buildingService.GetAll();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(mouseRay, out hit))
            {
                UIHandler handler = UI.GetComponent<UIHandler>();
                if(buildings.Select(x => x.Name).Contains(hit.transform.tag))
                {
                    handler.SetUI(hit.transform.tag);
                }
            }
        }
    }
}
