using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeModel : MonoBehaviour, IDataPersistence
{
   
    public GameObject[] heads; //all head models
    public GameObject[] tops;
    public GameObject[] pants;
    private int currentHead; //current index which object i want to be visible
    private int currentTops;
    private int currentPants;


    // this is from Idatapersistance needed to be working LOAD/SAVE
    public void LoadData(GameData data)
    {
        this.currentHead = data.currentHead;
        this.currentTops = data.currentTops;
        this.currentPants = data.currentPants;
    }
    public void SaveData(ref GameData data)
    {
        data.currentHead = this.currentHead;
        data.currentTops = this.currentTops;
        data.currentPants = this.currentPants;
    }




    private void Update()
    {
        for (int i = 0; i < heads.Length; i++)
        {
            if(i == currentHead)
            {
                heads[i].SetActive(true);
            } else
            {
                heads[i].SetActive(false);
            }
        }
        for (int i = 0; i < tops.Length; i++)
        {
            if (i == currentTops)
            {
                tops[i].SetActive(true);
            }
            else
            {
                tops[i].SetActive(false);
            }
        }
        for (int i = 0; i < pants.Length; i++)
        {
            if (i == currentPants)
            {
                pants[i].SetActive(true);
            }
            else
            {
                pants[i].SetActive(false);
            }
        }
    }

    public void ChangeHead()
    {
        if(currentHead == heads.Length - 1)
        {
            currentHead = 0;
        }
        else
        {
            currentHead++;
        }
        
    }
    public void ChangeTop()
    {
        if (currentTops == tops.Length - 1)
        {
            currentTops = 0;
        }
        else
        {
            currentTops++;
        }
    }
    public void ChangePants()
    {
        if (currentPants == pants.Length - 1)
        {
            currentPants = 0;
        }
        else
        {
            currentPants++;
        }
    }
}
