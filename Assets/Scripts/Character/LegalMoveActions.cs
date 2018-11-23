using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LegalMoveActions : MonoBehaviour {
    public event Action Jump = delegate { };
    public event Action MoveLeft = delegate { };
    public event Action MoveRight = delegate { };

	// Use this for initialization
	void Start () {
        InputManager.instance.InputListeners += OnMove;
    }
	
	// Update is called once per frame
	void Update () {
		   
	}

    private void OnMove(string input)
    {
        switch (input)
        {
            case "d":
                MoveRight();
                break;
            case "a":
                MoveLeft();
                break;
            case "w":
                Jump();
                break;
        }
    }
}
