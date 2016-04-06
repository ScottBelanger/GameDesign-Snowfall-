using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class checkLevels : MonoBehaviour {

    GameObject level2Icon;
	void Update () {

        level2Icon = GameObject.FindGameObjectWithTag("Level2Toggle");

        if(ContactWithGround.getLevel2())
        {
            level2Icon.GetComponent<Image>().color = Color.green;
        }
        
	}
}
