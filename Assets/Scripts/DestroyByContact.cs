using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        if (other.tag == "Snowflake")
        {
            transform.localScale += new Vector3(0.1F, 0.1F, 0);
        }
    }
}