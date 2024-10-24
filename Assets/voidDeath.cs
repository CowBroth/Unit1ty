using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class voidDeath : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Death();
        }
    }
    void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
