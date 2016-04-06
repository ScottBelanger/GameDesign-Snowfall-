using UnityEngine;
using System.Collections;

public class goToLevel2 : MonoBehaviour {

    public string scene;

    public void switchScene()
    {
        if (ContactWithGround.getLevel2())
        {
            Application.LoadLevel(scene);
        }
    }
}
