using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    /// What is the purpose of this class?
    class InputService
    {
        
    }
     public string GetLetter()
    {
        int KeyInt = Raylib.GetKeyPressed();

        {int KeyString  = "";

            if (KeyInt  != 0)
            {
                if ((Raylib_cs.KeyboardKey)keyInt == Raylib_cs.KeyboardKey.KEY_ENTER)
                {
                    keyString = "/n";
                }
                else
                {
                    char keyChar = (char)KeyInt;
                    keyString = keyChar.ToString().ToLower();
                }
            }
            return KeyString;
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
