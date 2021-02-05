using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;

namespace ServerChat
{
    public class ChatinServer : MonoBehaviour
    {
        private WebSocket websocket;
        public GameObject gochat;
        public InputField IP;
        public InputField Port;
        public GameObject chatUI;
        public Text chatText;
        public Text chatText2;
        public InputField inputField;
        
        
        
        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void BottonSend()
        {
            chatText.text += "Me :" +  inputField.text + "\n";
            
            if (websocket.ReadyState == WebSocketState.Open)
            {
                websocket.Send(inputField.text);
            }

            inputField.text = string.Empty;
        }

    
        

        public void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            Debug.Log("Receive message:" + messageEventArgs.Data);
            chatText2.text += "friend :" + messageEventArgs.Data + "\n";
            
        }

        public void Gotochat()
        {
            websocket = new WebSocket($"ws://{IP.text}:{Port.text}/");
            websocket.OnMessage += OnMessage;
            websocket.Connect();
            gochat.SetActive(true);
        }
    }
}