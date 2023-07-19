using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JobRefer : MonoBehaviour
{
    JobSpawner js;
    private void Start()
    {
        js = FindObjectOfType<JobSpawner>();
    }
    public void SetJob()
    {
        TMP_InputField inputField = GetComponent<TMP_InputField>();
        js.jobtitle = inputField.textComponent.text;
    }
}
