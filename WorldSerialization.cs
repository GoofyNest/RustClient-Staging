public class WorldSerialization // TypeDefIndex: 7787
{	// Fields
	public const uint CurrentVersion = 9;
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private uint <Version>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Checksum>k__BackingField; // 0x18
	public WorldData world; // 0x20

	// Properties
	public uint Version { get; set; }
	public string Checksum { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public uint get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_Version(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Checksum() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Checksum(string value) { }

	// RVA: 0x2304E90 Offset: 0x2303490 VA: 0x182304E90
	public void .ctor() { }

	// RVA: 0x2304280 Offset: 0x2302880 VA: 0x182304280
	public MapData GetMap(string name) { }

	// RVA: 0x2303EE0 Offset: 0x23024E0 VA: 0x182303EE0
	public void AddMap(string name, byte[] data) { }

	// RVA: 0x2304540 Offset: 0x2302B40 VA: 0x182304540
	public IEnumerable<PrefabData> GetPrefabs(string category) { }

	// RVA: 0x2303FF0 Offset: 0x23025F0 VA: 0x182303FF0
	public void AddPrefab(string category, uint id, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x2304480 Offset: 0x2302A80 VA: 0x182304480
	public IEnumerable<PathData> GetPaths(string name) { }

	// RVA: 0x2304380 Offset: 0x2302980 VA: 0x182304380
	public PathData GetPath(string name) { }

	// RVA: 0x2303F90 Offset: 0x2302590 VA: 0x182303F90
	public void AddPath(PathData path) { }

	// RVA: 0x23041D0 Offset: 0x23027D0 VA: 0x1823041D0
	public void Clear() { }

	// RVA: 0x2304BA0 Offset: 0x23031A0 VA: 0x182304BA0
	public void Save(string fileName) { }

	// RVA: 0x23047A0 Offset: 0x2302DA0 VA: 0x1823047A0
	public void Load(string fileName) { }

	// RVA: 0x2304140 Offset: 0x2302740 VA: 0x182304140
	public void CalculateChecksum() { }

	// RVA: 0x2304600 Offset: 0x2302C00 VA: 0x182304600
	private string Hash() { }

	// RVA: 0x2304170 Offset: 0x2302770 VA: 0x182304170
	public int CalculateCount() { }

}

private sealed class WorldSerialization.<>c__DisplayClass13_0 // TypeDefIndex: 7788
{	// Fields
	public string category; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9800 Offset: 0x8D7E00 VA: 0x1808D9800
	internal bool <GetPrefabs>b__0(PrefabData p) { }

}

private sealed class WorldSerialization.<>c__DisplayClass15_0 // TypeDefIndex: 7789
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2303EB0 Offset: 0x23024B0 VA: 0x182303EB0
	internal bool <GetPaths>b__0(PathData p) { }

}

