using UnityEngine;
using System.Collections;

public class destroyComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            Destroy(GetComponent<MeshRenderer>());
            Destroy(GetComponent<BoxCollider>());
        }
            
	
	}
}
