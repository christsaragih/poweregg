using UnityEngine;
using System.Collections;

public class PowerEggManager : MonoBehaviour {
    public float MaxLength, Tujuan;
    public Timbangan timbangan;
    public Berat SatuanBerat;
    public GameObject finishWin, pause;
    static PowerEggManager myInstance;
 
    public static PowerEggManager Instance { get { return myInstance; } }
	// Use this for initialization
	void Start () {
        myInstance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
