using UnityEngine;
using System.Collections;

public class mouseClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.up * 1000f);
        GetComponent<Rigidbody>().AddForce(transform.forward * 50f);
        GetComponent<Rigidbody>().useGravity = true;
    }
    }
