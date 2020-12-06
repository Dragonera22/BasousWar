using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject buildingUpgradePanel;


    public void OnUpgradeBuilding()
    {
        buildingUpgradePanel.SetActive(true);
    }
}
