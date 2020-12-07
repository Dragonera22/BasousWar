using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameConstants
{
    public static int GetBuildingID(BuildingType building)
    {
        int id;
        switch(building)
        {
            case BuildingType.Castle:
                id = 0;
                break;

            case BuildingType.Barracks:
                id = 1;
                break;

            case BuildingType.Factory:
                id = 2;
                break;

            case BuildingType.Hospital:
                id = 3;
                break;

            case BuildingType.Warehouse:
                id = 4;
                break;

            default:
                id = 0;
                break;
        }
        return id;
    }
}
