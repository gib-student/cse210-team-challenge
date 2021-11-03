using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    class InputService
    {
        
        public InputService()
        {

        }

        public string GetLetterPressed()
        {
            int keyInteger = Raylib.GetKeyPressed();
            int keyString  = int.Parse("");

            {
                if (keyInteger  != 0)
                {
                    if ((Raylib_cs.KeyboardKey)keyInteger == Raylib_cs.KeyboardKey.KEY_ENTER)
                    {
                        keyString = "/n";
                    }
                    else
                    {
                        char keyChar = (char)keyInteger;
                        keyString = keyChar.ToString().ToLower();
                    }
                }
                return keyString;
            }
        }

        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }
}

// for each word w in _words)
// {
//     if match)
//     {
//         wordtO rEMOVE.AD (W)

//     }

//     for (word remova_word in wordtoremove)
//     {
//         _remove.remove(removal_word)
//     }
// }
