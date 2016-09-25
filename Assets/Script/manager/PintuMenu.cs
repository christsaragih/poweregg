using UnityEngine;
using System.Collections;

public class PintuMenu : MonoBehaviour {
   public bool isTouch;
 public   int count=10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isTouch) {
            count--;
            if (count == 0)
            {
                StaticScene.SetLoadPindahScene("selectlevel", 2);
                Application.LoadLevel("Loading");
            }
            else {
                transform.Rotate(new Vector3(0, 0, -count*3));
             //   this.gameObject.transform.localScale = new Vector3(10/count, 10/count, 1);
            }
           
          
        }
	}
    public void OpenDoor() {
        isTouch = true;
    }
}
