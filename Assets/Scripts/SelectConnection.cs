using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectConnection : MonoBehaviour
{
    public Camera menuCam;
    public Camera gameCam;
    public Camera instruCam;
    public Camera connectCam;
    public Camera creditCam;
    //public Camera chatCam;
    public GameObject game;
    public GameObject menu;
    public GameObject instruc;
    public GameObject credit;

    //public GameObject serverSend;
    //public GameObject serverInput;
    //public GameObject serverClose;
    //public GameObject clientSend;
    //public GameObject clientInput;
    //public GameObject clientClose;

    public void Start()
    {
        menuCam.enabled = true;
        gameCam.enabled = false;
        instruCam.enabled = false;
        connectCam.enabled = false;
        creditCam.enabled = false;
        //chatCam.enabled = false;
        game.SetActive(false);
        menu.SetActive(true);
        instruc.SetActive(false);
        credit.SetActive(false);
        //serverSend.SetActive(false);
        //serverInput.SetActive(false);
        //serverClose.SetActive(false);
        //clientSend.SetActive(false);
        //clientInput.SetActive(false);
        //clientClose.SetActive(false);
    }

    public void Menu()
    {
        menuCam.enabled = true;
        gameCam.enabled = false;
        instruCam.enabled = false;
        connectCam.enabled = false;
        creditCam.enabled = false;
        //chatCam.enabled = false;
        game.SetActive(false);
        menu.SetActive(true);
        instruc.SetActive(false);
        credit.SetActive(false);
    }

    public void Connection()
    {
        menuCam.enabled = false;
        gameCam.enabled = false;
        instruCam.enabled = false;
        connectCam.enabled = true;
        creditCam.enabled = false;
        //chatCam.enabled = false;
        game.SetActive(false);
        menu.SetActive(false);
        instruc.SetActive(false);
        credit.SetActive(false);
    }

    public void Game()
    {
        menuCam.enabled = false;
        gameCam.enabled = true;
        instruCam.enabled = false;
        connectCam.enabled = false;
        creditCam.enabled = false;
        //chatCam.enabled = false;
        game.SetActive(true);
        menu.SetActive(false);
        instruc.SetActive(false);
        credit.SetActive(false);
    }

    public void Instruction()
    {
        menuCam.enabled = false;
        gameCam.enabled = false;
        instruCam.enabled = true;
        connectCam.enabled = false;
        creditCam.enabled = false;
        //chatCam.enabled = false;
        game.SetActive(false);
        menu.SetActive(false);
        instruc.SetActive(true);
        credit.SetActive(false);
    }

    public void Credits()
    {
        menuCam.enabled = false;
        gameCam.enabled = false;
        instruCam.enabled = false;
        connectCam.enabled = false;
        creditCam.enabled = true;
        //chatCam.enabled = false;
        game.SetActive(false);
        menu.SetActive(false);
        instruc.SetActive(false);
        credit.SetActive(true);
    }

    // public void ChatServer()
    //{
    //    menuCam.enabled = false;
    //    gameCam.enabled = false;
    //    instruCam.enabled = false;
    //    connectCam.enabled = false;
    //    chatCam.enabled = true;
    //    game.SetActive(false);
    //    menu.SetActive(false);
    //    instruc.SetActive(true);
    //    serverSend.SetActive(true);
    //    serverInput.SetActive(true);
    //    serverClose.SetActive(true);
    //    clientSend.SetActive(false);
    //    clientInput.SetActive(false);
    //     clientClose.SetActive(false);
    //}
    //public void ChatClient()
    //{
    //    menuCam.enabled = false;
    //    gameCam.enabled = false;
    //    instruCam.enabled = false;
    //    connectCam.enabled = false;
    //    chatCam.enabled = true;
    //    game.SetActive(false);
    //    menu.SetActive(false);
    //    instruc.SetActive(true);
    //    serverSend.SetActive(false);
    //    serverInput.SetActive(false);
    //    serverClose.SetActive(false);
    //    clientSend.SetActive(true);
    //    clientInput.SetActive(true);
    //    clientClose.SetActive(true);
    //}

    public void ExitApp()
    {
        Application.Quit();
    }
}
