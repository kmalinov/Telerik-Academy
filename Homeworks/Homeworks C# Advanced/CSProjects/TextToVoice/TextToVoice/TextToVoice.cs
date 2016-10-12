using System;
using System.Speech.Synthesis;
class TextToVoice
{

    static void Main(string[] args)
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        synthesizer.Volume = 100;  // 0...100
        synthesizer.Rate = -2;     // -10...10

        // Synchronous
        synthesizer.Speak(Console.ReadLine());

    }
}