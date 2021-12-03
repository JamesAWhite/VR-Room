using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] private GameObject wantedObject;
    [SerializeField] private GameObject managerObject;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains(wantedObject.name))
        {
            hintUpdate();
        }
    }

    private void hintUpdate()
    {
        managerObject.GetComponent<HintManager>().ChangeGameState(5);
    }
}
