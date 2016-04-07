using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

    public float tumble;

    void Start()
    {
        //GetComponent<Rigidbody2D>().angularVelocity = Random.Range(0,1) * tumble;
        //transform.Rotate(0, 0, Random.Range(0, 360));
        GetComponent<Rigidbody2D>().angularVelocity = Random.value * tumble;
        //transform.position = Random.insideUnitCircle * tumble;
    }
}
