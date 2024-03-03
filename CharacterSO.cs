using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character Assets")]
public class CharacterSO : ScriptableObject
{
    public Color[] SkinColour;

    public Mesh[] Head;
    public Mesh[] Shirt;
    public Mesh[] Pants;
}
