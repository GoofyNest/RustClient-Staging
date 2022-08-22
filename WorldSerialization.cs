public class WorldSerialization // TypeDefIndex: 7787
{	// Fields
	public const uint CurrentVersion = 9;
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <Version>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Checksum>k__BackingField; // 0x18
	public WorldData world; // 0x20

	// Properties
	public uint Version { get; set; }
	public string Checksum { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public uint get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_Version(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Checksum() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Checksum(string value) { }

	// RVA: 0x2304CD0 Offset: 0x23032D0 VA: 0x182304CD0
	public void .ctor() { }

	// RVA: 0x23040C0 Offset: 0x23026C0 VA: 0x1823040C0
	public MapData GetMap(string name) { }

	// RVA: 0x2303D20 Offset: 0x2302320 VA: 0x182303D20
	public void AddMap(string name, byte[] data) { }

	// RVA: 0x2304380 Offset: 0x2302980 VA: 0x182304380
	public IEnumerable<PrefabData> GetPrefabs(string category) { }

	// RVA: 0x2303E30 Offset: 0x2302430 VA: 0x182303E30
	public void AddPrefab(string category, uint id, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x23042C0 Offset: 0x23028C0 VA: 0x1823042C0
	public IEnumerable<PathData> GetPaths(string name) { }

	// RVA: 0x23041C0 Offset: 0x23027C0 VA: 0x1823041C0
	public PathData GetPath(string name) { }

	// RVA: 0x2303DD0 Offset: 0x23023D0 VA: 0x182303DD0
	public void AddPath(PathData path) { }

	// RVA: 0x2304010 Offset: 0x2302610 VA: 0x182304010
	public void Clear() { }

	// RVA: 0x23049E0 Offset: 0x2302FE0 VA: 0x1823049E0
	public void Save(string fileName) { }

	// RVA: 0x23045E0 Offset: 0x2302BE0 VA: 0x1823045E0
	public void Load(string fileName) { }

	// RVA: 0x2303F80 Offset: 0x2302580 VA: 0x182303F80
	public void CalculateChecksum() { }

	// RVA: 0x2304440 Offset: 0x2302A40 VA: 0x182304440
	private string Hash() { }

	// RVA: 0x2303FB0 Offset: 0x23025B0 VA: 0x182303FB0
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

	// RVA: 0x2303CF0 Offset: 0x23022F0 VA: 0x182303CF0
	internal bool <GetPaths>b__0(PathData p) { }

}

