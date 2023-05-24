using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Analytics;

public class ScoreManager : MonoBehaviour
{
    public int score { get; private set; }
    public int life { get; set; }

    public int state = 0;

    public int x;

    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI LifeText;
    //public TextMeshProUGUI AllyScore;
    //public TextMeshProUGUI FScore;

    public GameObject Generator;
    public GameObject GameOver;
    public GameObject Quit;
    //public GameObject Ally;
    //public GameObject FinalScore;

    // Update is called once per frame
    void Update()
    {
        //FScore.text = ScoreText.text;
        //ScoreText.text = "Score: " + score.ToString();
        x = int.Parse(LifeText.text);
        if (x <= 0)
        {
            Generator.SetActive(false);
            GameOver.SetActive(true);
            Quit.SetActive(true);
            //if (state == 1)
            //{
            //    FindObjectOfType<Client>().SendMessageToServer(score.ToString());
            //}
            //else if (state == 2)
            //{
            //    FindObjectOfType<Server>().SendMessageToClient(score.ToString());
            //}
            //Ally.SetActive(true);
            //FinalScore.SetActive(true);
            FindObjectOfType<Plane>().DestroyPlane();
        }
    }

    public void BulletDestroyed()
    {
        //Debug.Log(this.score);
        //this.score += score;
        //ScoreText.text = score.ToString();
        AddScore(score + 100);
    }

    public void PlaneDestroyed()
    {
        SubtractLife();
    }

    public void AddScore(int score)
    {
        this.score += score;
        ScoreText.text = "Score: " + score.ToString();
    }

    public void SubtractLife()
    {
        //this.life -= life;
        //LifeText.text = "Lives: " + life.ToString();
        //if (this.life == 0)
        //{
        //    Generator.SetActive(false);
        //    GameOver.SetActive(true);
        //    FindObjectOfType<Plane>().DestroyPlane();
        //}

        life = int.Parse(LifeText.text) - 1;
        LifeText.text = life.ToString();
        if (state == 1)
        {
            FindObjectOfType<Client>().SendMessageToServer("damage");
        }else if (state == 2)
        {
            FindObjectOfType<Server>().SendMessageToClient("damage");
        }
        //FindObjectOfType<Client>().SendMessageToServer(life.ToString());
        //FindObjectOfType<Server>().SendMessageToClient(life.ToString());

        //if (life <= 0)
        //{
        //    Generator.SetActive(false);
        //    GameOver.SetActive(true);
        //    FindObjectOfType<Plane>().DestroyPlane();
        //}

    }

    public void State1()
    {
        state = 1;
    }

    public void State2()
    {
        state = 2;
    }

    public void ReceiveLifeValue()
    {
        life = int.Parse(LifeText.text) - 1;
        LifeText.text = life.ToString();
    }

    //public void ReceiveScore(string score)
    //{
    //    AllyScore.text = score;
    //}
}
