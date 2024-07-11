using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

public struct Heart
{
	private Image heartImg = LoadImage("./heart1.png");

	public Texture2D Texture;
	public Vector2 Position;

	public Heart(Vector2 pos)
	{
		this.Position = pos;
		Texture = LoadTextureFromImage(heartImg);
	}
}
