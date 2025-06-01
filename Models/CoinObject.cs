using Silk.NET.Maths;

namespace TheAdventure.Models;

public class CoinObject : RenderableGameObject
{
    public bool Collected { get; set; }

    public CoinObject(SpriteSheet spriteSheet, (int X, int Y) position)
        : base(spriteSheet, position)
    {
        Collected = false;
        spriteSheet.ActivateAnimation("Idle");
    }

    public bool CheckCollision((int X, int Y) playerPosition, int threshold = 32)
    {
        var deltaX = Math.Abs(playerPosition.X - Position.X);
        var deltaY = Math.Abs(playerPosition.Y - Position.Y);
        return deltaX < threshold && deltaY < threshold;
    }

    public override void Render(GameRenderer renderer)
    {
        if (!Collected)
        {
            base.Render(renderer);
        }
    }
}
