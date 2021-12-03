using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] private GameObject managerObject;
    [SerializeField] private GameObject targetObject;

    public void openDoor()
    {
        if (managerObject.GetComponent<HintManager>().finalStepCheck())
        {
            targetObject.SetActive(false);
        }
    }
}
