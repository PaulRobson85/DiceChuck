using System;
using System.Collections.Generic;
using diag = System.Diagnostics;
using System.Linq;
using UnityEngine;

public class DiceSpawnController : MonoBehaviour {

    public List<GameObject> DiceList;
    public GameObject Dice;
    public System.Random randomSource = new System.Random(DateTime.Now.Millisecond);

    private diag.Stopwatch _stopWatch = new diag.Stopwatch();

    void Start ()
    {
        DiceList = new List<GameObject>();
    }

    void Update()
    {
        if (_stopWatch.ElapsedMilliseconds > 1000 && DiceList.All(o => ObjectStoppedMoving(o)))
            Debug.Log("All dice stopped!!!!!");
    }

    public void SpawnDice(int DiceCount)
    {
        Debug.Log("Spawning Dice...");
        float force = 10;
        for (int i = 0; i < DiceCount; i++)
        {
            var spawnPosition = new Vector3(
                i * 1.5F * Dice.GetComponent<Renderer>().bounds.size.x,
                5, 
                0);
            var spawnedDice = Instantiate(Dice, spawnPosition, new Quaternion());

            Rigidbody rb = spawnedDice.GetComponent<Rigidbody>();
            float randomisedForce = force*(float)(0.5+randomSource.NextDouble()/2);
            var diceForce = new Vector3(randomisedForce, randomisedForce, randomisedForce);
            rb.AddForce(diceForce, ForceMode.Impulse);
            rb.angularVelocity = 10*diceForce;

            DiceList.Add(spawnedDice);
        }
        _stopWatch.Start();
    }

    private float GetDiceWidth(GameObject Dice)
    {
        return Dice.GetComponent<Renderer>().bounds.size.x;
    }

    private bool ObjectStoppedMoving(GameObject o)
    {
        var zeroVelocity = new Vector3(0, 0, 0);
        var objectVelocity = o.GetComponent<Rigidbody>().velocity;
        return zeroVelocity == objectVelocity;
    }
}
