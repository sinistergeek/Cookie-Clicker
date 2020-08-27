using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autocookie : MonoBehaviour
{
    public bool CreatingCookie = false;
    public static int CookieIncrease =1;
    public int InternalIncrease;
  

    void Update()
    {
        CookieIncrease = GlobalBaker.backerPerSec;
        InternalIncrease = CookieIncrease;
        if(CreatingCookie == false)
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
        
    }

    IEnumerator CreateTheCookie()
    {
        GlobalCookie.cookieCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }
}
