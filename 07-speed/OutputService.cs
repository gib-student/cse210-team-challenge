using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    // displaying the actual window and texts
    //handles all the interaction with the draawing library
    class OutputService
    {
        private Raylib_cs.Color _backgroundColor = Raylib_cs.Color.WHITE;

        public OutputService()
        {

        }

         public void OpenWindow(int width, int height, string title, int frameRate)
        {
            Raylib.InitWindow(width, height, title);
            Raylib.SetTargetFPS(frameRate);
        }

        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        public void StartDrawing()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(_backgroundColor);
        }

        public void EndDrawing()
        {
            Raylib.EndDrawing();
        }
    }
}