using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public static PinSpawner Instance;
    public List<GameObject> pin;

    int basePinAmount;

    public Transform spawn;

    private void Awake()
    {
        Instance = this;
    }

    public void SpawnPins(int currentRound)
    {
        Instantiate(pin[currentRound], pin[currentRound].transform.position, pin[currentRound].transform.rotation, null);
    }
}
