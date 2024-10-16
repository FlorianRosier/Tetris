using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisTemplate
{
    class TetrisBlock
    {
        public bool[,] block = new bool[4, 4];

        Texture2D cell;
        Vector2 cellPos;
        Vector2 cellOffset = new Vector2(2, -1);

        KeyboardState currentState, previousState;

        public TetrisBlock()
        {
            block = Rectangle();

            cell = TetrisGame.ContentManager.Load<Texture2D>("block");
        }

        public void Update(GameTime gameTime)
        {
            previousState = currentState;
            currentState = Keyboard.GetState();

            if (currentState.IsKeyDown(Keys.Left) && previousState.IsKeyUp(Keys.Left))
                cellOffset.X--;
            else if (currentState.IsKeyDown(Keys.Right) && previousState.IsKeyUp(Keys.Right))
                cellOffset.X++;
            else if (currentState.IsKeyDown(Keys.Down) && previousState.IsKeyUp(Keys.Down))
                cellOffset.Y++;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            for (int i = 0; i < block.GetLength(0); i++)
            {
                for (int j = 0; j < block.GetLength(1); j++)
                {
                    if (block[i, j])
                    {
                        cellPos = new Vector2(cell.Width * (i + cellOffset.X), cell.Height * (j + cellOffset.Y));
                        spriteBatch.Draw(cell, cellPos, Color.Red);
                    }
                }
            }

            spriteBatch.End();
        }

        public bool[,] Square()
        {
            bool[,] squareArray = new bool[4, 4];

            squareArray[1, 1] = true;
            squareArray[1, 2] = true;
            squareArray[2, 1] = true;
            squareArray[2, 2] = true;

            return squareArray;
        }

        public bool[,] Rectangle()
        {
            bool[,] rectangleArray = new bool[4, 4];

            rectangleArray[1, 1] = true;
            rectangleArray[1, 2] = true;
            rectangleArray[1, 3] = true;
            rectangleArray[1, 0] = true;

            return rectangleArray;
        }

        public bool[,] S()
        {
            bool[,] sArray = new bool[4, 4];

            sArray[1, 2] = true;
            sArray[2, 2] = true;
            sArray[2, 1] = true;
            sArray[3, 1] = true;

            return sArray;
        }

        public bool[,] Z()
        {
            bool[,] zArray = new bool[4, 4];

            zArray[1, 1] = true;
            zArray[2, 2] = true;
            zArray[2, 1] = true;
            zArray[3, 2] = true;

            return zArray;
        }

        public bool[,] L()
        {
            bool[,] lArray = new bool[4, 4];

            lArray[1, 0] = true;
            lArray[1, 1] = true;
            lArray[1, 2] = true;
            lArray[2, 2] = true;

            return lArray;
        }

        public bool[,] J()
        {
            bool[,] jArray = new bool[4, 4];

            jArray[2, 0] = true;
            jArray[2, 1] = true;
            jArray[2, 2] = true;
            jArray[1, 2] = true;

            return jArray;
        }

        public bool[,] T()
        {
            bool[,] tArray = new bool[4, 4];

            tArray[1, 1] = true;
            tArray[2, 2] = true;
            tArray[2, 1] = true;
            tArray[3, 1] = true;

            return tArray;
        }
    }
}
