using UnityEngine;
using System.Collections;

public class LevelManagement : MonoBehaviour {
    public GameObject[] star;
    public string level;
    static LevelManagement mystat;
    public static LevelManagement Instance { get { return mystat; } }
	// Use this for initialization
	void Start () {
        MusicManager.Instance.BG_Menu();
        mystat = this;
        switch (PlayerPrefs.GetInt(level)) {
            case 0:
                star[0].gameObject.active = false;
                star[1].gameObject.active = false;
                star[2].gameObject.active = false;
                break;
            case 1:
                star[0].gameObject.active = false;
                star[1].gameObject.active = false;
                break;
            case 2:
                star[0].gameObject.active = false;
           
                break;
        }
	}

    public void Click(string numberLevel) {
        Application.LoadLevel("Level "+numberLevel);
    }
}
