using System;
using System.Collections.Generic;

namespace DbcUtilities
{
    public class CanMessage
    {
        public string MessageID { get; private set; }
        public string MessageName { get; private set; }
        public string MessageLenght { get; private set; }
        public string MessageSendingNode { get; private set; }

        public Dictionary<string, Signal> SignalDict { get; private set; }
        //public List<Signal> SignalList { get; private set; }

        public CanMessage(string messageNumber, string messageName, string messageLenght, string messageNode)
        {
            MessageID = messageNumber;
            MessageName = messageName;
            MessageLenght = messageLenght;
            MessageSendingNode = messageNode;

            SignalDict = new Dictionary<string, Signal>();
        }

        public CanMessage(CanMessage canMessage)
        {
            MessageID = canMessage.MessageID;
            MessageName = canMessage.MessageName;
            MessageLenght = canMessage.MessageLenght;
            MessageSendingNode = canMessage.MessageSendingNode;

            SignalDict = new Dictionary<string, Signal>();
        }

        public override string ToString()
        {
            return "Message => number(HEX): " + MessageID + " Name: " + MessageName + " Lenght: " + MessageLenght + " Node: " + MessageSendingNode;
        }
    }


} 

