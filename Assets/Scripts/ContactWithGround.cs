using UnityEngine;
using System.Collections;

public class ContactWithGround : MonoBehaviour {

    public static bool level2;

    void OnTriggerEnter2D(Collider2D other)
    {
        level2 = false;
        if (other.tag != "Player")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Player")
        {
            other.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            GameObject background = GameObject.FindWithTag("Background");
            background.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;

            if(DestroyByContact.getScore() >= 100)
            {
                level2 = true;
                Application.LoadLevel("WorldOneSelectionScreen");
            }
        }
    }

    public static bool getLevel2()
    {
        return level2;
    }
}
