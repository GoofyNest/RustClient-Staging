public class SpriteAtlasManager // TypeDefIndex: 3578
{	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<SpriteAtlas> atlasRegistered; // 0x8


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static bool RequestAtlas(string tag) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	internal static void Register(SpriteAtlas spriteAtlas) { }

	private static void .cctor() { }

}

