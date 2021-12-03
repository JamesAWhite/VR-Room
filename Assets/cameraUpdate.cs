using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        didUpdate = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool didUpdate;
    [SerializeField] private GameObject managerObject;
    public void oneTimeUpdate()
    {
        if (!didUpdate)
        {
            managerObject.GetComponent<HintManager>().ChangeGameState(1);
            didUpdate = true;
        }
    }

    public void preventUpdate()
    {
        didUpdate = true;
    }
}
