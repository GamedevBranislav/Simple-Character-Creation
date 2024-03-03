using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeColor : MonoBehaviour
{
    public Color[] skinColors;
    public Material skinMat;

    public void ChangeSkinColor(int colorIndex)
    {
        skinMat.color = skinColors[colorIndex];
    }

    
}
