using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject buildingUpgradePanel;

    private GameObject activeBuildingsButtons;


    public void AddActiveButtons(GameObject buttons)
    {
        activeBuildingsButtons = buttons;
    }

    public void DisableActiveButtons()
    {
        if(activeBuildingsButtons != null)
            activeBuildingsButtons.SetActive(false);
        activeBuildingsButtons = null;
    }

    public void OnUpgradeBuilding()
    {
        buildingUpgradePanel.SetActive(true);
    }


}
