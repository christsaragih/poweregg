using UnityEngine;
using System.Collections;

public class Bamboo : MonoBehaviour {
    public bool canMove;
	// Use this for initialization
	void Start () {
        if (!canMove)
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
      
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log(coll.gameObject.name);
        if (coll.gameObject.tag == "Player") {
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
