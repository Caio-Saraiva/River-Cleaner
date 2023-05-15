using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {       
       Destroy(this.gameObject); 
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
