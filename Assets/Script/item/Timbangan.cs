using UnityEngine;
using System.Collections;

public class Timbangan : MonoBehaviour {
    public GameObject penunjuk,tujuan;
    public float berat,timbang;//untuk berat dan waktu
    static Timbangan myInstance;
	public Berat satuanberat;
    public float MaxTimbangan;
    public GameObject status;//status dari berat yang tampil di layar
    public static Timbangan Instance { get { return myInstance; } }
	// Use this for initialization
	void Start () {
       
        myInstance = this;
	}
	public void adaTambahan(float tambahan) {
 
		switch(satuanberat){
		case Berat.ons:tambahan=tambahan*10; break;
		case Berat.dag:tambahan=tambahan*100; break;
		case Berat.g:tambahan=tambahan*1000; break;
		case Berat.dg:tambahan=tambahan*10000; break;
		case Berat.cg:tambahan=tambahan*100000; break;
		case Berat.mg:tambahan=tambahan*1000000; break;
		case Berat.pon:tambahan=tambahan*5; break;
		}
		
		tambah(tambahan);
		 
	}
    public void tambah(float tambahan) {
      
        berat += tambahan;
        
    }
    public void SetMaxTimbangan(float Max,Berat satuanBerat) {
        MaxTimbangan = Max;
		satuanberat = satuanBerat;
    }
	int asd = 1;
	// Update is called once per frame
	void Update () {
        SetAngkaBerat();
        tujuan.transform.eulerAngles = new Vector3(0, 0, (-360 / MaxTimbangan * PowerEggManager.Instance.Tujuan));// untuk timbangan tujuan
        if (berat > timbang) {
            float temp = berat - timbang;
            timbang += temp / 13;
            penunjuk.transform.eulerAngles = new Vector3(0, 0, (-360/MaxTimbangan * timbang));
        }
	}
    void SetAngkaBerat() {
        status.GetComponent<TextMesh>().text = Mathf.Ceil(timbang) + " / " + PowerEggManager.Instance.Tujuan;
    }
}
