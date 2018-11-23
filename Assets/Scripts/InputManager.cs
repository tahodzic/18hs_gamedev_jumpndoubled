using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    public event Action<string> InputListeners= delegate { };
    public static InputManager instance = null;

    // TODO: Eine Event Action erstellen namens "FireAllWeapons".
    // TODO: Die Event Action dann aufrufen, solange wir die Leertaste drücken.

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a InputManager.
            Destroy(gameObject);
    }


    void Update()
    {
        ///GetKeyDown gibts auch, kann aber nicht permanent gedrückte LEertaste erkenneen
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    CharacterChanger();
        //}
        var input = Input.inputString;
        if (input != "")
        {
            InputListeners(input);
        }
    }
}
