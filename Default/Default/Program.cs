using Microsoft.Xna.Framework;

namespace Default;

internal class FNAGame : Game
{
    [STAThread]
    static void Main(string[] args)
    {
        using var g = new FNAGame();
        g.Run();
    }
    
    private FNAGame()
    {
        var deviceManager = new GraphicsDeviceManager(this);
    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        base.Draw(gameTime);
    }
}