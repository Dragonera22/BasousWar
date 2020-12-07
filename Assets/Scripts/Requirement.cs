using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[System.Serializable]
public class Requirement
{
    public TaskType taskType;
    public ResourceType resourceType;
    public int amount;
    public BuildingType buildingType;
    public int requiredLevel;
}

public enum TaskType { Gather, Upgrade, Train, Traps}
//gather task is when required to have specific amount of a specific resource
//upgrade task is when required to have a specific building upgraded to a specific level
//train task is when required to have specific number of soldiers of specific level trained from Barracks
//traps task is when required to have specific number of traps built from Factory

public enum ResourceType { Food, Wood, Iron, Crystal}
