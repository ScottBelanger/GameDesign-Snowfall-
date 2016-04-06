using UnityEngine;
using System.Collections;

public class pauseScript : MonoBehaviour {

    public bool paused;
	// Use this for initialization
	void Start () {
        paused = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void setPaused()
    {
        if (!paused)
        {
            Time.timeScale = 0;
            paused = true;
        }
        else if (paused)
        {
            Time.timeScale = 1;
            paused = false;
        }
        
    }
}
