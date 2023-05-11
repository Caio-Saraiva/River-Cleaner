using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectConnection : MonoBehaviour
{
    public GameObject createScreen;
    public GameObject joinScreen;
    public GameObject selectScreen;

    public void CreateScreen()
    {
        createScreen.SetActive(true);
        selectScreen.SetActive(false);
    }

    public void JoinScreen()
    {
        joinScreen.SetActive(true);
        selectScreen.SetActive(false);
    }
}
