using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public static PinSpawner Instance;
    public List<GameObject> pinPreFab;
    public GameObject pins;
    public Transform spawn;

    public void SpawnPins()
    {
        pins = Instantiate(pinPreFab[GameManager.currentFrame - 1], spawn.transform.position, spawn.transform.rotation, null);
    }

    public void DestroyPins()
    {
        Destroy(pins);
    }
}