using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JobSpawner : MonoBehaviour
{
    public GameObject scroll;
    public void start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject job = new GameObject(name="Job");
            job.transform.SetParent(scroll.transform);
            job.transform.Translate(Vector2.up * 2100);
            job.transform.Translate(Vector2.right * 600);
            RectTransform rt = job.GetComponent<RectTransform>();
            job.AddComponent<ContentSizeFitter>();
            job.transform.Translate(Vector2.down * (i*50));
            Image jobImg = job.AddComponent<Image>();
        }
    }

    
}
