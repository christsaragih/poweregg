using UnityEngine;
using System.Collections;

public class ButtonSound : MonoBehaviour {
    public Sprite SoundOn, SoundOff;
    // Use this for initialization
    void start()
    {
        if (StaticScene.usingSound())
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SoundOff;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SoundOn;
        }
    }
    public void SetSprite() {
        if (StaticScene.usingSound()) {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SoundOff;
        } else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SoundOn;
        }
        MusicManager.Instance.SetSound();
    }
 
}
