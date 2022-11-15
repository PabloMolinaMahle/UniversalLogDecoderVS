using System;

namespace DbcUtilities
{
    public class Signal
    {
        // SG_ <SignalName> [M|m<MultiplexerIdentifier>] : <StartBit>|<Length>@<Endianness><Signed> (<Factor>,<Offset>) [<Min>|<Max>] "[Unit]" [ReceivingNodes]

        public string SignalName { get; private set; }
        public CanMessage Message { get; private set; }
        public int SignalStartBitPos { get; private set; }
        public int SignalBitLenght { get; private set; }
        public int SignalBitEndianness { get; private set; }
        public string SignalBitSigned { get; private set; }
        public float SignalFactor { get; private set; }
        public float SignalOffset { get; private set; }
        public float SignalMinValue { get; private set; }
        public float SignalMaxValue { get; private set; }
        public string SignalUnit { get; private set; }
        public String[] SignalReceivingNodes { get; private set; }

        public Signal(string signalName, CanMessage message, int signalStartBitPos, int signalBitLenght,
            int signalBitEndianness, string signalBitSigned, float signalFactor,
            float signalOffset, float signalMinValue, float signalMaxValue, string signalUnit,
            string[] signalReceivingNodes)
        {
            SignalName = signalName;
            Message = message;
            SignalStartBitPos = signalStartBitPos;
            SignalBitLenght = signalBitLenght;
            SignalBitEndianness = signalBitEndianness;
            SignalBitSigned = signalBitSigned;
            SignalFactor = signalFactor;
            SignalOffset = signalOffset;
            SignalMinValue = signalMinValue;
            SignalMaxValue = signalMaxValue;
            SignalUnit = signalUnit;
            SignalReceivingNodes = signalReceivingNodes;
        }

        public Signal(Signal signal)
        {
            SignalName = signal.SignalName;
            Message = signal.Message;
            SignalStartBitPos = signal.SignalStartBitPos;
            SignalBitLenght = signal.SignalBitLenght;
            SignalBitEndianness = signal.SignalBitEndianness;
            SignalBitSigned = signal.SignalBitSigned;
            SignalFactor = signal.SignalFactor;
            SignalOffset = signal.SignalOffset;
            SignalMinValue = signal.SignalMinValue;
            SignalMaxValue = signal.SignalMaxValue;
            SignalUnit = signal.SignalUnit;
            SignalReceivingNodes = signal.SignalReceivingNodes;
        }

        public override string ToString()
        {
            return "   Signal name: " + SignalName + " message ID: " + Message.MessageID + " | Start bit: " + SignalStartBitPos + " Lenght: " + SignalBitLenght +
                " Endianness: " + SignalBitEndianness + " Sign: " + SignalBitSigned +
                " | Factor: " + SignalFactor + " Offset: " + SignalOffset + " Min: " + SignalMinValue + " Max: " + SignalMaxValue +
                " | Units: " + SignalUnit + " Receiving nodes: " + ReceivingNodesToString(SignalReceivingNodes);
        }

        private string ReceivingNodesToString(string[] strArray)
        {
            string result = "";

            bool isFirst = true;

            foreach (var item in strArray)
            {
                if (!isFirst)
                {
                    result += ", ";
                }

                result += item;

                isFirst = false;
            }

            return result;
        }
    }
}

