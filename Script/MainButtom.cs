using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtom : MonoBehaviour
{
    public GameObject Textbox;
    public AudioSource cookieSound;
    public void ClickButton()
    {
        cookieSound.Play();
        GlobalCookie.cookieCount += 1;
    }
}
