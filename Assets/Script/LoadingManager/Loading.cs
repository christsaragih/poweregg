using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {
    int staticTime;
    public GameObject kompas;
    private int count;
    private string scenetujuan;
	// Use this for initialization
	void Start () {
        scenetujuan = StaticScene.GetNamaTujuan();
        staticTime = StaticScene.GetWaktu() * 60;

	}
	
	// Update is called once per frame
	void Update () {
        count++;
        kompas.transform.Rotate(new Vector3(0,0,-(staticTime-count)/6));
        if (staticTime == count) {
            Debug.Log("Pindah Kes Scene " + StaticScene.GetNamaTujuan());
            Application.LoadLevel(scenetujuan);
        }
	}
}
