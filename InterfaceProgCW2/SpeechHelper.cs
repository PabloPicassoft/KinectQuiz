using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceProgCW2
{
    class SpeechHelper
    {
        private KinectSensorChooser sensorChooser;
        private SpeechRecognitionEngine sre;
        private Thread audioThread;
        private KinectSensor sensor;


        public SpeechHelper()
        {

        }

        public void SetKinectSensorChooser(KinectSensorChooser newKinectSensorChooser)
        {
            this.sensorChooser = newKinectSensorChooser;
        }

        public void SetSRE(SpeechRecognitionEngine newSRE)
        {
            this.sre = newSRE;
        }

        public void SetAudioThread(Thread newAudioThread)
        {
            this.audioThread = newAudioThread;
        }

        public void SetKinectSensor(KinectSensor newKinectSensor)
        {
            this.sensor = newKinectSensor;
        }


        public KinectSensorChooser GetKinectSensorChooser()
        {
            return sensorChooser;
        }

        public SpeechRecognitionEngine GetSRE()
        {
            return sre;
        }

        public Thread GetAudioThread()
        {
            return audioThread;
        }

        public KinectSensor GetKinectSensor()
        {
            return sensor;
        }
    }
}
