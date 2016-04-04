﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour
{

    public static float score;
    Text text;

    void Awake()
    {
        text = GameObject.FindWithTag("scoreText").GetComponent<Text>();
        score = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snowflake")
        {
            Debug.Log("Hit");
            Destroy(other.gameObject);
            transform.localScale += new Vector3(0.1F, 0.1F, 0);
            score = score + 10;
            text.text = "Score: " + score;
        }
    }
}