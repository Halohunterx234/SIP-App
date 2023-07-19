using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MapController : MonoBehaviour
{
    public string product;
    public GameObject pinGO, map, canvas, nameobj, priceobj, discountobj, ratingobj, distanceobj;
    public float width, height;

    public List<string> names = new List<string>
    {
        "NexaTech Shiok Solutions",
    "OmniSoft Shiok Innovations",
    "Alphabyte Gao Gao Dynamics",
    "FusionCore Power Lah Systems",
    "NovoGen Walao Robotics",
    "QuantumReach Sibeh Steady Technologies",
    "PixelWave Shiok Studios",
    "Dreamscape Shiok Innovations",
    "Shiok SynthiFusion Enterprises",
    "AstralNet No Joke Systems",
    "NeoPrime Power Lah Labs",
    "SkyVista Best Lah Technologies",
    "BioGenX Power Shiok Innovations",
    "InfiniteLink Lagi Power Solutions",
    "LunaShift Power Steady Industries",
    "PulseConnect Ho Seh Boh Ventures",
    "TechStream Can Do Innovations",
    "ElectraForge Steady Lah Technologies",
    "Shiok OptiCore Robotics",
    "Vitality Steady One Lah Systems",
    "ZestyBites Shiok Catering",
    "SpiceFusion Power Kitchen",
    "SavoryScape Steady Restaurants",
    "HerbGrove Wah Lau Eh Flavors",
    "WholesomeGems Steady Delights",
    "CocoaCraft Best Lah Confectionery",
    "SweetTempt Gao Gao Brews",
    "CrunchKiss Power Snackery",
    "FlavorLoom Steady Cafés",
    "MunchSphere Power Food Truck",
    "TerraFresh Lagi Power Supermarkets",
    "MegaMart Ho Seh Boh Delights",
    "UrbanGreen Power Grocers",
    "ValueVista Steady Lah Markets",
    "HarvestHaven Power Stores",
    "PrimePick Power Produce",
    "MegaFoods Can Do Emporium",
    "CornerCrest Steady Superstores",
    "SpringTide Power Market",
    "FamilyFare Lagi Power Bazaar",
    "NexGenetix Can Do Solutions",
    "Cybervault Power Lah Technologies",
    "HyperFlux Wah Lau Eh Labs",
    "QuantaSonic Steady Innovations",
    "DigiSphere Shiok Robotics",
    "SynthoFusion Can Do Systems",
    "NovusGate Ho Seh Boh Ventures",
    "MindShift Power Dynamics",
    "PixelBloom Steady Technologies",
    "Innovonix Shiok Robotics",
    "LunaReach Can Do Technologies",
    "PulseLink Power Lah Systems",
    "VirtuNova Wah Lau Eh Enterprises",
    "OptiStream Steady Innovations",
    "QuantumPulse Power Labs",
    "SparkX Shiok Dynamics",
    "NexisTech Best Lah Innovations",
    "Cybersys Steady Robotics",
    "MindCraft Wah Lau Eh Solutions",
    "PixelSynth Can Do Labs",
    "StellarSoft Power Enterprises",
    "GenoFusion Lagi Power Labs",
    "Visionary Shiok Robotics",
    "LunaSphere Ho Seh Boh Dynamics",
    "NeoLink Power Innovations",
    "QuantumBloom Can Do Robotics",
    "OptiKinetic Steady Solutions",
    "BlazeStream Wah Lau Eh Labs",
    "ZenithByte Power Technologies",
    "LunaLink Shiok Enterprises",
    "DelishVoyage Best Lah Catering",
    "FusionVine Steady Kitchen",
    "PlateScape Ho Seh Boh Restaurants",
    "Farm-to-Table Can Do Flavors",
    "TastyRush Shiok Delights",
    "SipNSavor Power Brews",
    "CrispJoy Wah Lau Eh Snackery",
    "PalatePulse Steady Cafés",
    "FoodFusion Can Do Food Truck",
    "NourishSphere Shiok Supermarkets",
    "NexaFare Best Lah Bazaar",
    "YumLoom Power Market",
    "DelightfulCorner Shiok Stores",
    "FlavorVista Can Do Emporium",
    "FreshPicks Power Produce",
    "UrbanHarvest Lagi Power Grocers",
    "WholesomeMart Steady Delights",
    "MegaMunch Shiok Snackery",
    "SavoryTrove Ho Seh Boh Cafés",
    "SipNSnack Power Brews",
    "PlentifulPalate Shiok Catering",
    "TastyTwirl Power Kitchen",
    "DineScape Wah Lau Eh Restaurants",
    "JoyfulGrove Can Do Flavors",
    "MunchyGems Power Confectionery",
    "BrewBloom Lagi Power Drinks",
    "FlavorFusion Steady Cafés",
    "HappyBites Wah Lau Eh Snackery",
    "PantryPerks Power Supermarkets",
    "FreshTide Shiok Market"
    };

  
    List<string> deals = new List<string>
{
    
};

    List<string> discounts = new List<string>
{
    "$10 off on all orders over $50",
    "15% discount for students and educators",
    "Seniors enjoy 20% off every Tuesday",
    "Extra 25% off on clearance items",
    "5% discount for loyal customers",
    "Free shipping on your first order",
    "10% off on all beauty and skincare products",
    "Special military discount - 20% off",
    "Early bird savings - shop between 9 AM to 11 AM and get 10% off",
    "10% discount for first-time app users",
    "Clearance section - enjoy discounts up to 70%",
    "Members-only sale - extra 15% off",
    "20% off on all home decor items",
    "Buy 2, get 1 at 50% off on women's clothing",
    "Weekend sale - 30% off on select electronics",
    "BOGO 30% off on baby products",
    "20% off on your next purchase when you sign up for our newsletter",
    "Save 10% with our loyalty program",
    "Get a $5 gift card when you spend $25 on gift items",
    "20% off on outdoor gear and accessories",
    "10% off for healthcare professionals",
    "Early access sale for VIP members",
    "Buy 3, get 1 free on gaming accessories",
    "10% discount for students with valid ID",
    "Teachers' appreciation week - 15% off on school supplies",
    "20% off on select kitchen appliances",
    "Get $15 off your purchase when you refer a friend",
    "Get a $20 voucher for every $100 spent",
    "10% off for social media followers",
    "Save 15% when you use our mobile app to checkout",
    "20% off on all pet supplies",
    "Buy 2, get 1 free on men's grooming products",
    "Weekend getaway deal - save 25% on travel essentials",
    "5% discount when you buy online and pick up in-store",
    "20% off on select fashion accessories",
    "10% off for first responders",
    "Free gift wrapping on all purchases",
    "Receive a $10 coupon with every curbside pickup order",
    "Get a $25 gift card when you spend $100 on toys",
    "10% off for members on their birthday",
    "Save 15% when you buy 2 or more items from the same category",
    "20% off on fitness and sports equipment",
    "10% discount for veterans",
    "Staycation special - 15% off on home entertainment",
    "Get a $50 gift card when you purchase a new smartphone",
    "10% off for expecting parents",
    "Early Black Friday sale - enjoy discounts ahead of time",
    "25% off on all office supplies",
    "Buy 1, get the second item at 40% off",
    "50% off on all products",
    "BOGO - Buy one, get one free",
    "Free shipping on orders over $30",
    "Mystery deal - up to 60% off",
    "2-for-1 deal on selected items",
    "Spend $50 and get a $10 gift card",
    "15% off on all food items",
    "Limited-time flash sale - extra 25% off",
    "Free gift with every purchase",
    "Combo deal - sandwich, fries, and drink for $5",
    "Clearance sale - up to 70% off",
    "Special student discount - 20% off",
    "BOGO 50% off on clothing",
    "Buy 3, get 2 free on beauty products",
    "Family bundle deal - save 30%",
    "Mystery box - value worth $100, yours for $50",
    "Daily deal - lowest prices on random items",
    "Happy Hour - 2-for-1 drinks",
    "Weekly special - exclusive deals on random products",
    "Buy 2, get 1 at 25% off",
    "Free dessert with any main course",
    "Limited stock sale - save big on various items",
    "Lunch combo deal - sandwich, drink, and chips for $8",
    "Early bird special - 15% off your morning order",
    "B2G1 - Buy 2, get 1 free on toys",
    "20% off on home and garden products",
    "Clearance bonanza - up to 80% off",
    "Savings galore - extra 10% off on already discounted items",
    "3-for-2 deal on stationery",
    "Buy any 2 books, get the 3rd for $1",
    "App-exclusive offer - 25% off your first purchase",
    "Discount on your total order - spend more, save more!",
    "Early access sale for members only",
    "VIP special - personalized discounts based on your preferences",
    "Free accessory with every electronic purchase",
    "Limited-time offer - 30% off sitewide",
    "Exclusive in-store offer - show this coupon for extra savings",
    "BOGO 25% off on shoes",
    "Happy meal - kids eat free on Sundays",
    "Membership perks - instant 10% off on all products",
    "Flash sale - hurry, limited time only",
    "Clearance fiesta - everything must go",
    "One-day surprise - check back tomorrow for a new deal",
    "Weekly reward - spend $100 this week and get $20 off next week",
    "Spin the wheel - win a random discount from 5% to 50%",
    "Mega giveaway - every 100th customer wins a special prize",
    "Refer a friend - both get 20% off your next purchase",
    "Double rewards - earn double points on all purchases today",
};


    private void Start()
    {
        RectTransform rt = map.GetComponent<RectTransform>();
        width = rt.rect.width;
        height = rt.rect.height;
    }
    public void spawnPin()
    {
        int ran = UnityEngine.Random.Range(1, 5);
        for (int i = 0; i < ran; i++)
        {
            //make random coordinates
            GameObject pin = Instantiate(pinGO);
            pin.transform.SetParent(canvas.transform);
            RectTransform pinRT = pin.GetComponent<RectTransform>();
            pinRT.transform.position = new Vector3(UnityEngine.Random.Range(map.GetComponent<RectTransform>().position.x - (width / 2 * 10), map.GetComponent<RectTransform>().position.x + (width / 2 * 10)),
                UnityEngine.Random.Range(map.GetComponent<RectTransform>().position.y - (height / 2 * 10),map.GetComponent<RectTransform>().position.y + (height / 2 * 10)), 0);
            PinInfo pi = pin.AddComponent<PinInfo>();
            pi.namee = names[UnityEngine.Random.Range(0, names.Count)];
            pi.price = UnityEngine.Random.Range(0, 30).ToString() + "." + UnityEngine.Random.Range(0, 100);
            pi.discount = discounts[UnityEngine.Random.Range(0, discounts.Count)];
            pi.ratings = UnityEngine.Random.Range(0, 5).ToString();
            pi.distance = (Vector2.Distance((Vector2)map.GetComponent<RectTransform>().transform.position, (Vector2)pinRT.transform.position)*10/7).ToString();
            pi.nameTxt = nameobj.GetComponent<TextMeshProUGUI>(); pi.priceTxt = priceobj.GetComponent<TextMeshProUGUI>(); pi.discountTxt = discountobj.GetComponent<TextMeshProUGUI>();
            pi.ratingsTxt = ratingobj.GetComponent<TextMeshProUGUI>(); pi.distanceTxt = distanceobj.GetComponent<TextMeshProUGUI>();
        }
    }


}
