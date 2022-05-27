using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Chula", fileName = "New Pocha")]

public class Chulas : ScriptableObject
{
    public string chulaName;
    public string chulaDescription;
    public Sprite chulaSprite;
    public float chulaDamage;
    public float chulaResistance;
}