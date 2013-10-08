﻿using System;
using System.IO;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace SampleSynthesis
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initialize a new instance of the SpeechSynthesizer.
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {

                // Configure the audio output.  Create the folder
                synth.SetOutputToWaveFile(@"D:\temp\test.wav",
                  new SpeechAudioFormatInfo(8000, AudioBitsPerSample.Eight, AudioChannel.Mono));

                // Create a SoundPlayer instance to play output audio file. 
                System.Media.SoundPlayer m_SoundPlayer =
                  new System.Media.SoundPlayer(@"D:\temp\test.wav");

                // Build a prompt.
                PromptBuilder builder = new PromptBuilder();
                builder.AppendText("thousand");

                // Speak the prompt.
                synth.Speak(builder);
                m_SoundPlayer.Play();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}