﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace ShutdownTimer.Classes
{
    class UploadSpeedEvent : Event
    {
        private NetworkInterface _Interface { get; set; }
        private int _Sent { get; set; }
        private int _ToBeFor { get; set; }
        private int _Comparator { get; set; }
        private int _TrueFor { get; set; }
        private long _LastValue { get; set; }

        public UploadSpeedEvent(NetworkInterface inter, int sent, int seconds, int comp)
        {
            _Interface = inter;
            _Sent = sent;
            _ToBeFor = seconds;
            _Comparator = comp;
            _LastValue = inter.GetIPv4Statistics().BytesSent;
            _Name = "Upload Speed Usage Event";
        }

        public override bool Ready()
        {
            long bytesSent = _Interface.GetIPv4Statistics().BytesSent - _LastValue;
            this._LastValue = _Interface.GetIPv4Statistics().BytesSent;
            
            if (_Comparator < 0)
            {
                if (bytesSent < _Sent)
                    ++_TrueFor;
                else
                    _TrueFor = 0;
            }
            else if (_Comparator == 0)
            {
                if (bytesSent == _Sent)
                    ++_TrueFor;
                else
                    _TrueFor = 0;
            }
            else if (_Comparator > 0)
            {
                if (bytesSent > _Sent)
                    ++_TrueFor;
                else
                    _TrueFor = 0;
            }

            if (_TrueFor >= _ToBeFor)
                return _Ready = true;
            else
                return _Ready = false;
        }

        public override string DescribeFireDescription()
        {
            string c = "";
            if (_Comparator < 0)
                c = "below";
            else if (_Comparator == 0)
                c = "precisely";
            else if (_Comparator > 0)
                c = "above";
            return "Upload Speed is " + c + " " + _Sent / 1024 + "kB/s for at least " + _ToBeFor + " seconds";
        }
    }
}