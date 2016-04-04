using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class DistanceToGround : MonoBehaviour
{
    public static float distance;
    Text text;

    // Use this for initialization
    void Awake()
    {
        text = GetComponent<Text>();
        distance = 0;
    }

    
    void Update()
    {
        GameObject Snowflake = GameObject.FindWithTag("Player");
        GameObject Ground = GameObject.FindWithTag("Ground");
        distance = (Snowflake.transform.position.y-Snowflake.GetComponent<Renderer>().bounds.size.y/2) - (Ground.transform.position.y+Ground.GetComponent<Renderer>().bounds.size.y/2);
        distance = (float)(Math.Truncate((double)distance));

        if(distance < 0 )
        {
            distance = 0;
        }
        text.text = "Ground: " + distance + "ft";
    }
}
