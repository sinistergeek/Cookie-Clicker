
using UnityEngine;
using UnityEngine.UI;
public class GlobalBaker : MonoBehaviour

{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    //here i need to change value to 50; For demo purpose only 50
    public static int bakerValue = 50;
    public static bool turnoffButton = false;
    public GameObject backerStat;
    public static int numberofBakers;
    public static int backerPerSec;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.cookieSell;
        backerStat.GetComponent<Text>().text = "Bakers : " + numberofBakers + " @ " + backerPerSec + "per Second";
        fakeText.GetComponent<Text>().text = "Buy baker = $" + bakerValue;
        realText.GetComponent<Text>().text = "Buy baker = $" + bakerValue;
        if(currentCash >= bakerValue)
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
