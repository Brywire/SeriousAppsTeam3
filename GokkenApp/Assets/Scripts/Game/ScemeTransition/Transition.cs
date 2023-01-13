using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasgroup;
    [SerializeField] private GameObject BeforeScene;
    [SerializeField] private GameObject AfterScene;

    private bool _fadein = false;
    private bool _fadeout = false;

    private void Update()
    {
        if(_fadein)
        {
            BeforeScene.SetActive(true);
            if (canvasgroup.alpha < 1)
            {
                canvasgroup.alpha += Time.deltaTime;
                if(canvasgroup.alpha >= 1)
                {
                    _fadein= false;
                }
            }
        }

        if(_fadeout)
        {
            if(canvasgroup.alpha >= 0)
            {
                canvasgroup.alpha -= Time.deltaTime;
                if(canvasgroup.alpha == 0)
                {
                    _fadeout= false;
                    BeforeScene.SetActive(false);
                    AfterScene.SetActive(true);
                }
            }
        }
    }

    public void FadeIn()
    {
        _fadein = true;
    }

    public void FadeOut()
    {
        _fadeout = true;
    }
}
