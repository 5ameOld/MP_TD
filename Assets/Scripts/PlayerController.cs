using MP_TD.App.Services;
using MP_TD.Shared.Entities;
using MP_TD.Shared.Views;
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
    private List<BuildingView> placedBuildings;

    // Use this for initialization
    void Start () {
        buildingService = new BuildingService();
        unitService = new UnitService();
        placedBuildings = new List<BuildingView>();

        WoodRessource = 500;
        MetalRessource = 500;
        FoodRessource = 500;

        RessourceInfo.text = DisplayRessources();

        buildings = buildingService.GetBuildable();
        units = unitService.GetAll();

        InvokeRepeating("AddRessources", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
        SetButtonInteractionable("Mine");
        SetButtonInteractionable("Sawmill");
        SetButtonInteractionable("Mill_Backery");

        RessourceInfo.text = DisplayRessources();
    }

    public void CreateBuilding(string name)
    {
        Building building = buildings.Find(x => x.Name == name);
        if (building.BuildingTypeId == "Production")
        {
            placedBuildings.Add(buildingService.GetViewById(building.Id));
        }
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

    private void AddRessources()
    {
        foreach(var building in placedBuildings)
        {
            if(building.RessourceId == "Metal")
            {
                MetalRessource += building.UnitsPerStep;
            }

            if(building.RessourceId == "Wood")
            {
                WoodRessource += building.UnitsPerStep;
            }

            if(building.RessourceId == "Food")
            {
                FoodRessource += building.UnitsPerStep;
            }
        }
    }

    private void SetButtonInteractionable(string name)
    {
        Building building = buildings.Find(x => x.Name == name);
        Button btn = UIButtons.Find(x => x.name == name + "Btn");
        btn.interactable = (building.MetalCosts <= MetalRessource && building.FoodCosts <= FoodRessource && building.WoodCosts <= WoodRessource);
    }
}
