using UnityEngine;
using System.Collections;

public class WinCOndition : MonoBehaviour {
    int NumberStar;
    public GameObject  star;
	// Use this for initialization
	void ShowStar () {
        NumberStar = PowerEggManager.Instance.angkaBintang;
        switch(NumberStar){
            case 3:
                Instantiate(star, new Vector3(-2.89f, -0.8f, -6f),Quaternion.identity);
                Instantiate(star, new Vector3(-1.89f, -0.8f, -6f), Quaternion.identity);
                Instantiate(star, new Vector3(-0.89f, -0.8f, -6f), Quaternion.identity);
                break;
            case 1:
                Instantiate(star, new Vector3(-2.89f, -0.8f, -6f), Quaternion.identity);
            

                break;
            case 2: {
                    Instantiate(star, new Vector3(-2.89f, -0.8f, -6f), Quaternion.identity);
                    Instantiate(star, new Vector3(-1.89f, -0.8f, -6f), Quaternion.identity);

                    break;
                }
        }
	}
	
	// Update is called once per frame
	 
}
