using UnityEngine;
using System.Collections;

public class foreachscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] strings = new string[3];

        strings[0] = "1huj";
        strings[1] = "string 2";
        strings[2] = "string 3";

        foreach (string item in strings)
        {
            print(item);
        }
        /*
        int[] ints = new int[3];

        ints[0] = 1;
        ints[1] = 2;
        ints[2] = 3;

        foreach (int integer in ints)
            {
            print(integer);
        }
        */


	
	}
	
}


   
