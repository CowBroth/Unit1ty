using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlrDie : MonoBehaviour
{
    public bool hurt = false;
    public bool inv = false;
    public Vector2 k1;
    public Vector2 k2;
    float nemPos;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && !inv)
        {
            nemPos = collision.gameObject.transform.position.x;
            Knock();
            Hurt();
        }
        if (collision.gameObject.tag == "Enemy" && hurt)
        {
            hurt = false;
            Die();
        }
    }
    void Hurt()
    {
        print("Hurt");
        inv = true;
        StartCoroutine(Inv());
    }
    void Die()
    {
        print("Die");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Knock()
    {
        if (nemPos > gameObject.transform.position.x)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = k1;
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = k2;
        }
    }
    IEnumerator Inv()
    {
        yield return new WaitForSeconds(2.5f);
        inv = false;
        hurt = true;
    }
}
