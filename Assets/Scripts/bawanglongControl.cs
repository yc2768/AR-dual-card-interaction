using UnityEngine;
using System.Collections;

public class bawanglongControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sanjiaolong")
        {
            gameObject.GetComponent<Animation>().Play("Allosaurus_Attack");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "sanjiaolong")
        {
            gameObject.GetComponent<Animation>().Play("Allosaurus_Attack");
            gameObject.transform.LookAt(other.gameObject.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "sanjiaolong")
        {
            gameObject.GetComponent<Animation>().Play("Allosaurus_Idle");
        }
    }
}
