using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject Trash;

    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;

    //public GameObject trashObjs;

    RectTransform rtrans;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnObstacles");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnObstacles()
    {

        while (true)
        {

            float waitTime = Random.Range(0.5f, 1.5f);

            yield return new WaitForSeconds(waitTime);

            int trashPos = Random.Range(1, 11);
            switch (trashPos)
            {
                case 1:
                    Instantiate(Trash, pos1.position, Quaternion.identity, transform.parent);
                    break;
                case 2:
                    Instantiate(Trash, pos2.position, Quaternion.identity, transform.parent);
                    break;
                case 3:
                    Instantiate(Trash, pos3.position, Quaternion.identity, transform.parent);
                    break;
                case 4:
                    Instantiate(Trash, pos4.position, Quaternion.identity, transform.parent);
                    break;
                case 5:
                    Instantiate(Trash, pos1.position, Quaternion.identity, transform.parent);
                    Instantiate(Trash, pos2.position, Quaternion.identity, transform.parent);
                    break;
                case 6:
                    Instantiate(Trash, pos1.position, Quaternion.identity, transform.parent);
                    Instantiate(Trash, pos3.position, Quaternion.identity, transform.parent);
                    break;
                case 7:
                    Instantiate(Trash, pos1.position, Quaternion.identity, transform.parent);
                    Instantiate(Trash, pos4.position, Quaternion.identity, transform.parent);
                    break;
                case 8:
                    Instantiate(Trash, pos2.position, Quaternion.identity, transform.parent);
                    Instantiate(Trash, pos3.position, Quaternion.identity, transform.parent);
                    break;
                case 9:
                    Instantiate(Trash, pos2.position, Quaternion.identity, transform.parent);
                    Instantiate(Trash, pos4.position, Quaternion.identity, transform.parent);
                    break;
                case 10:
                    Instantiate(Trash, pos3.position, Quaternion.identity, transform.parent);
                    Instantiate(Trash, pos4.position, Quaternion.identity, transform.parent);
                    break;
                case 11:
                    Instantiate(Trash, pos1.position, Quaternion.identity, transform.parent);
                    Instantiate(Trash, pos2.position, Quaternion.identity, transform.parent);
                    Instantiate(Trash, pos3.position, Quaternion.identity, transform.parent);
                    Instantiate(Trash, pos4.position, Quaternion.identity, transform.parent);
                    break;

            }

        }

    }
}
