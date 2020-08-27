
using UnityEngine;
using UnityEngine.UI;
public class SaveGame : MonoBehaviour
{

    public int saveGameCash;
    public static int saveValue = 100;
    public GameObject SaveBtn;
    public GameObject saveText;

    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost: $" + saveValue;

        saveGameCash = GlobalCash.cookieSell;
        if (saveGameCash >= saveValue)
        {
            SaveBtn.GetComponent<Button>().interactable = true;

        }
        else
        {
            SaveBtn.GetComponent<Button>().interactable = false;
        }
    }

    public void SaveTheGame()
    {
        GlobalCash.cookieSell -= saveValue;
        PlayerPrefs.SetInt("SavedCookies", GlobalCookie.cookieCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.cookieSell);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.backerPerSec);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.numberofShop);
        saveValue *= 2;
        PlayerPrefs.SetInt("saveValue", saveValue);
    }
}
