using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snowflake")
        {
            Destroy(other.gameObject);
            transform.localScale += new Vector3(0.1F, 0.1F, 0);
        }
    }
}