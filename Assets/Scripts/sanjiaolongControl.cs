﻿using UnityEngine;
using System.Collections;

public class sanjiaolongControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="bawanglong")
        {
            gameObject.GetComponent<Animation>().Play("attack");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "bawanglong")
        {
            gameObject.GetComponent<Animation>().Play("attack");
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "bawanglong")
        {
            gameObject.GetComponent<Animation>().Play("idle");
        }
    }
}
