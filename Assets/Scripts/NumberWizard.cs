﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;

	// Use this for initialization
	void Start () {
        StartGame();
	}

    void StartGame ()
    {
        guess = 500;
        max = 1000;
        min = 1;
        print("~-~-~-~-~-~-~-~-~-~-~-~-~");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");

        

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " +guess +"?");
        print("Up = Higher, Down = Lower, Return = Equal");
        max = max + 1;
    }


    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
            //print("Up arrow was pressed");
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            //print("Down arrow was pressed");
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
        print("Up = Higher, Down = Lower, Return = Equal");
    }

}
