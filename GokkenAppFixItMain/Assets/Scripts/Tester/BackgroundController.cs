using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundController : MonoBehaviour
{

    public bool isSwitched = false;
    public Image background1;
    public Image background2;
    public Image background3;
    public Image background4;
    public Image background5;
    public Image background6;
    public Image background7;
    public Image background8;
    public Image background9;
    public Animator animator;

    public void SwitchImage(Sprite sprite)
    {
        if (!isSwitched)
        {
            background2.sprite = sprite;
            animator.SetTrigger("SwitchFirst");
        }
        else
        {
            background1.sprite = sprite;
            animator.SetTrigger("SwitchSecond");
        }

        if (!isSwitched)
        {
            background3.sprite = sprite;
            animator.SetTrigger("SwitchSecond");
        }
        else
        {
            background2.sprite = sprite;
            animator.SetTrigger("SwitchThird");
        }

        if(!isSwitched)
        {
            background4.sprite = sprite;
            animator.SetTrigger("SwitchThird");
        }
        else
        {
            background3.sprite = sprite;
            animator.SetTrigger("SwitchFourth");
        }

        if (!isSwitched)
        {
            background5.sprite = sprite;
            animator.SetTrigger("SwitchFourth");
        }
        else
        {
            background4.sprite = sprite;
            animator.SetTrigger("SwitchFifth");
        }

        if (!isSwitched)
        {
            background6.sprite = sprite;
            animator.SetTrigger("SwitchFifth");
        }
        else
        {
            background5.sprite = sprite;
            animator.SetTrigger("SwitchSixth");
        }

        if (!isSwitched)
        {
            background7.sprite = sprite;
            animator.SetTrigger("SwitchSixth");
        }
        else
        {
            background6.sprite = sprite;
            animator.SetTrigger("SwitchSeventh");
        }

        if (!isSwitched)
        {
            background7.sprite = sprite;
            animator.SetTrigger("SwitchSeventh");
        }
        else
        {
            background8.sprite = sprite;
            animator.SetTrigger("SwitchEigth");
        }

        if (!isSwitched)
        {
            background8.sprite = sprite;
            animator.SetTrigger("SwitchEigth");
        }
        else
        {
            background9.sprite = sprite;
            animator.SetTrigger("SwitchNinth");
        }

        isSwitched = !isSwitched;
    }

    public void SetImage(Sprite sprite)
    {
        if (!isSwitched)
        {
            background2.sprite = sprite;
        }
        else
        {
            background1.sprite = sprite;
        }

        if (!isSwitched)
        {
            background3.sprite = sprite;
        }
        else
        {
            background2.sprite = sprite;
        }

        if (!isSwitched)
        {
            background4.sprite = sprite;
        }
        else
        {
            background3.sprite = sprite;
        }

        if (!isSwitched)
        {
            background5.sprite = sprite;
        }
        else
        {
            background4.sprite = sprite;
        }

        if (!isSwitched)
        {
            background6.sprite = sprite;
        }
        else
        {
            background5.sprite = sprite;
        }

        if (!isSwitched)
        {
            background7.sprite = sprite;
        }
        else
        {
            background6.sprite = sprite;
        }

        if (!isSwitched)
        {
            background8.sprite = sprite;
        }
        else
        {
            background7.sprite = sprite;
        }

        if (!isSwitched)
        {
            background9.sprite = sprite;
        }
        else
        {
            background8.sprite = sprite;
        }
    }
}
