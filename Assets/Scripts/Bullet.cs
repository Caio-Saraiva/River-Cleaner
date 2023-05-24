using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30;

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision != null && collision.gameObject.CompareTag("Trash"))
        if(collision.gameObject.tag == "Trash")
        {
            //Debug.Log("lixo atingido");
            FindObjectOfType<ScoreManager>().BulletDestroyed();
        }
        Destroy(this.gameObject);
    }
}
