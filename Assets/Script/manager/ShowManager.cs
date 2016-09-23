using UnityEngine;
using System.Collections;

public class ShowManager : MonoBehaviour {
    int myLife=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        myLife++;
        if (myLife > 50) {
            Destroy(this.gameObject);
        }
	}
}
