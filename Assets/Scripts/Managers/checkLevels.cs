using UnityEngine;
using System.Collections;

public class checkLevels : MonoBehaviour {

	void Update () {

        if(ContactWithGround.getLevel2())
        {
            GameObject level2 = GameObject.FindGameObjectWithTag("Level2Toggle");
            //level2.GetComponent<Renderer>().material="#77FF29FF";
        }
        
	}
}
