using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Text valueText;

    public void OnSliderChanged(float value)
    {
        print(value);
        string valuestr = value.ToString();
        if (value <= 0)
        {
            valueText.text = "None";

        }
        else if (value < 10)
        {
            valueText.text = ("$" + valuestr[0] + "" + valuestr[1] + valuestr[2]);
        }
        else if (value >= 100)
        {
            valueText.text = ("$" + valuestr[0] + "" + valuestr[1] + valuestr[2]);
        }
        else valueText.text = ("$" + valuestr[0] + "" + valuestr[1] + valuestr[2] + valuestr[3] + "" + valuestr[4]);
    }
   
}
