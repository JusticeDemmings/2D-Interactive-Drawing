// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.ClearBackground(255, 255, 255);
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Clear Screen
            Window.ClearBackground(255, 255, 255);
            if (Input.IsKeyboardKeyDown(KeyboardKey.W) == true)
            {
                // If it is, then:
                Window.ClearBackground(255, 0, 0);
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.A) == true)
            {
                // If it is, then:
                Window.ClearBackground(0, 255, 0);
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.D) == true)
            {
                //If it is, then:
                Window.ClearBackground(255, 255, 0);
            }

            // Make the chameleon
            // Head
            Draw.SetLineSize(1);
            Draw.SetLineColor(0, 0, 0, 0);
            Draw.SetFillColor(Input.GetMouseX(), Input.GetMouseY(), 0);
            Draw.Rectangle(310, 150, 10, 30);
            Draw.Rectangle(300, 130, 10, 70);
            Draw.Rectangle(290, 120, 10, 90);
            Draw.Rectangle(280, 110, 10, 100);
            Draw.Rectangle(270, 100, 10, 110);
            Draw.Rectangle(260, 110, 10, 100);
            Draw.Rectangle(250, 160, 10, 30);
            Draw.Square(250, 200, 10);

            // Body
            Draw.Rectangle(240, 150, 10, 40);
            Draw.Rectangle(230, 140, 10, 60);
            Draw.Rectangle(220, 130, 10, 70);
            Draw.Rectangle(200, 120, 20, 80);
            Draw.Rectangle(140, 110, 60, 90);
            Draw.Rectangle(120, 120, 20, 80);
            Draw.Rectangle(110, 130, 10, 70);
            Draw.Rectangle(100, 140, 10, 60);
            Draw.Rectangle(90, 150, 10, 50);
            Draw.Rectangle(80, 160, 10, 70);
            Draw.Rectangle(70, 180, 10, 50);
            Draw.Rectangle(60, 190, 10, 40);
            Draw.Rectangle(60, 230, 60, 50);

            // Legs
            Draw.Rectangle(160, 200, 10, 30);
            Draw.Rectangle(140, 220, 20, 10);
            Draw.Square(170, 220, 10);
            Draw.Rectangle(200, 200, 10, 30);
            Draw.Rectangle(210, 220, 20, 10);
            Draw.Square(190, 220, 10);

            // Tail Swirl
            Draw.SetFillColor(0, 0, 0);
            Draw.SetLineSize(1);
            Draw.Rectangle(70, 240, 50, 3);
            Draw.Rectangle(70, 240, 3, 30);
            Draw.Rectangle(70, 270, 30, 3);
            Draw.Rectangle(97, 250, 3, 20);
            Draw.Rectangle(80, 250, 20, 3);
            Draw.Rectangle(80, 250, 3, 10);
            Draw.Rectangle(80, 260, 10, 3);

            // Eye
            Draw.SetFillColor(0, 0, 0);
            Draw.SetLineSize(1);
            Draw.Square(280, 140, 20);

            // Pupil
            Draw.SetFillColor(255, 255, 255);
            Draw.SetLineSize(1);
            Draw.Square(280, 140, 10);

            // Mouth
            Draw.SetFillColor(0, 0, 0);
            Draw.SetLineSize(1);
            Draw.Rectangle(280, 180, 30, 3);
        }
    }

}
