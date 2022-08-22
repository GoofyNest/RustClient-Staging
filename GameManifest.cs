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

	// RVA: 0x758920 Offset: 0x756F20 VA: 0x180758920
	public static GameManifest get_Current() { }

	// RVA: 0x758420 Offset: 0x756A20 VA: 0x180758420
	public static void Load() { }

	// RVA: 0x758070 Offset: 0x756670 VA: 0x180758070
	public static void LoadAssets() { }

	// RVA: 0x758300 Offset: 0x756900 VA: 0x180758300
	internal static Dictionary<string, string[]> LoadEffectDictionary() { }

	// RVA: 0x757940 Offset: 0x755F40 VA: 0x180757940
	internal static string GUIDToPath(string guid) { }

	// RVA: 0x757640 Offset: 0x755C40 VA: 0x180757640
	internal static Object GUIDToObject(string guid) { }

	// RVA: 0x757ED0 Offset: 0x7564D0 VA: 0x180757ED0
	internal static void Invalidate(string path) { }

	// RVA: 0x757BD0 Offset: 0x7561D0 VA: 0x180757BD0
	private static string GetMetadataStatus() { }

	// RVA: 0x757A70 Offset: 0x756070 VA: 0x180757A70
	private static string GetAssetStatus() { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

	// RVA: 0x7587C0 Offset: 0x756DC0 VA: 0x1807587C0
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

