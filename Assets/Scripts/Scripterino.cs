using MP_TD.Shared.Entities;
using MP_TD.Shared.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripterino : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UnitService unitService = new UnitService();

        Unit dog = unitService.GetById(1);
        Debug.Log(dog.Damage);
    }
	
	// Update is called once per frame
	void Update () {
    }
}
