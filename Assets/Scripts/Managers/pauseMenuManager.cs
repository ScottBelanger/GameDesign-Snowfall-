using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class pauseMenuManager : MonoBehaviour {

    public GameObject menuPanel;
	// Use this for initialization
	void Start () {
        menuPanel = GameObject.FindGameObjectWithTag("PauseMenu");
        menuPanel.SetActive(false);

	}
	
}
