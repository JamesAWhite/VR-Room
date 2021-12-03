using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryIntoCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject enable = new GameObject();
    [SerializeField] private GameObject manager = new GameObject();

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Camera")
        {
            Destroy(gameObject);
            enable.GetComponent<MyRayScript>().batt = true;
            manager.GetComponent<HintManager>().ChangeGameState(3);
        }
    }

    public void pickUpBattery()
    {
        manager.GetComponent<HintManager>().ChangeGameState(2);
    }
}
