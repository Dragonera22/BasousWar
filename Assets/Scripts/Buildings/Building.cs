using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int buildingLevel;
    public string buildingName;
    public int id;

    private BuildingReferences buildingRefs;
    private BuildingsInfos buildingsInfo;
    private UIManager uiManager;
    private bool isButtonsOpen;
    private bool isUpgrading;

    public bool isBuilt; //to be protected after testing done
    protected bool IsBuilt { get => isBuilt; set => isBuilt = value; }

    protected void Awake()
    {
        buildingRefs = GetComponent<BuildingReferences>();
        buildingsInfo = buildingRefs.buildingsInfo;
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

    protected virtual void OnClick()
    {
        if (IsBuilt)
            buildingRefs.activebuildingButtons.SetActive(!isButtonsOpen);
        else
            buildingRefs.nonActivebuildingButtons.SetActive(!isButtonsOpen);

        isButtonsOpen = !isButtonsOpen;
    }

    public virtual void OnBuild()
    {
        IsBuilt = true;
        isButtonsOpen = false;
        buildingLevel = 1;
        buildingRefs.activebuilding.SetActive(true);
        buildingRefs.nonActivebuilding.SetActive(false);
        buildingRefs.buildingName.text = buildingName + " Level " + buildingLevel;
    }

    public virtual void OnUpgrade()
    {
        //enable upgrade UI panel && zoom on building
        ServiceLocator.GetService<UIManager>().OnUpgradeBuilding();
        ServiceLocator.GetService<UpgradeBuilding>().OnOpen(buildingName, buildingLevel, buildingsInfo.buildingsInfos[id].upgradeInfo);
        //check timer for this level
        //if not zero then turn on Timer
        isUpgrading = true;
        //when timer done
        buildingLevel++;
    }
}
