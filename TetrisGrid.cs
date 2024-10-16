using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TetrisTemplate;

/// <summary>
/// A class for representing the Tetris playing grid.
/// </summary>
class TetrisGrid
{
    /// The sprite of a single empty cell in the grid.
    Texture2D emptyCell;

    SpriteBatch spriteBatch;

    /// The position at which this TetrisGrid should be drawn.
    Vector2 position;
    Vector2 cellPos;

    /// The number of grid elements in the x-direction.
    public int Width { get { return 10; } }

    /// The number of grid elements in the y-direction.
    public int Height { get { return 20; } }

    Color[,] colorArray = new Color[10, 20];

    /// <summary>
    /// Creates a new TetrisGrid.
    /// </summary>
    /// <param name="b"></param>
    public TetrisGrid()
    {
        emptyCell = TetrisGame.ContentManager.Load<Texture2D>("block");

        position = Vector2.Zero;
        Clear();
    }



    void Update(GameTime gameTime)
    {

    }

    /// <summary>
    /// Draws the grid on the screen.
    /// </summary>
    /// <param name="gameTime">An object with information about the time that has passed in the game.</param>
    /// <param name="spriteBatch">The SpriteBatch used for drawing sprites and text.</param>
    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();

        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Height; j++)
            {
                cellPos = new Vector2(emptyCell.Width * i, emptyCell.Height * j);
                spriteBatch.Draw(emptyCell, cellPos, Color.White);
            }
        }

        //spriteBatch.Draw(emptyCell, new Vector2(emptyCell.Width * 7, emptyCell.Height * 4), Color.Red);



        spriteBatch.End();
    }

    /// <summary>
    /// Clears the grid.
    /// </summary>
    public void Clear()
    {
    }
}
