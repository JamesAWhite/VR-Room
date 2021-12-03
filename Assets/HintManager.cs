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
        step1 = false;
        step2 = false;
        step3 = false;
        step4 = false;
        step5 = false;
        step6 = false;
        step7 = false;
        step8 = false;
        step9 = false;
        step10 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool step1, step2, step3, step4, step5, step6, step7, step8, step9, step10;

    public void ChangeGameState(int newState)
    {
        gameState = newState;
        switch (gameState)
        {
            case 1:
                GetComponent<Text>().text = "It needs a battery. Check the drawers.";
                step1 = true;
                break;
            case 2:
                GetComponent<Text>().text = "That's a battery! Put it in the camera.";
                step2 = true;
                break;
            case 3:
                GetComponent<Text>().text = "Take a picture of something weird...";
                step3 = true;
                break;
            case 4:
                GetComponent<Text>().text = "Perfect. Put that picture somewhere comfy.";
                step4 = true;
                break;
            case 5:
                GetComponent<Text>().text = "Good. Now turn on the switch.";
                step5 = true;
                break;
            case 6:
                GetComponent<Text>().text = "Twist the knob to the right";
                step6 = true;
                break;
            case 7:
                GetComponent<Text>().text = "Get the key from the table";
                step7 = true;
                break;
            case 8:
                GetComponent<Text>().text = "Put it in the keyhole";
                step8 = true;
                break;
            case 9:
                GetComponent<Text>().text = "Open the door";
                step9 = true;
                break;
            case 10:
                GetComponent<Text>().text = "You've escaped!";
                step10 = true;
                break;
            default:
                break;
        }
        keySpawnCheck();
    }

    public bool finalStepCheck()
    {
        if (step9)
        {
            ChangeGameState(10);
            return true;
        }
        return false;
    }

    public GameObject keySpawner;
    public void keySpawnCheck()
    {
        if (step1 && step2 && step3 && step4 && step5 && step6 && step7)
        {
            keySpawner.GetComponent<SpawnObject>().Spawn();
        }
    }
}
