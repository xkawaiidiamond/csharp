using UnityEngine;
using System.Collections;

public class lerp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, 1f, 0.01f);
    }
}
