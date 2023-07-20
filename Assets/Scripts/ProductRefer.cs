using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProductRefer : MonoBehaviour
{
    public MapController mc;
    public TMP_InputField tmpif;
    private void Start()
    {
        mc = FindObjectOfType<MapController>();
        print(mc);
    }

    public void TransferProduct()
    {
        //TMP_InputField tmpif = GetComponent<TMP_InputField>();
        print(tmpif);
        mc.product = tmpif.textComponent.text;
    }
}
