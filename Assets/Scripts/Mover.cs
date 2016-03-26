using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float horizontalSpeed;
    public float verticalSpeed;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalSpeed, verticalSpeed);
    }
}
