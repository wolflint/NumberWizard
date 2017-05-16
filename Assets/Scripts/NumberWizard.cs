using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Welcom to Number Wizard");
        print("Pick a number in your head, but don't tell me!");

        int max = 1000;
        int min = 1;

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than 500?");
        print("Up = Higher, Down = Lower, Return = Equal");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow was pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow was pressed");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Return key was pressed");
        }
    }
}
