using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public Pochas[] pochas;
    public Text[] pochasNameText;
    public Text[] pochasDescriptionText;
    public Image[] pochasSprites;

    public Chulas[] chulas;
    public Text[] chulasNameText;
    public Text[] chulasDescriptionText;
    public Image[] chulasSprites;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddPochas(Pochas item)
    {
        for(int i = 0; i < pochas.Length; i++)
        {
            if(pochas[i] == null)
            {
                pochas[i] = item;
                pochasNameText[i].text = item.pochaName;
                pochasDescriptionText[i].text = item.pochaDescription;
                pochasSprites[i].sprite = item.pochaSprite;

                return;
            }
        }
    }

    public void AddChulas(Chulas item)
    {
        for(int i = 0; i < chulas.Length; i++)
        {
            if(chulas[i] == null)
            {
                chulas[i] = item;
                chulasNameText[i].text = item.chulaName;
                chulasDescriptionText[i].text = item.chulaDescription;
                chulasSprites[i].sprite = item.chulaSprite;

                return;
            }
        }
    }
}