using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalCash : MonoBehaviour
{
    public static int cookieSell;
    public GameObject cashDisplay;
    public int internalCash;
    void Update()
    {
        internalCash = cookieSell;
        cashDisplay.GetComponent<Text>().text = "$ " + internalCash;
    }
}
