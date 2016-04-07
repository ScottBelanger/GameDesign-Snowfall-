using UnityEngine;
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
            Destroy(other.gameObject);
            transform.localScale += new Vector3(0.1F, 0.1F, 0);
            score = score + 10;
            text.text = "Score: " + score;
        }
        if (other.tag == "Raindrop")
        {
            Destroy(other.gameObject);
            StartCoroutine(fallFaster());

        }
        if (other.tag == "Hail")
        {
            score = score - 50;
            Destroy(other.gameObject);
            for (int i=0; i<5; i++)
            {
                if (score >= 0)
                {
                    break;
                }
                transform.localScale -= new Vector3(0.1F, 0.1F, 0);
            }
        }
    }

    IEnumerator fallFaster()
    {
        GameObject ground = GameObject.FindWithTag("Ground");
        float groundHorizantalSpeed = ground.GetComponent<Rigidbody2D>().velocity.y;
        ground.GetComponent<Rigidbody2D>().velocity = new Vector2(0, groundHorizantalSpeed + 3);

        GameObject background = GameObject.FindWithTag("Background");
        float backgroundHorizantalSpeed = background.GetComponent<Rigidbody2D>().velocity.y;
        background.GetComponent<Rigidbody2D>().velocity = new Vector2(0, backgroundHorizantalSpeed + 3);

        /*GameObject[] snowflakes = GameObject.FindGameObjectsWithTag("Snowflake");
        foreach(GameObject snowflake in snowflakes)
        {
            float snowflakeHorizantalSpeed = snowflake.GetComponent<Rigidbody2D>().velocity.y;
            snowflake.GetComponent<Rigidbody2D>().velocity = new Vector2(0, snowflakeHorizantalSpeed + 3);
        }

        GameObject[] raindrops = GameObject.FindGameObjectsWithTag("Raindrop");
        foreach (GameObject raindrop in raindrops)
        {
            float raindropHorizantalSpeed = raindrop.GetComponent<Rigidbody2D>().velocity.y;
            raindrop.GetComponent<Rigidbody2D>().velocity = new Vector2(0, raindropHorizantalSpeed + 3);
        }*/

        yield return new WaitForSeconds(1);
        ground.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1); //1 is hardcoded. For now...
        background.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1); ; //1 is hardcoded. For now...
    }

    public static float getScore()
    {
        return score;
    }
}