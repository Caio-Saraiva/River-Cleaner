using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System;
using TMPro;
using UnityEngine.UIElements;

public class GetIP : MonoBehaviour
{

    public TextMeshProUGUI displayIp;
    //public TextMeshProUGUI displayHostName;
    //public TextMeshProUGUI displayAddressList;
    //public TMP_InputField x;
    // Update is called once per frame
    void Update()
    {
        string hostName = Dns.GetHostName();
        int listSize = Dns.GetHostEntry(hostName).AddressList.Length - 1;
        //string IP = Dns.GetHostEntry(hostName).AddressList[int.Parse(x.text.ToString())].ToString();
        string IP = Dns.GetHostEntry(hostName).AddressList[listSize].ToString();

        displayIp.text = IP;
        //displayHostName.text = hostName;
        //displayAddressList.text = listSize.ToString();

    }
}
