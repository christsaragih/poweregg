using UnityEngine;
using System.Collections;

public class AngkaManager : MonoBehaviour {
    public GameObject[] angka;
    float nilai = 0;
    // Use this for initialization
 
	// Update is called once per frame
	void Update () {
        if (nilai < 11)
        {
            for (int i = 0; i < angka.Length; i++)
            {
                nilai = i + 1;
                angka[i].GetComponent<TextMesh>().text = "" + PowerEggManager.Instance.MaxLength*i / 10;
            }
        }
    }
}
