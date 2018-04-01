using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float WoodRessource { get; set; }
    public float MetalRessource { get; set; }
    public float FoodRessource { get; set; }

    public Text RessourceInfo;

    // Use this for initialization
    void Start () {
        WoodRessource = 500F;
        MetalRessource = 500F;
        FoodRessource = 500F;

        RessourceInfo.text = DisplayRessources();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private string DisplayRessources()
    {
        return "Wood: " + WoodRessource + " Metal: " + MetalRessource + " Food: " + FoodRessource;
    }
}
