using UnityEngine;
using System.Collections;

public class kotak : MonoBehaviour {
    static kotak myInstance;
    public static kotak Instance { get { return myInstance; } }
    Animator anim;
	// Use this for initialization
	void Start () {
        myInstance = this;
        anim = this.GetComponent<Animator>();
 
    }

    // Update is called once per frame
    void Update () {
	
	}
    public void Touch() {
        if (anim != null)
        {
            MusicManager.Instance.SFX_kotakPecah();
            anim.SetInteger("kotakPos", 1);
        }
    }
    public void Destroy() {
        Destroy(this.gameObject);
    }
  
}
