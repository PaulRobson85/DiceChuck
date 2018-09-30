using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRollController : MonoBehaviour {

    public List<GameObject> DiceList;
    public GameObject Dice;

    public int DiceCount;

	// Use this for initialization
	void Start ()
    {
        var dicePosition = new Vector3(0, 5, 0);
        var diceRotation = new Quaternion(5, 5, 5, 5);
        Dice.transform.position = dicePosition;
        
        for (int i=0; i<DiceCount; i++)
        {
            //var diceRigidBody = Dice.GetComponent<Rigidbody>();

            DiceList.Add(Instantiate(Dice, dicePosition, new Quaternion()));
        }
	}
}
