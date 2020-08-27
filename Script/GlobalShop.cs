
using UnityEngine;
using UnityEngine.UI;
public class GlobalShop : MonoBehaviour

{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    //here i need to change value to 50; For demo purpose only 50
    public static int ShopValue = 50;
    public static bool turnoffButton = false;
    public GameObject ShopStat;
    public static int numberofShop;
    public static int shopPerSec;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.cookieSell;
        ShopStat.GetComponent<Text>().text = "Shops : " + numberofShop + " @ " + shopPerSec + "per Second";
        fakeText.GetComponent<Text>().text = "Buy Shops  = $" + ShopValue;
        realText.GetComponent<Text>().text = "Buy shops  = $" + ShopValue;
        if(currentCash >= ShopValue)
        {
            fakeButton.SetActive(false);

            realButton.SetActive(true);
        }
        if(turnoffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnoffButton = false;
        }
    }
}
