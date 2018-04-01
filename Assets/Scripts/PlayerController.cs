using MP_TD.App.Services;
using MP_TD.Shared.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public decimal WoodRessource { get; set; }
    public decimal MetalRessource { get; set; }
    public decimal FoodRessource { get; set; }

    public Text RessourceInfo;
    public List<Button> UIButtons;

    private BuildingService buildingService;
    private UnitService unitService;

    private List<Building> buildings;
    private List<Unit> units;

    // Use this for initialization
    void Start () {
        buildingService = new BuildingService();
        unitService = new UnitService();

        WoodRessource = 500;
        MetalRessource = 500;
        FoodRessource = 500;

        RessourceInfo.text = DisplayRessources();

        buildings = buildingService.GetBuildable();
        units = unitService.GetAll();
	}
	
	// Update is called once per frame
	void Update () {
        Building building = buildings.Find(x => x.Name == "Mine");
        Button mine = UIButtons.Find(x => x.name == "MineBtn");

        mine.interactable = (building.MetalCosts <= MetalRessource && building.FoodCosts <= FoodRessource && building.WoodCosts <= WoodRessource);

        RessourceInfo.text = DisplayRessources();
	}

    public void CreateBuilding(string name)
    {
        Building building = buildings.Find(x => x.Name == name);
        CalculateRemainingRessources(building);
    }

    private string DisplayRessources()
    {
        return "Wood: " + WoodRessource.ToString("N0") + " Metal: " + MetalRessource.ToString("N0") + " Food: " + FoodRessource.ToString("N0");
    }

    private void CalculateRemainingRessources(BaseRessourceEntity<int> entity)
    {
        WoodRessource -= entity.WoodCosts;
        FoodRessource -= entity.FoodCosts;
        MetalRessource -= entity.MetalCosts;
    }
}
