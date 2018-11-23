using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    [SerializeField]
    GameObject walkingObject;

    // Use this for initialization
    void Start () {
        gameObject.GetComponentInParent<LegalMoveActions>().Jump += OnJump;
        gameObject.GetComponentInParent<LegalMoveActions>().MoveLeft += OnLeft;
        gameObject.GetComponentInParent<LegalMoveActions>().MoveRight += OnRight;
	}

    private void OnRight()
    {
        Vector3 velocity = walkingObject.GetComponent<Rigidbody>().velocity;
        if (velocity.x < 3) {
            walkingObject.GetComponent<Rigidbody>().AddForce(new Vector3(3, 0, 0), ForceMode.Impulse);
        }
        walkingObject.GetComponent<Animator>().StartPlayback();
    }

    private void OnLeft()
    {
        Vector3 velocity = walkingObject.GetComponent<Rigidbody>().velocity;
        if (velocity.x > -3)
        {
            walkingObject.GetComponent<Rigidbody>().AddForce(new Vector3(-3, 0, 0), ForceMode.Impulse);
        }
        walkingObject.GetComponent<Animator>().StopPlayback();
    }

    private void OnJump()
    {
        Vector3 velocity = walkingObject.GetComponent<Rigidbody>().velocity;
        if (velocity.y == 0)
        {
            walkingObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
