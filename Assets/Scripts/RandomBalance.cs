using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RandomBalance : MonoBehaviour
{
    //random balance for text
    public TextMeshProUGUI balanceTxt;
    // Start is called before the first frame update
    void Start()
    {
        balanceTxt.text = "$" + Random.Range(0, 100).ToString() + "." + Random.Range(0, 99).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
