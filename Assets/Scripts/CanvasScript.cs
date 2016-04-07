using UnityEngine;
using System.Collections;

public class CanvasScript : MonoBehaviour {

    public static bool menuUpdated;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        menuUpdated = false;
        ContactWithGround.setgroundContact(false);
        GameObject menu = GameObject.FindWithTag("LevelFinish");
        menu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (ContactWithGround.getgroundContact() && !menuUpdated)
        {
            Time.timeScale = 0;
            menuUpdated = true;

            GameObject menu = this.transform.GetChild(3).gameObject;
            Debug.Log(menu);
            menu.SetActive(true);

            if (DestroyByContact.getScore() < 100)
            {
                GameObject contBtn = menu.transform.GetChild(0).gameObject;
                Debug.Log(contBtn);
                contBtn.SetActive(false);
            }
        }
    }
}
