using UnityEngine;
using System.Collections;

public class PauseButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (PowerEggManager.Instance.isPause)
        {
            this.name = "BukanPause";
        }
        else {
            this.name = "buttonPause";
        }
	}
}
