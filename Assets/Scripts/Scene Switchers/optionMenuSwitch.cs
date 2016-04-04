using UnityEngine;
using System.Collections;

public class optionMenuSwitch : MonoBehaviour {

    public string scene;

    public void switchScene()
    {
        Debug.Log("Switch");
        Application.LoadLevel(scene);
    }
}
