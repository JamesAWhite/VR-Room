using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintManager : MonoBehaviour
{
    public int gameState;
    // Start is called before the first frame update
    void Start()
    {
        gameState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeGameState(int newState)
    {
        gameState = newState;
        switch (gameState)
        {
            case 1:
                GetComponent<Text>().text = "It needs a battery. Check the drawers.";
                break;
            case 2:
                GetComponent<Text>().text = "That's a battery! Put it in the camera.";
                break;
            case 3:
                GetComponent<Text>().text = "Take a picture of something weird...";
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
            default:
                break;
        }
    }
}
