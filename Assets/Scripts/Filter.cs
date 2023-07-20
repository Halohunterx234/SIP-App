using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Filter : MonoBehaviour
{
    public bool isDrop;
    public GameObject dropdown;
    
    private void Start()
    {
        if (isDrop)
        {
            TMP_Dropdown dp = dropdown.GetComponent<TMP_Dropdown>();
            print(dp);
            print(dropdown);
            string category = PlayerPrefs.GetString("Category");
            if (category == "" || category == null)
            {
                dp.value = 0;
            }
            else if (category == "Food")
            {
                dp.value = 1;
            }
            else if (category == "Groceries")
            {
                dp.value = 2;
            }
            else if (category == "Basic Necessities")
            {
                dp.value = 3;
            }
            else if (category == "Vouchers")
            {
                dp.value = 4;
            }
        }
        else
        {
            PlayerPrefs.DeleteKey("Category");
        }
    }
    public void SetCategory()
    {
        PlayerPrefs.SetString("Category", this.gameObject.name);
        UnityEngine.SceneManagement.SceneManager.LoadScene("FoodMap Screen");
    }

    
}
