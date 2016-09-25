using UnityEngine;
using System.Collections;

public class HandleInput : MonoBehaviour
{
    Collider2D coll;
    GameObject temps;
    Vector3 mySize, pushSize;
  
    // Use this for initialization
    void Start()
    {
        coll = GetComponent<Collider2D>();
        mySize = this.transform.localScale;
        pushSize = new Vector3(mySize.x - 0.1f, mySize.y - 0.1f);
 
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = mySize;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            if (coll && coll.OverlapPoint(pos))
            {
                this.transform.localScale = pushSize;
                InputLogic();
            }
        }
    }
    void InputLogic() {
        switch (this.gameObject.tag) {//case tag 
            case "kotak":
                this.GetComponent<kotak>().Touch();
                PowerEggManager.Instance.ClickObject();
                break;
            case "pause":
                PowerEggManager.Instance.Pausing();
                break;
            case "Level":
                StaticScene.SetLoadPindahScene("Level "+this.gameObject.name, 4);
                Application.LoadLevel("Loading");
                break;
            case "home":
                Time.timeScale = 1;
                StaticScene.SetLoadPindahScene("Menu", 1);
                Application.LoadLevel("Loading");
                break;
        }
        switch (this.gameObject.name)//case name
        {
            case "reload":
                StaticScene.SetLoadPindahScene("Level " + PowerEggManager.Instance.level, 1);
                Application.LoadLevel("Loading");
                break;
            case "button-play":
                GameObject.Find("button-play").GetComponent<PintuMenu>().OpenDoor();
                break;
        }
    }

}
