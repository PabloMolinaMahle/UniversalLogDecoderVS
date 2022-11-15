using System;
using System.Collections.Generic;

namespace DbcUtilities
{
    public class Database
    {
        public Dictionary<string, CanMessage> messageDict = new Dictionary<string, CanMessage>();
        //public List<Message> messageList = new List<Message>();

        private CanMessage currentMessage;

        public void ReadDatabase(string file)
        {
            // Read database file
            string[] lines = System.IO.File.ReadAllLines(file);

            // Process the lines
            foreach (string line in lines)
            {
                //Console.WriteLine("\t" + line);

                if (line.StartsWith("BO_ "))
                {
                    currentMessage = ReadMessageInfo(line);

                    //Console.WriteLine("\n");

                    //Console.WriteLine(currentMessage.ToString());

                    if (!messageDict.ContainsKey(currentMessage.MessageName))
                    {
                        messageDict.Add(currentMessage.MessageName, currentMessage);
                    }
                    else
                    {
                        //Console.WriteLine("Duplicated item");
                    }
                    
                }

                if (line.StartsWith(" SG_ "))
                {
                    var currentSignal = ReadSignalInfo(line);

                    //Console.WriteLine(currentSignal.ToString());

                    currentMessage.SignalDict.Add(currentSignal.SignalName, currentSignal);
                }


            }

            // if BO_ => new message and add it to database
            
            // while SG_ => new variable and add it to message
            // var currSignal = new Signal();
            // currMessage.SignalList.Add(currSignal);
        }

        private CanMessage ReadMessageInfo(string line)
        {
            var messageInfoArray = line.Split(' ');

            return new CanMessage(messageInfoArray[1], messageInfoArray[2], messageInfoArray[3], messageInfoArray[4]);
        }

        private Signal ReadSignalInfo(string line)
        {
            // SG_ <SignalName> [M|m<MultiplexerIdentifier>] : <StartBit>|<Length>@<Endianness><Signed> (<Factor>,<Offset>) [<Min>|<Max>] "[Unit]" [ReceivingNodes]

            var signalInfoArray = line.Split(' ');

            // Debug
            //foreach (var item in signalInfoArray)
            //{
            //    Console.WriteLine("\t" + item);
            //}

            // Name
            var signalName = signalInfoArray[2];

            //Console.WriteLine("\t" + "Name: " + signalName);

            // TODO mejorar como divide el string, usando string y sub string
            // Bit info
            var startBit = signalInfoArray[4].Split('|')[0];
            var bitLenght = signalInfoArray[4].Split('|')[1].Split('@')[0];
            var bitEndianness = signalInfoArray[4].Split('|')[1].Split('@')[1][0];
            var bitSigned = signalInfoArray[4].Split('|')[1].Split('@')[1][1];

            //Console.WriteLine("\t" + "Start: " + startBit + " lenght: " + bitLenght + " endianness: " + bitEndianness + " signed: " + bitSigned);

            // Gain/Ofset
            var signalGain = signalInfoArray[5].Remove(0, 1).Remove(signalInfoArray[5].Length - 2, 1).Split(',')[0];
            var signalOffset = signalInfoArray[5].Remove(0, 1).Remove(signalInfoArray[5].Length - 2, 1).Split(',')[1];

            // Min max
            var signalMin = signalInfoArray[6].Remove(0, 1).Remove(signalInfoArray[6].Length - 2, 1).Split('|')[0];
            var signalMax = signalInfoArray[6].Remove(0, 1).Remove(signalInfoArray[6].Length - 2, 1).Split('|')[1];

            // Units
            var signalUnits = signalInfoArray[7].Remove(0, 1).Remove(signalInfoArray[7].Length - 2, 1);

            // Receiving nodes
            // TODO Eliminar los espacios para coger los receiving nodes

            string[] signalReceivingNodes;

            if (signalInfoArray[8] != "")
            {
                signalReceivingNodes = signalInfoArray[8].Split(',');
            }
            else
            {
                signalReceivingNodes = signalInfoArray[9].Split(',');
            }
            
            //Console.WriteLine(" Signal nodes: ");

            //foreach (var item in signalReceivingNodes)
            //{
                //Console.WriteLine("     Nodes: " + item);
            //}

            return new Signal(signalName, currentMessage, Int32.Parse(startBit), Int32.Parse(bitLenght), bitEndianness, bitSigned.ToString(), float.Parse(signalGain), float.Parse(signalOffset), float.Parse(signalMin), float.Parse(signalMax), signalUnits, signalReceivingNodes);
        }

        public void ShowDatabase()
        {
            foreach (KeyValuePair<string, CanMessage> messageKPV in messageDict)
            {
                // Write message info
                Console.WriteLine(messageKPV.Value.ToString());

                // For each message signals
                foreach (KeyValuePair<string, Signal> signalKPV in messageKPV.Value.SignalDict)
                {
                    // Write signal info
                    Console.WriteLine(signalKPV.Value.ToString());
                }
            }
        }
    }
}

