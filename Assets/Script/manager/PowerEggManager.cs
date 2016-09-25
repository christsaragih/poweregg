using UnityEngine;
using System.Collections;

public class PowerEggManager : MonoBehaviour {
    public float MaxLength, Tujuan;
    public Timbangan timbangan;
    public int level;
    public Berat satuanBerat;
    public GameObject finishWin, pause;
    static PowerEggManager myInstance;
    public int angkaBintang;
    public bool isPause;//condition wheen not pause
    public bool isWin;//condition wheen not win
    public TextMesh textAngkaBintang;
    public static PowerEggManager Instance { get { return myInstance; } }
	// Use this for initialization
	void Start () {
        myInstance = this;
        isPause = false;
        isWin = false;
        textAngkaBintang.text = angkaBintang + "";

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ClickObject() {//set angka bintang
        angkaBintang--;
        textAngkaBintang.text = angkaBintang+"";
    }
    public void Pausing() {//kondisi pause
        if (!isPause)
        {
            pause.active = true;
            isPause = true;
            Time.timeScale = 0;
        }
        else {
            pause.active = false;
            isPause = false;
            Time.timeScale = 1;
        }

    }
    public void Win() {
        Instantiate(finishWin);
    }
}
