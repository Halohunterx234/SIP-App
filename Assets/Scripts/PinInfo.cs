using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PinInfo : MonoBehaviour
{
    //info
    public string namee, price, discount, ratings, distance;
    public TextMeshProUGUI nameTxt, priceTxt, discountTxt, ratingsTxt, distanceTxt;
    private void Start()
    {
        this.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(SetData);
    }
    public void SetData()
    {
        nameTxt.text = "Name: " + namee;
        priceTxt.text = "Price: $" + price;
        discountTxt.enableAutoSizing = true;
        discountTxt.text = "Discounts/Deals(if any): " + discount;
        ratingsTxt.text = "Rating: " + ratings + "/5";
        distanceTxt.text = "Distance away: " + distance + "m";

    }
}
