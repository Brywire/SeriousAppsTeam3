using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundswitcher : MonoBehaviour
{
    //Calling GameObjects
    public GameObject casinobackground;
    public GameObject vegasbackground;
    public GameObject nederlandbackground;

    //Making true or false statements
    public bool isCasinobackground = false;
    public bool isVegasbackground = false;
    public bool isNederlandbackground = false;

    //Backgroundswitching
    if (isCasinobackground = false) //Casino background
        {
            casinobackground.SetActive(true);
            vegasbackground.SetActive(false);
            nederlandbackground.SetActive(false);
        
            isCasinobackground = true;
            isVegasbackground = false;
            isNederlandbackground = false;
        }
    else if (isVegasbackground = false) //Vegas background
        {
            casinobackground.SetActive(false);
            vegasbackground.SetActive(true);
            nederlandbackground.SetActive(false);

            isCasinobackground = false;
            isVegasbackground = true;
            isNederlandbackground = false;
        }
    else (isNederlandbackground = false) //Nederland background
        {
            casinobackground.SetActive(false);
            vegasbackground.SetActive(false);
            nederlandbackground.SetActive(true);

            isCasinobackground = false;
            isVegasbackground = false;
            isNederlandbackground = true;
        }
}
