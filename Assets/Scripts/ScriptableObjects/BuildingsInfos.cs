using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BuildingsInfos : ScriptableObject
{
    public List<BuildingInfo> buildingsInfos;
}

[System.Serializable]
public class BuildingInfo
{
    public string name;
    public int id;
    public int level;
    [TextArea(3, 10)]
    public string upgradeInfo;
}
