using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    //Manages the moving from scene to scene using buttons

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToHome()
    {
        SceneManager.LoadScene("Home Screen");
    }

    public void MoveToMap()
    {
        SceneManager.LoadScene("FoodMap Screen");
    }

    public void MoveToJob()
    {
        SceneManager.LoadScene("Job Screen");
    }
}
