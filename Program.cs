using Raylib_cs;
using static Raylib_cs.Raylib;
using System.Numerics;

InitWindow(800, 450, "corazon");
Heart Heart = new Heart(new Vector2(-16, -16));

Camera2D Camera = new Camera2D(new Vector2(400, 225), new Vector2(0, 0), 0f, 1.0f);

string Narration = " this is my heart.\n its pretty small\n\n wanna see it closer? \n click on it.";
bool HeartClickedOn = false;
while (!WindowShouldClose())
{
	if (HeartClickedOn && Camera.Zoom <= 10)
		Camera.Zoom += 1 * GetFrameTime();

	if ((Camera.Offset + GetMousePosition()).X > Heart.Position.X + Camera.Offset.X && 
			GetMousePosition().X < (Heart.Position.X + Camera.Offset.X + 32))
	{
		if (GetMousePosition().Y > Heart.Position.Y + Camera.Offset.Y &&
				GetMousePosition().Y < (Heart.Position.Y + Camera.Offset.Y + 32))
		{
			if (IsMouseButtonPressed(MouseButton.Left))
				HeartClickedOn = true;
		}
	}

	BeginDrawing();
		BeginMode2D(Camera);
			ClearBackground(Color.Black);

			DrawText(Narration, -399, -225, 20, Color.RayWhite);
			DrawTextureV(Heart.Texture, Heart.Position, Color.White);
		EndMode2D();
	EndDrawing();
}

CloseWindow();
