using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Pocha", fileName = "New Pocha")]

public class Pochas : ScriptableObject
{
    public string pochaName;
    public string pochaDescription;
    public Sprite pochaSprite;
    public float pochaDamage;
    public float pochaResistance;
}