using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour {

    public GameObject BarracksPrefab;
    GameObject barracksGO;
    Ray ray;
    RaycastHit hitInfo;
    bool newinstance = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (newinstance == false)
            return;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Terrain.activeTerrain.GetComponent<Collider>().Raycast(ray, out hitInfo, 1000);
        barracksGO.transform.position = hitInfo.point;
        if (Input.GetMouseButtonDown(0))
            newinstance = false;
    }

    public void BtnClick()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Terrain.activeTerrain.GetComponent<Collider>().Raycast(ray, out hitInfo, 1000);
        barracksGO = Instantiate(BarracksPrefab, hitInfo.point, Quaternion.Euler(-90,0,0));
        barracksGO.transform.position = hitInfo.point;
        newinstance = true;
    }
}
