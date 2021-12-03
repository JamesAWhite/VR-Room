using UnityEngine;

/// <summary>
/// Spawn an object at a transform's position
/// </summary>
public class SpawnObject : MonoBehaviour
{
    [Tooltip("The object that will be spawned")]
    public GameObject originalObject = null;

    [Tooltip("The transform where the object is spanwed")]
    public Transform spawnPosition = null;

    [SerializeField] private GameObject managerObject;
    [SerializeField] private bool didHint = false;
    public void Spawn()
    {
        Instantiate(originalObject, spawnPosition.position, spawnPosition.rotation);
        managerObject.GetComponent<HintManager>().ChangeGameState(4);
    }

    private void OnValidate()
    {
        if (!spawnPosition)
            spawnPosition = transform;
    }
}
