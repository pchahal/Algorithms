using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProgrammingPatterns
{
    public interface IAudio
    {
        void playSound(int soundID);
        void stopSound(int soundID);
        void stopAllSounds();
    }

    public class ConsoleAudio : IAudio
    {
        public void playSound(int soundID)
        {
            // Play sound using console audio api...
        }

        public void stopSound(int soundID)
        {
            // Stop sound using console audio api...
        }

        public void stopAllSounds()
        {
            // Stop all sounds using console audio api...
        }
    }

    public class LoggedAudio : IAudio
    {
        public LoggedAudio(IAudio wrapped)

        {
            wrapped_ = wrapped;
        }

        public void playSound(int soundID)
        {
            log("play sound");
            wrapped_.playSound(soundID);
        }

        public void stopSound(int soundID)
        {
            log("stop sound");
            wrapped_.stopSound(soundID);
        }

        public void stopAllSounds()
        {
            log("stop all sounds");
            wrapped_.stopAllSounds();
        }


        private void log(string message)
        {
            // Code to log message...
        }
        void enableAudioLogging()
        {
            // Decorate the existing service.
            IAudio service = new LoggedAudio(Locator.getAudio());

            // Swap it in.
            Locator.provide(service);
        }

        private IAudio wrapped_;
    };
    class NullAudio : IAudio
    {
        public void playSound(int soundID) { /* Do nothing. */ }
        public void stopSound(int soundID) { /* Do nothing. */ }
        public void stopAllSounds() { /* Do nothing. */ }
    };

    public class Locator
    {
        static public void initialize() { service_ = nullService; }
        static public IAudio getAudio() { return service_; }

        static public void provide(IAudio service)
        {
            if (service == null)
                service_ = nullService;
            else service_ = service;
        }

        private static IAudio service_;
        private static NullAudio nullService;
    };
}

