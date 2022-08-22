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

	// RVA: 0x2304F90 Offset: 0x2303590 VA: 0x182304F90
	public void .ctor() { }

	// RVA: 0x2304380 Offset: 0x2302980 VA: 0x182304380
	public MapData GetMap(string name) { }

	// RVA: 0x2303FE0 Offset: 0x23025E0 VA: 0x182303FE0
	public void AddMap(string name, byte[] data) { }

	// RVA: 0x2304640 Offset: 0x2302C40 VA: 0x182304640
	public IEnumerable<PrefabData> GetPrefabs(string category) { }

	// RVA: 0x23040F0 Offset: 0x23026F0 VA: 0x1823040F0
	public void AddPrefab(string category, uint id, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x2304580 Offset: 0x2302B80 VA: 0x182304580
	public IEnumerable<PathData> GetPaths(string name) { }

	// RVA: 0x2304480 Offset: 0x2302A80 VA: 0x182304480
	public PathData GetPath(string name) { }

	// RVA: 0x2304090 Offset: 0x2302690 VA: 0x182304090
	public void AddPath(PathData path) { }

	// RVA: 0x23042D0 Offset: 0x23028D0 VA: 0x1823042D0
	public void Clear() { }

	// RVA: 0x2304CA0 Offset: 0x23032A0 VA: 0x182304CA0
	public void Save(string fileName) { }

	// RVA: 0x23048A0 Offset: 0x2302EA0 VA: 0x1823048A0
	public void Load(string fileName) { }

	// RVA: 0x2304240 Offset: 0x2302840 VA: 0x182304240
	public void CalculateChecksum() { }

	// RVA: 0x2304700 Offset: 0x2302D00 VA: 0x182304700
	private string Hash() { }

	// RVA: 0x2304270 Offset: 0x2302870 VA: 0x182304270
	public int CalculateCount() { }

}

private sealed class WorldSerialization.<>c__DisplayClass13_0 // TypeDefIndex: 7788
{	// Fields
	public string category; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9910 Offset: 0x8D7F10 VA: 0x1808D9910
	internal bool <GetPrefabs>b__0(PrefabData p) { }

}

private sealed class WorldSerialization.<>c__DisplayClass15_0 // TypeDefIndex: 7789
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2303FB0 Offset: 0x23025B0 VA: 0x182303FB0
	internal bool <GetPaths>b__0(PathData p) { }

}

