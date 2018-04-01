﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClick : MonoBehaviour {
    public List<GameObject> Prefabs;
    GameObject ObjectToAdd;
    Ray ray;
    RaycastHit hitInfo;
    bool newInstance = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (newInstance == false)
            return;
        CastRay();
        ObjectToAdd.transform.position = hitInfo.point;
        if (Input.GetMouseButton(0))
            newInstance = false;
	}

    public void WorkerBtnClicked()
    {
        CreateGameObject("Barracks");
    }

    public void MineBtnClicked()
    {
        CreateGameObject("Mine");
    }

    private void CreateGameObject(string prefAb)
    {
        CastRay();
        var toAdd = Prefabs.Find(x => x.name == prefAb);
        ObjectToAdd = Instantiate(toAdd, hitInfo.point, Quaternion.Euler(-90, 0, 0));
        newInstance = true;
    }

    void CastRay()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Terrain.activeTerrain.GetComponent<Collider>().Raycast(ray, out hitInfo, 1000);
    }
}