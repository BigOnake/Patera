using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public static PinSpawner Instance;
    public List<GameObject> pin;

    int basePinAmount;
    int currentRound = 1;

    public Transform spawn;

    void Start()
    {
        SpawnPins();
    }

    private void Awake()
    {
        Instance = this;
    }

    public void SpawnPins()
    {
        Instantiate(pin[currentRound], pin[currentRound].transform.position, pin[currentRound].transform.rotation, null);
    }
}
