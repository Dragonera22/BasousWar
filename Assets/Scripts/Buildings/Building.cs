using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BuildingType { Castle, Barracks, Factory, Hospital, Warehouse}

public class Building : MonoBehaviour
{
    public int buildingLevel;
    public string buildingName;
    public int id;

    private UIManager uiManager;
    private BuildingReferences buildingRefs;
    private BuildingsInfos buildingsInfo;
    private bool isUpgrading;

    public bool isBuilt; //to be protected after testing done
    protected bool IsBuilt { get => isBuilt; set => isBuilt = value; }

    protected void Awake()
    {
        buildingRefs = GetComponent<BuildingReferences>();
        buildingsInfo = buildingRefs.buildingsInfo;
        uiManager = ServiceLocator.GetService<UIManager>();
    }

    protected void Start()
    {
        if (IsBuilt)
        {
            buildingRefs.activebuilding.SetActive(true);
            buildingRefs.nonActivebuilding.SetActive(false);
            buildingRefs.buildingName.text = buildingName+" Level "+buildingLevel;
        }
        else
        {
            buildingRefs.nonActivebuilding.SetActive(true);
            buildingRefs.activebuilding.SetActive(false);
            buildingRefs.buildingName.text = buildingName;
        }
    }

    public virtual void OnClick()
    {
        GameObject buttons;
        if (IsBuilt)
        {
            buttons = buildingRefs.activebuildingButtons;
        }
        else
        {
            buttons = buildingRefs.nonActivebuildingButtons;
        }

        if(!buttons.activeInHierarchy) 
            uiManager.DisableActiveButtons(); //deactivate other open buttons of other buildings

        buttons.SetActive(!buttons.activeInHierarchy);
        uiManager.AddActiveButtons(buttons);
    }

    public virtual void OnBuild()
    {
        IsBuilt = true;
        buildingLevel = 1;
        buildingRefs.activebuilding.SetActive(true);
        buildingRefs.nonActivebuilding.SetActive(false);
        buildingRefs.buildingName.text = buildingName + " Level " + buildingLevel;
    }

    public virtual void OnUpgrade()
    {
        //enable upgrade UI panel && zoom on building
        uiManager.OnUpgradeBuilding();
        ServiceLocator.GetService<UpgradeBuilding>().OnOpen(buildingName, buildingLevel, buildingsInfo.buildingsInfos[id].upgradeInfo);
        //check timer for this level
        //if not zero then turn on Timer
        isUpgrading = true;
        //when timer done
        buildingLevel++;
    }
}
