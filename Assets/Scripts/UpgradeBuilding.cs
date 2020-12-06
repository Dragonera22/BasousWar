using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeBuilding : MonoBehaviour
{
    public TextMeshProUGUI buildingName;
    public TextMeshProUGUI buildingInfo;


    public void OnOpen(string title, int lvl, string info)
    {
        buildingName.text = title+" Level "+lvl;
        buildingInfo.text = info;
    }


}
