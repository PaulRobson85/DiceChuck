using UnityEngine;
using UnityEngine.UI;

public class DiceSelectorButtonController : MonoBehaviour {

    public Button Button;
    public InputField InputField;
    public GameObject diceSpawner;

    private int diceCount = 0;

    // Use this for initialization
    void Start () {
        Button.onClick.AddListener(OnButtonClick);	
	}
	
	void OnButtonClick()
    {
        int.TryParse(InputField.text, out diceCount);
        diceSpawner.SendMessage("SpawnDice", diceCount);
    }
}
