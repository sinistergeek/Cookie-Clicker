using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int SavedCookies;
    public int SavedCash;
    public int SavedBakers;
    public int SavedShops;
    public int saveValue;
    void Start()
    {
        if(MainMenuScript.isLoading == true)
        {
            SavedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookie.cookieCount = SavedCookies;
            SavedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.cookieSell = SavedCash;
            SavedBakers = PlayerPrefs.GetInt("SavedBakers");
            GlobalBaker.backerPerSec = SavedBakers;
            SavedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberofShop = SavedShops;
            saveValue = PlayerPrefs.GetInt("saveValue");
            SaveGame.saveValue = saveValue;
         
        }
    }   


}
