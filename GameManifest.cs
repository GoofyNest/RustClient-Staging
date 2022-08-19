public class GameManifest : ScriptableObject // TypeDefIndex: 10724
{	// Fields
	internal static GameManifest loadedManifest; // 0x0
	internal static Dictionary<string, string> guidToPath; // 0x8
	internal static Dictionary<string, string> pathToGuid; // 0x10
	internal static Dictionary<string, Object> guidToObject; // 0x18
	public GameManifest.PooledString[] pooledStrings; // 0x18
	public GameManifest.PrefabProperties[] prefabProperties; // 0x20
	public GameManifest.EffectCategory[] effectCategories; // 0x28
	public GameManifest.GuidPath[] guidPaths; // 0x30
	public string[] entities; // 0x38

	// Properties
	public static GameManifest Current { get; }

	// Methods

	// RVA: 0x7588C0 Offset: 0x756EC0 VA: 0x1807588C0
	public static GameManifest get_Current() { }

	// RVA: 0x7583C0 Offset: 0x7569C0 VA: 0x1807583C0
	public static void Load() { }

	// RVA: 0x758010 Offset: 0x756610 VA: 0x180758010
	public static void LoadAssets() { }

	// RVA: 0x7582A0 Offset: 0x7568A0 VA: 0x1807582A0
	internal static Dictionary<string, string[]> LoadEffectDictionary() { }

	// RVA: 0x7578E0 Offset: 0x755EE0 VA: 0x1807578E0
	internal static string GUIDToPath(string guid) { }

	// RVA: 0x7575E0 Offset: 0x755BE0 VA: 0x1807575E0
	internal static Object GUIDToObject(string guid) { }

	// RVA: 0x757E70 Offset: 0x756470 VA: 0x180757E70
	internal static void Invalidate(string path) { }

	// RVA: 0x757B70 Offset: 0x756170 VA: 0x180757B70
	private static string GetMetadataStatus() { }

	// RVA: 0x757A10 Offset: 0x756010 VA: 0x180757A10
	private static string GetAssetStatus() { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

	// RVA: 0x758760 Offset: 0x756D60 VA: 0x180758760
	private static void .cctor() { }

}

public struct GameManifest.PooledString // TypeDefIndex: 10725
{	// Fields
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public string str; // 0x0
	public uint hash; // 0x8

}

public class GameManifest.PrefabProperties // TypeDefIndex: 10726
{	// Fields
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public string name; // 0x10
	public string guid; // 0x18
	public uint hash; // 0x20
	public bool pool; // 0x24

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class GameManifest.EffectCategory // TypeDefIndex: 10727
{	// Fields
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public string folder; // 0x10
	public List<string> prefabs; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class GameManifest.GuidPath // TypeDefIndex: 10728
{	// Fields
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public string name; // 0x10
	public string guid; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

