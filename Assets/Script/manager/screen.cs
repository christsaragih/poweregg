using UnityEngine;
using System.Collections;

public class screen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Screen.SetResolution(1280, 800, true);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
