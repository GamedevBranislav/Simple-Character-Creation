using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int currentHead;
    public int currentTops;
    public int currentPants;

    // the  values defined in this constructor will be the default values
    //the game start with these values, no data to load
    public GameData()
    {
        this.currentHead = 0;
        this.currentTops = 0;
        this.currentPants = 0;
    }
}
