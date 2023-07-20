using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class JobSpawner : MonoBehaviour
{
    public ScrollRect scroll;
    public GameObject jobPrefab, content;
    public string jobtitle;

    public List<string> companynames = new List<string>
    {
        "NexaTech Solutions",

"OmniSoft Innovations",

"Alphabyte Dynamics",

"FusionCore Systems",

"NovoGen Robotics",

"QuantumReach Technologies",

"PixelWave Studios",

"Dreamscape Innovations",

"SynthiFusion Enterprises",

"AstralNet Systems",

"NeoPrime Labs",

"SkyVista Technologies",

"BioGenX Innovations",

"InfiniteLink Solutions",

"LunaShift Industries",

"PulseConnect Ventures",

"TechStream Innovations",

"ElectraForge Technologies",

"OptiCore Robotics",

"Vitality Systems",

"ZestyBites Catering",

"SpiceFusion Kitchen",

"SavoryScape Restaurants",

"HerbGrove Flavors",

"WholesomeGems Delights",

"CocoaCraft Confectionery",

"SweetTempt Brews",

"CrunchKiss Snackery",

"FlavorLoom Cafés",

"MunchSphere Food Truck",

"TerraFresh Supermarkets",

"MegaMart Delights",

"UrbanGreen Grocers",

"ValueVista Markets",

"HarvestHaven Stores",

"PrimePick Produce",

"MegaFoods Emporium",

"CornerCrest Superstores",

"SpringTide Market",

"FamilyFare Bazaar",

"NexGenetix Solutions",

"Cybervault Technologies",

"HyperFlux Labs",

"QuantaSonic Innovations",

"DigiSphere Robotics",

"SynthoFusion Systems",

"NovusGate Ventures",

"MindShift Dynamics",

"PixelBloom Technologies",

"Innovonix Robotics",

"LunaReach Technologies",

"PulseLink Systems",

"VirtuNova Enterprises",

"OptiStream Enterprises",

"QuantumPulse Labs",

"SparkX Dynamics",

"NexisTech Innovations",

"Cybersys Robotics",

"MindCraft Solutions",

"PixelSynth Labs",

"StellarSoft Enterprises",

"GenoFusion Labs",

"Visionary Robotics",

"LunaSphere Dynamics",

"NeoLink Innovations",

"QuantumBloom Robotics",

"OptiKinetic Solutions",

"BlazeStream Labs",

"ZenithByte Technologies",

"LunaLink Enterprises",

"DelishVoyage Catering",

"FusionVine Kitchen",

"PlateScape Restaurants",

"Farm-to-Table Flavors",

"TastyRush Delights",

"SipNSavor Brews",

"CrispJoy Snackery",

"PalatePulse Cafés",

"FoodFusion Food Truck",

"NourishSphere Supermarkets",

"NexaFare Bazaar",

"YumLoom Market",

"DelightfulCorner Stores",

"FlavorVista Emporium",

"FreshPicks Produce",

"UrbanHarvest Grocers",

"WholesomeMart Delights",

"MegaMunch Snackery",

"SavoryTrove Cafés",

"SipNSnack Brews",

"PlentifulPalate Catering",

"TastyTwirl Kitchen",

"DineScape Restaurants",

"JoyfulGrove Flavors",

"MunchyGems Confectionery",

"BrewBloom Drinks",

"FlavorFusion Cafés",

"HappyBites Snackery",

"PantryPerks Supermarkets",

"FreshTide Market",

    };
    public void start()
    {
        if (jobtitle == "") return;
        if (content.GetComponentsInChildren<Transform>().Length != 0)
        {
            foreach (Transform job in content.GetComponentsInChildren<Transform>())
            {
                if (job.gameObject != content) Destroy(job.gameObject);
            }
        }
        for (int i = 0; i < Random.Range(1, 10); i++)
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
            job.AddComponent<Button>();
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

            //spawn companies names
            GameObject company = new GameObject("company");
            company.transform.SetParent(job.transform);
            company.AddComponent<RectTransform>().transform.position = rt.transform.position;
            TextMeshProUGUI companytmp = company.AddComponent<TextMeshProUGUI>();
            
            //make text
            companytmp.text = companynames[Random.Range(0, companynames.Count)];
            companytmp.color = Color.black;
            companytmp.enableAutoSizing = true;
            companytmp.fontSizeMax = 100;
            companytmp.fontSizeMin = 60;
            companytmp.alignment = TextAlignmentOptions.BottomLeft;
            companytmp.enableWordWrapping = false;
            RectTransform companyRect = company.GetComponent<RectTransform>();
            companyRect.anchorMin = new Vector2(0, 0); // X=0 (left), Y=1 (top)
            companyRect.anchorMax = new Vector2(0, 0);
            companyRect.pivot = new Vector2(1, 0);
            float CompanypaddingX = 140f;
            float CompanypaddingY = 10f; // Use negative value to move upward
            companyRect.anchoredPosition = new Vector2(CompanypaddingX, CompanypaddingY);

        }
    }


}
