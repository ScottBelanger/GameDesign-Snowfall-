using UnityEngine;
using System.Collections;

public class ContactWithGround : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Snowflake")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Player")
        {
            other.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            GameObject background = GameObject.FindWithTag("Background");
            background.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        }
    }
}
