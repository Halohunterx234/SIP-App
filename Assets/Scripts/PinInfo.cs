using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PinInfo : MonoBehaviour
{
    //info
    public bool isSelected;
    public string namee, price, discount, ratings, distance;
    public TextMeshProUGUI nameTxt, priceTxt, discountTxt, ratingsTxt, distanceTxt;
    private void Start()
    {
        this.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(SetData);
        isSelected = false;
    }
    public void SetData()
    {
        foreach (PinInfo pin in FindObjectsOfType<PinInfo>())
        {
            if (pin.isSelected)
            {
                pin.Reset();
            }
        }
        nameTxt.text = "Name: " + namee;
        priceTxt.text = "Price: $" + price;
        discountTxt.enableAutoSizing = true;
        discountTxt.text = "Discounts/Deals(if any): " + discount;
        ratingsTxt.text = "Rating: " + ratings + "/5";
        distanceTxt.text = "Distance away: " + distance + "m";
        isSelected = true;
        Scale(1);
    }

    public void Reset()
    {   
        if (!isSelected) return;
        isSelected = false;
        Scale(-1);
    }

    public void Scale(int sign)
    {
        float cd, cdmax;
        cdmax = 3; cd = 0;
        while (cd <= cdmax)
        {
            transform.localScale *= 1 +(sign *Time.deltaTime/5);
            cd += Time.deltaTime;
        }
    }
}
