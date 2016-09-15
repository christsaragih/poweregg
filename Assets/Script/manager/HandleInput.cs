using UnityEngine;
using System.Collections;

public class HandleInput : MonoBehaviour
{
    Collider2D coll;
  
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
        switch (this.gameObject.tag) {
            case "kotak":
                this.GetComponent<kotak>().Touch();
                break;

        }
    }

}
