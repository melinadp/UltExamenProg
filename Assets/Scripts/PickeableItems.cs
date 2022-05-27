using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickeableItems : MonoBehaviour
{
    public Pochas pocha;
    public Chulas chula;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player" && this.gameObject.tag == "Pocha")
        {
            Inventory.Instance.AddPochas(pocha);
            Destroy(gameObject);
        }
        else if(collider.gameObject.tag == "Player" && this.gameObject.tag == "Chula")
        {
            Inventory.Instance.AddChulas(chula);
            Destroy(gameObject);
        }
    }
}
