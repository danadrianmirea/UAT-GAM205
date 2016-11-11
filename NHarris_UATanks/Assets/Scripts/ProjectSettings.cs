﻿/// <summary>
/// Static container for Project development settings or configurations.
/// </summary>
public static class ProjectSettings
{
    /// <summary>
    /// Static lookup for project defined object tags by name.
    /// </summary>
    public static class Tags
    {
        public const string BULLET = "Bullet";
        public const string PATROL_POINT = "PatrolPoint";
    }

    /// <summary>
    /// Project defined layer names and their backing ID.
    /// </summary>
    public enum Layers : int
    {
        Default = 0,
        Projectiles = 8,
        Player = 9,
        Enemy = 10,
        Floor = 11,
        Wall = 12,
        InvisiWall = 13,
        Powerup = 14,
        AIListener = 15,
        Door = 16
    }

    public enum Levels : int
    {
        MainMenu = 0,
        MainGameplay = 1
    }
}
