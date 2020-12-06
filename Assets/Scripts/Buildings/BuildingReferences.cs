using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildingReferences : MonoBehaviour
{
    public BuildingsInfos buildingsInfo;

    public GameObject nonActivebuilding;
    public GameObject nonActivebuildingButtons;
    public GameObject activebuilding;
    public GameObject activebuildingButtons;
    public TextMeshProUGUI buildingName;
    

    private Building building;

    private void Start()
    {
        building = GetComponent<Building>();
    }
    public void OnBuild()
    {
        building.OnBuild();
    }

    public void OnUpgrade()
    {
        building.OnUpgrade();
    }
}
