public enum Layer // TypeDefIndex: 6620
{	// Fields
	public int value__; // 0x0
	public const Layer Default = 0;
	public const Layer TransparentFX = 1;
	public const Layer Ignore_Raycast = 2;
	public const Layer Reserved1 = 3;
	public const Layer Water = 4;
	public const Layer UI = 5;
	public const Layer Reserved2 = 6;
	public const Layer Reserved3 = 7;
	public const Layer Deployed = 8;
	public const Layer Ragdoll = 9;
	public const Layer Invisible = 10;
	public const Layer AI = 11;
	public const Layer Player_Movement = 12;
	public const Layer Vehicle_Detailed = 13;
	public const Layer Game_Trace = 14;
	public const Layer Vehicle_World = 15;
	public const Layer World = 16;
	public const Layer Player_Server = 17;
	public const Layer Trigger = 18;
	public const Layer Player_Model_Rendering = 19;
	public const Layer Physics_Projectile = 20;
	public const Layer Construction = 21;
	public const Layer Construction_Socket = 22;
	public const Layer Terrain = 23;
	public const Layer Transparent = 24;
	public const Layer Clutter = 25;
	public const Layer Debris = 26;
	public const Layer Vehicle_Large = 27;
	public const Layer Prevent_Movement = 28;
	public const Layer Prevent_Building = 29;
	public const Layer Tree = 30;
	public const Layer Unused2 = 31;

}

public class Layer : ConsoleSystem // TypeDefIndex: 11940
{	// Methods

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x365030 Offset: 0x363630 VA: 0x180365030
	public static void show(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x364E10 Offset: 0x363410 VA: 0x180364E10
	public static void hide(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x365250 Offset: 0x363850 VA: 0x180365250
	public static void toggle(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x364C10 Offset: 0x363210 VA: 0x180364C10
	public static void culling(ConsoleSystem.Arg arg) { }

	// RVA: 0x364BB0 Offset: 0x3631B0 VA: 0x180364BB0
	public void .ctor() { }

}

