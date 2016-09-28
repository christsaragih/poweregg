using UnityEngine;
using System.Collections;

public class Telur : MonoBehaviour {
    public float berat;// Untuk menyimpan nilai berat telur
    public TextMesh myTetx;
	// Use this for initialization
	void Start () {
        myTetx.text = berat + "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll) {
       
        if (coll.gameObject.name == "Timbangan") {
            Timbangan.Instance.tambah(berat);
        }
    }
    void OnCollisionEnter2D(Collision2D coll) { 
        MusicManager.Instance.SFX_telurJatuh();
    }
}
