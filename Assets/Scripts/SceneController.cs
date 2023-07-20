using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneController : MonoBehaviour
{


    //Manages the moving from scene to scene using buttons

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToHome()
    {
        if (SceneManager.GetActiveScene().name == "Home Screen") return;
        SceneManager.LoadScene("Home Screen");
    }

    public void MoveToMap()
    {
        if (SceneManager.GetActiveScene().name == "FoodMap Screen") return;
        SceneManager.LoadScene("FoodMap Screen");
    }

    public void MoveToJob()
    {
        if (SceneManager.GetActiveScene().name == "Job Screen") return;
        SceneManager.LoadScene("Job Screen");
    }
}
