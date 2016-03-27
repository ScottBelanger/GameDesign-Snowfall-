using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class SideSwitcher : MonoBehaviour {

    public Boundary boundary;

    void FixedUpdate()
    {
        if (GetComponent<Rigidbody2D>().position.x < boundary.xMin)
        {
            GetComponent<Rigidbody2D>().position = new Vector2(boundary.xMax, transform.position.y);
        }
        if (GetComponent<Rigidbody2D>().position.x > boundary.xMax)
        {
            GetComponent<Rigidbody2D>().position = new Vector2(boundary.xMin, transform.position.y);
        }
    }
}
