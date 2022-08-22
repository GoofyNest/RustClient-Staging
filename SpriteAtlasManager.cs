public class SpriteAtlasManager // TypeDefIndex: 3578
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217A330 Offset: 0x2178930 VA: 0x18217A330
	private static bool RequestAtlas(string tag) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217A490 Offset: 0x2178A90 VA: 0x18217A490
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217A590 Offset: 0x2178B90 VA: 0x18217A590
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217A270 Offset: 0x2178870 VA: 0x18217A270
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x217A2F0 Offset: 0x21788F0 VA: 0x18217A2F0
	internal static void Register(SpriteAtlas spriteAtlas) { }

	// RVA: 0x217A430 Offset: 0x2178A30 VA: 0x18217A430
	private static void .cctor() { }

}

