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

	// RVA: 0x7589D0 Offset: 0x756FD0 VA: 0x1807589D0
	public static GameManifest get_Current() { }

	// RVA: 0x7584D0 Offset: 0x756AD0 VA: 0x1807584D0
	public static void Load() { }

	// RVA: 0x758120 Offset: 0x756720 VA: 0x180758120
	public static void LoadAssets() { }

	// RVA: 0x7583B0 Offset: 0x7569B0 VA: 0x1807583B0
	internal static Dictionary<string, string[]> LoadEffectDictionary() { }

	// RVA: 0x7579F0 Offset: 0x755FF0 VA: 0x1807579F0
	internal static string GUIDToPath(string guid) { }

	// RVA: 0x7576F0 Offset: 0x755CF0 VA: 0x1807576F0
	internal static Object GUIDToObject(string guid) { }

	// RVA: 0x757F80 Offset: 0x756580 VA: 0x180757F80
	internal static void Invalidate(string path) { }

	// RVA: 0x757C80 Offset: 0x756280 VA: 0x180757C80
	private static string GetMetadataStatus() { }

	// RVA: 0x757B20 Offset: 0x756120 VA: 0x180757B20
	private static string GetAssetStatus() { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

	// RVA: 0x758870 Offset: 0x756E70 VA: 0x180758870
	private static void .cctor() { }

}

public struct GameManifest.PooledString // TypeDefIndex: 10725
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string str; // 0x0
	public uint hash; // 0x8

}

public class GameManifest.PrefabProperties // TypeDefIndex: 10726
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string folder; // 0x10
	public List<string> prefabs; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class GameManifest.GuidPath // TypeDefIndex: 10728
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string name; // 0x10
	public string guid; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

