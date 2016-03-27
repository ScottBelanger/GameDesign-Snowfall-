using UnityEngine;
using System.Collections;

public class snowSpawnController : MonoBehaviour {

    public GameObject hazard;
    public Vector2 spawnValues;
    public float hazardCount;
    public float spawnWait;
    public float startWait;

    public float minHorizontalSpeed;
    public float maxHorizontalSpeed;
    public float minVerticalSpeed;
    public float maxVerticalSpeed;

    void Start()
    {
        StartCoroutine(spawnWaves());
    }

    IEnumerator spawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        for (int i = 0; i < hazardCount; i++)
        {
            Quaternion spawnRotation = Quaternion.identity;
            Vector2 spawnPosition = new Vector2((Random.Range(-spawnValues.x, spawnValues.x)), spawnValues.y);
            GameObject snowflake = (GameObject)Instantiate(hazard, spawnPosition, spawnRotation);
            snowflake.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minHorizontalSpeed, maxHorizontalSpeed), Random.Range(minVerticalSpeed, maxVerticalSpeed));
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
