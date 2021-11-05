using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    // displaying the actual window and texts
    //handles all the interaction with the draawing library
    class OutputService
    {
        private Raylib_cs.Color _backgroundColor = Raylib_cs.Color.BLACK;

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
        public void DrawText(int x, int y, string text, bool whiteText)
        {
            Raylib_cs.Color color = Raylib_cs.Color.BLACK;

            if (whiteText)
            {
                color = Raylib_cs.Color.WHITE;
            }

            Raylib.DrawText(text,
                x ,
                y ,
                Constant.DEFAULT_FONT_SIZE,
                color);
        }

        public void DrawActor(Actor actor)
        {
            int x = actor.GetX();
            int y = actor.GetY();

            bool whiteText = true;

            if (actor.HasText())
            {
                string text = actor.GetText();
                DrawText(x, y, text, whiteText);
            }
        }

        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }
    }
}