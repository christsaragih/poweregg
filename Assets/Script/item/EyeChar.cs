using UnityEngine;
using System.Collections;

public class EyeChar : MonoBehaviour {

    public Sprite[] myEye;
    public int random, count;

    // Use this for initialization
    void Start()
    {

        random = Random.Range(30, 120);
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (random == count)
        {
            count = 0;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = myEye[1];
            random = Random.Range(30, 120);
        }
        if (count > 15)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = myEye[0];
        }
    }
}
