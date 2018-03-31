using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MP_TD.Shared.Entities;
using MP_TD.App.Services;
using System.Linq;

public class EventHandler : MonoBehaviour {
    private Ray MouseRay;
    private List<Building> buildings;
    private BuildingService buildingService;
    public GameObject UI;
	// Use this for initialization
	void Start () {
        buildingService = new BuildingService();
        buildings = buildingService.GetAll();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            MouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(MouseRay, out hit))
            {
                UIHandler handler = UI.GetComponent<UIHandler>();
                if(buildings.Select(x => x.Name).Contains(hit.transform.tag))
                {
                    handler.SetUI(hit.transform.tag);
                }
                else
                {
                    handler.RemoveUI();
                }
            }

        }
	}
}
