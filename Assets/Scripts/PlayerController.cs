using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //For controlling with the keyboard
        //float moveHorizontal = Input.acceleration.x; //For tilt controls on phone

        Vector2 movement = new Vector2(moveHorizontal, 0.0f);
        GetComponent<Rigidbody2D>().velocity = movement * speed;
    }
}
