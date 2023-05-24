using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class Plane : MonoBehaviour
{
    public int LeftSpeed = -5;
    public int RightSpeed = 5;
    public TextMeshProUGUI Lives;
    //public TextMeshProUGUI Score;
    
    public GameObject Bullet;
    public Transform GunDirection;
    public void TurnLeft()
    {
        this.gameObject.transform.Translate(LeftSpeed, 0, 0);
    }

    public void TurnRight()
    {
        this.gameObject.transform.Translate(RightSpeed, 0, 0);
    }

    public void Fire()
    {
        Instantiate(Bullet, GunDirection.position, Quaternion.identity, transform.parent);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Plane Damaged!");
        FindObjectOfType<ScoreManager>().PlaneDestroyed();
    }

    public void DestroyPlane()
    {
        Destroy(this.gameObject);
    }
}