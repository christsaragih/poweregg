using UnityEngine;
using System.Collections;

public class penunjukarah : MonoBehaviour {
	public GameObject arah;
	public static penunjukarah Instance{get{return my;}}
	public	bool press;	
	static penunjukarah my;

	Ray ray;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
		my = this;

	}
	public float timePress;
	// Update is called once per frame
	void Update () {
		if (press) {
			timePress++;
			if(timePress>60){
				press=false;
				timePress=0;

			}
		}

		// arah.transform.position.y * 5.51f-2
		this.transform.position = new Vector3 (arah.transform.position.x * 20-10f,arah.transform.position.y * 12f-5);
	}
	 
}
