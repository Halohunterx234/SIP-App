using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class JobSpawner : MonoBehaviour
{
    public ScrollRect scroll;
    public GameObject jobPrefab, content;
    public string jobtitle;

    
    public void start()
    {
        if (jobtitle == "") return;
        for (int i = 0; i < 10; i++)
        {
            RectTransform viewportRect = scroll.GetComponent<RectTransform>();
            float viewportWidth = viewportRect.rect.width;
            float viewportHeight = viewportRect.rect.height;
            GameObject job = Instantiate(jobPrefab, scroll.content);
            job.transform.SetParent(content.transform);
            RectTransform rt = job.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(viewportWidth, viewportWidth);
            job.transform.Translate(Vector2.down * ((i+0.5f)*viewportWidth));
            Image jobImg = job.GetComponent<Image>();

            //spawn job title text
            

            GameObject name = new GameObject("name");
            name.transform.SetParent(job.transform);
            name.AddComponent<RectTransform>().transform.position = rt.transform.position;
            TextMeshProUGUI nametmp = name.AddComponent<TextMeshProUGUI>();
            nametmp.text = jobtitle;
            nametmp.color = Color.black;
            nametmp.enableAutoSizing = true;
            nametmp.fontSizeMax = 100;
            nametmp.fontSizeMin = 60;
            nametmp.alignment = TextAlignmentOptions.TopLeft;
            nametmp.enableWordWrapping = false;
            RectTransform textRect = name.GetComponent<RectTransform>();
            textRect.anchorMin = new Vector2(0, 1); // X=0 (left), Y=1 (top)
            textRect.anchorMax = new Vector2(0, 1);
            textRect.pivot = new Vector2(0, 1);
            float paddingX = 10f;
            float paddingY = -30f; // Use negative value to move upward
            textRect.anchoredPosition = new Vector2(paddingX, paddingY);

            //spawn pay title text
            GameObject pay = new GameObject("pay");
            pay.transform.SetParent(job.transform);
            pay.AddComponent<RectTransform>().transform.position = rt.transform.position;
            TextMeshProUGUI paytmp = pay.AddComponent<TextMeshProUGUI>();
            paytmp.text = "$"+Random.Range(7, 12).ToString()+"/hr";
            paytmp.color = Color.blue;
            paytmp.enableAutoSizing = true;
            paytmp.fontSizeMax = 100;
            paytmp.fontSizeMin = 60;
            paytmp.alignment = TextAlignmentOptions.TopRight;
            paytmp.enableWordWrapping = true;
            RectTransform payRect = pay.GetComponent<RectTransform>();
            payRect.anchorMin = new Vector2(1, 1); // X=0 (left), Y=1 (top)
            payRect.anchorMax = new Vector2(1, 1);
            payRect.pivot = new Vector2(1, 1);
            float PaypaddingX = -50f;
            float PaypaddingY = -30f; // Use negative value to move upward
            payRect.anchoredPosition = new Vector2(PaypaddingX, PaypaddingY);

        }
    }


}
