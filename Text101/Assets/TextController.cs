using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
    private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_01, lock_01, freedom};
    private States myState; 

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if(myState == States.cell) {
            state_cell();
        } else if(myState == States.sheets_0) {
            state_sheet_0();
        }
	}

    void state_cell () {
        text.text = "You are in a prison cell, and you want to escape." +
            "There are some dirty sheets on the bed, a mirror on the wall, " +
            "and the door is looked from outside. " +
            "Press S to view Sheets, M to view Mirror and L to view Lock.";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.sheets_0;
        }
     }

    void state_sheet_0() {
            text.text = "You can't believe you sleep int these things, Surely it's " +
                "time somebody changed them. The pleasures of prision life " +
                "I guess!\n\n" +
                "Press R to return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        }
    }
}