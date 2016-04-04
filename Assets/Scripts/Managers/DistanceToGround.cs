using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
        distance = Vector3.Distance(Snowflake.transform.position, Ground.transform.position);
        text.text = "Ground: " + distance;
    }
}
