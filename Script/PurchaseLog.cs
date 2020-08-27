
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoSell;
    public GameObject AutoCookie;
    public AudioSource playSound;
    public void StartAutoCookie()
    {
        playSound.Play();
        AutoCookie.SetActive(true);
          GlobalCash.cookieSell -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.turnoffButton = true;
        GlobalBaker.backerPerSec += 1;
        GlobalBaker.numberofBakers += 1;
    }
    public void StartAutoSell()
    {
        playSound.Play();
        AutoSell.SetActive(true);
        GlobalCash.cookieSell -= GlobalShop.ShopValue;
        GlobalShop.ShopValue *= 2;
        GlobalShop.turnoffButton = true;
        GlobalShop.shopPerSec += 1;
        GlobalShop.numberofShop += 1;
    }
}
