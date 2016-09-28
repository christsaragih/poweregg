using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
    static MusicManager myInstance;
    public static MusicManager Instance { get { return myInstance; } }
    public AudioClip telurJatuh, kotakJatuh, kotakPecah, bambuJatuh,bintangKeluar;
    public AudioClip clickButton;
    public AudioClip bgSoundMenu, bgSoundGamePlay;
	// Use this for initialization
	void Start () {
        myInstance = this;
        
	}
    public void SetSound() {
        if (StaticScene.usingSound())
        {
            StaticScene.setSound(false);
            AudioListener.volume = 0;
        }
        else {
            StaticScene.setSound(true);
            AudioListener.volume = 1;
        }
    }
	// Update is called once per frame
 
    public void SFX_telurJatuh() {
        Debug.Log("Suara");
        if (StaticScene.usingSound()) {
            AudioSource.PlayClipAtPoint(telurJatuh, transform.position);
        }
    }
    public void SFX_kotakJatuh()
    {
        if (StaticScene.usingSound())
        {
            AudioSource.PlayClipAtPoint(kotakJatuh, transform.position);
        }
    }
    public void SFX_bambuJatuh()
    {
        if (StaticScene.usingSound())
        {
            AudioSource.PlayClipAtPoint(bambuJatuh, transform.position);
        }
    }
    public void SFX_bintangKeluar()
    {
        if (StaticScene.usingSound())
        {
            AudioSource.PlayClipAtPoint(bintangKeluar, transform.position);
        }
    }
    public void SFX_kotakPecah()
    {
        if (StaticScene.usingSound())
        {
            AudioSource.PlayClipAtPoint(kotakPecah, transform.position);
        }
    }
    public void SFX_ClickButton()
    {
        if (StaticScene.usingSound())
        {
            AudioSource.PlayClipAtPoint(clickButton, transform.position);
        }
    }
    public void BG_Menu()
    {
        if (StaticScene.usingSound())
        {
            AudioSource.PlayClipAtPoint(bgSoundMenu, transform.position);
        }
    }
    //
    public void BG_GamePlay()
    {
        if (StaticScene.usingSound())
        {
            AudioSource.PlayClipAtPoint(bgSoundGamePlay, transform.position);
        }
    }
}
