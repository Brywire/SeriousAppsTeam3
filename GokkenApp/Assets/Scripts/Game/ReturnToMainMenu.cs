using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasgroup;
    private bool _fadeoutToQuit = false;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        if (_fadeoutToQuit)
        {
            if (canvasgroup.alpha >= 0)
            {
                canvasgroup.alpha -= Time.deltaTime;
                if (canvasgroup.alpha == 0)
                {
                    _fadeoutToQuit = false;
                }
            }
        }
    }
}
