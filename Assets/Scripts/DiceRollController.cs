using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRollController : MonoBehaviour {

    public List<GameObject> DiceList;
    public GameObject Dice;

    public int DiceCount;
    
	void Start ()
    {
        DiceList = new List<GameObject>();
    }

    public void SpawnDice()
    {
        var dicePosition = new Vector3(0, 5, 0);
        var diceRotation = new Quaternion(5, 5, 5, 5);
        var diceVector = new Vector3(0, 10, 0);
        Dice.transform.position = dicePosition;

        for (int i = 0; i < DiceCount; i++)
        {
            //var diceRigidBody = Dice.GetComponent<Rigidbody>();

            var diceToSpawn = Instantiate(Dice, dicePosition, new Quaternion());
            DiceList.Add();
        }
    }
}
