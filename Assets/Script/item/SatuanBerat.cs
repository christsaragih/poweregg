using UnityEngine;
using System.Collections;

public class SatuanBerat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 

	}
	int time=0;
	// Update is called once per frame
	void Update () {
		time++;
		if (time < 20) {
			this.GetComponent<TextMesh> ().text = Timbangan.Instance.satuanberat+"";
		}

	}
}
