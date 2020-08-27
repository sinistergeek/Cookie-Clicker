using UnityEngine;
using UnityEngine.UI;
public class GlobalCookie : MonoBehaviour
{
    public static int cookieCount;
    public GameObject cookieDisplay;
    public int internalCookie;
    void Update()
    {
        internalCookie = cookieCount;
        cookieDisplay.GetComponent<Text>().text = "Cookie : " + internalCookie;
    }
}
