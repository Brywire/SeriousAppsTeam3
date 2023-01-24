using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public StoryScene currentScene;
    public BottomBarController bottomBar;
    public BackgroundController backgroundController;

    // Start is called before the first frame update
    void Start()
    {
        bottomBar.PlayScene(currentScene);
        backgroundController.SetImage(currentScene.background);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) || Input.touchSupported)
        {
            if (bottomBar.isCompleted())
            {
                if(bottomBar.isLastSentence())
                {
                    currentScene = currentScene.nextScene;
                    bottomBar.PlayScene(currentScene);
                    backgroundController.SwitchImage(currentScene.background);
                }
                else
                {
                    bottomBar.PlayNextSentence();
                }
            }
        }
    }
}