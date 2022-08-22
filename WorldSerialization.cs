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
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	private void set_Version(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Checksum() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Checksum(string value) { }

	// RVA: 0x23057B0 Offset: 0x2303DB0 VA: 0x1823057B0
	public void .ctor() { }

	// RVA: 0x2304BA0 Offset: 0x23031A0 VA: 0x182304BA0
	public MapData GetMap(string name) { }

	// RVA: 0x2304800 Offset: 0x2302E00 VA: 0x182304800
	public void AddMap(string name, byte[] data) { }

	// RVA: 0x2304E60 Offset: 0x2303460 VA: 0x182304E60
	public IEnumerable<PrefabData> GetPrefabs(string category) { }

	// RVA: 0x2304910 Offset: 0x2302F10 VA: 0x182304910
	public void AddPrefab(string category, uint id, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x2304DA0 Offset: 0x23033A0 VA: 0x182304DA0
	public IEnumerable<PathData> GetPaths(string name) { }

	// RVA: 0x2304CA0 Offset: 0x23032A0 VA: 0x182304CA0
	public PathData GetPath(string name) { }

	// RVA: 0x23048B0 Offset: 0x2302EB0 VA: 0x1823048B0
	public void AddPath(PathData path) { }

	// RVA: 0x2304AF0 Offset: 0x23030F0 VA: 0x182304AF0
	public void Clear() { }

	// RVA: 0x23054C0 Offset: 0x2303AC0 VA: 0x1823054C0
	public void Save(string fileName) { }

	// RVA: 0x23050C0 Offset: 0x23036C0 VA: 0x1823050C0
	public void Load(string fileName) { }

	// RVA: 0x2304A60 Offset: 0x2303060 VA: 0x182304A60
	public void CalculateChecksum() { }

	// RVA: 0x2304F20 Offset: 0x2303520 VA: 0x182304F20
	private string Hash() { }

	// RVA: 0x2304A90 Offset: 0x2303090 VA: 0x182304A90
	public int CalculateCount() { }

}

private sealed class WorldSerialization.<>c__DisplayClass13_0 // TypeDefIndex: 7788
{	// Fields
	public string category; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9E20 Offset: 0x8D8420 VA: 0x1808D9E20
	internal bool <GetPrefabs>b__0(PrefabData p) { }

}

private sealed class WorldSerialization.<>c__DisplayClass15_0 // TypeDefIndex: 7789
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x23047D0 Offset: 0x2302DD0 VA: 0x1823047D0
	internal bool <GetPaths>b__0(PathData p) { }

}

