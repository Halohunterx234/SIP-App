using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Text valueText;

    public void OnSliderChanged(float value)
    {
        string valuestr = value.ToString();
        valueText.text = (valuestr[0]+""+valuestr[1]+"."+valuestr[2]+""+valuestr[3]).ToString();
    }
   
}
