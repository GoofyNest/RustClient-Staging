public class BuildInfo // TypeDefIndex: 6169
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BuildInfo.ScmInfo <Scm>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BuildInfo.BuildDesc <Build>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Valid>k__BackingField; // 0x28
	private static BuildInfo _current; // 0x0

	// Properties
	public int Date { get; set; }
	[JsonIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public DateTime BuildDate { get; }
	public BuildInfo.ScmInfo Scm { get; set; }
	public BuildInfo.BuildDesc Build { get; set; }
	public bool Valid { get; set; }
	public static BuildInfo Current { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	public void set_Date(int value) { }

	// RVA: 0x14A9D60 Offset: 0x14A8360 VA: 0x1814A9D60
	public DateTime get_BuildDate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public BuildInfo.ScmInfo get_Scm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Scm(BuildInfo.ScmInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public BuildInfo.BuildDesc get_Build() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Build(BuildInfo.BuildDesc value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	public bool get_Valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x997AF0 Offset: 0x9960F0 VA: 0x180997AF0
	public void set_Valid(bool value) { }

	// RVA: 0x14A9EA0 Offset: 0x14A84A0 VA: 0x1814A9EA0
	public static BuildInfo get_Current() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BuildInfo.ScmInfo // TypeDefIndex: 6170
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <ChangeId>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Branch>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Repo>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Comment>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Author>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Date>k__BackingField; // 0x40

	// Properties
	public string Type { get; set; }
	public string ChangeId { get; set; }
	public string Branch { get; set; }
	public string Repo { get; set; }
	public string Comment { get; set; }
	public string Author { get; set; }
	public string Date { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Type(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_ChangeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_ChangeId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Branch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Branch(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Repo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_Repo(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_Author() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_Author(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_Date(string value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BuildInfo.BuildDesc // TypeDefIndex: 6171
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Id>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Number>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Tag>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Url>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Node>k__BackingField; // 0x38

	// Properties
	public string Id { get; set; }
	public string Number { get; set; }
	public string Tag { get; set; }
	public string Url { get; set; }
	public string Name { get; set; }
	public string Node { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Id(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Number() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Number(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Tag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Tag(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_Url(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_Node() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_Node(string value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BuildingBlock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6303
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int model; // 0x14
	public int grade; // 0x18
	public bool beingDemolished; // 0x1C

	// Methods

	// RVA: 0x1F71DF0 Offset: 0x1F703F0 VA: 0x181F71DF0
	public static void ResetToPool(BuildingBlock instance) { }

	// RVA: 0x1F71E80 Offset: 0x1F70480 VA: 0x181F71E80
	public void ResetToPool() { }

	// RVA: 0x1F71B10 Offset: 0x1F70110 VA: 0x181F71B10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D69690 Offset: 0x1D67C90 VA: 0x181D69690
	public void CopyTo(BuildingBlock instance) { }

	// RVA: 0x1F70BE0 Offset: 0x1F6F1E0 VA: 0x181F70BE0
	public BuildingBlock Copy() { }

	// RVA: 0x1F71770 Offset: 0x1F6FD70 VA: 0x181F71770
	public static BuildingBlock Deserialize(Stream stream) { }

	// RVA: 0x1F70C60 Offset: 0x1F6F260 VA: 0x181F70C60
	public static BuildingBlock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F711C0 Offset: 0x1F6F7C0 VA: 0x181F711C0
	public static BuildingBlock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F714D0 Offset: 0x1F6FAD0 VA: 0x181F714D0
	public static BuildingBlock Deserialize(byte[] buffer) { }

	// RVA: 0x1F71C20 Offset: 0x1F70220 VA: 0x181F71C20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F723C0 Offset: 0x1F709C0 VA: 0x181F723C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F723E0 Offset: 0x1F709E0 VA: 0x181F723E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BuildingBlock previous) { }

	// RVA: 0x1F71DD0 Offset: 0x1F703D0 VA: 0x181F71DD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F71250 Offset: 0x1F6F850 VA: 0x181F71250
	public static BuildingBlock Deserialize(byte[] buffer, BuildingBlock instance, bool isDelta = False) { }

	// RVA: 0x1F71960 Offset: 0x1F6FF60 VA: 0x181F71960
	public static BuildingBlock Deserialize(Stream stream, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F70CE0 Offset: 0x1F6F2E0 VA: 0x181F70CE0
	public static BuildingBlock DeserializeLengthDelimited(Stream stream, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F70F60 Offset: 0x1F6F560 VA: 0x181F70F60
	public static BuildingBlock DeserializeLength(Stream stream, int length, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F71F10 Offset: 0x1F70510 VA: 0x181F71F10
	public static void SerializeDelta(Stream stream, BuildingBlock instance, BuildingBlock previous) { }

	// RVA: 0x1F72290 Offset: 0x1F70890 VA: 0x181F72290
	public static void Serialize(Stream stream, BuildingBlock instance) { }

	// RVA: 0x1F723B0 Offset: 0x1F709B0 VA: 0x181F723B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F723C0 Offset: 0x1F709C0 VA: 0x181F723C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F72180 Offset: 0x1F70780 VA: 0x181F72180
	public static byte[] SerializeToBytes(BuildingBlock instance) { }

	// RVA: 0x1F720D0 Offset: 0x1F706D0 VA: 0x181F720D0
	public static void SerializeLengthDelimited(Stream stream, BuildingBlock instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class BuildingPrivilege : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6310
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PlayerNameID> users; // 0x18
	public float upkeepPeriodMinutes; // 0x20
	public float costFraction; // 0x24
	public float protectedMinutes; // 0x28

	// Methods

	// RVA: 0x1F73C90 Offset: 0x1F72290 VA: 0x181F73C90
	public static void ResetToPool(BuildingPrivilege instance) { }

	// RVA: 0x1F73E80 Offset: 0x1F72480 VA: 0x181F73E80
	public void ResetToPool() { }

	// RVA: 0x1F73990 Offset: 0x1F71F90 VA: 0x181F73990 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F72400 Offset: 0x1F70A00 VA: 0x181F72400
	public void CopyTo(BuildingPrivilege instance) { }

	// RVA: 0x1F72540 Offset: 0x1F70B40 VA: 0x181F72540
	public BuildingPrivilege Copy() { }

	// RVA: 0x1F73180 Offset: 0x1F71780 VA: 0x181F73180
	public static BuildingPrivilege Deserialize(Stream stream) { }

	// RVA: 0x1F72A10 Offset: 0x1F71010 VA: 0x181F72A10
	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F72A90 Offset: 0x1F71090 VA: 0x181F72A90
	public static BuildingPrivilege DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F73670 Offset: 0x1F71C70 VA: 0x181F73670
	public static BuildingPrivilege Deserialize(byte[] buffer) { }

	// RVA: 0x1F73A10 Offset: 0x1F72010 VA: 0x181F73A10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F747D0 Offset: 0x1F72DD0 VA: 0x181F747D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F747F0 Offset: 0x1F72DF0 VA: 0x181F747F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BuildingPrivilege previous) { }

	// RVA: 0x1F73C70 Offset: 0x1F72270 VA: 0x181F73C70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F72E40 Offset: 0x1F71440 VA: 0x181F72E40
	public static BuildingPrivilege Deserialize(byte[] buffer, BuildingPrivilege instance, bool isDelta = False) { }

	// RVA: 0x1F73400 Offset: 0x1F71A00 VA: 0x181F73400
	public static BuildingPrivilege Deserialize(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F726D0 Offset: 0x1F70CD0 VA: 0x181F726D0
	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F72B20 Offset: 0x1F71120 VA: 0x181F72B20
	public static BuildingPrivilege DeserializeLength(Stream stream, int length, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F74070 Offset: 0x1F72670 VA: 0x181F74070
	public static void SerializeDelta(Stream stream, BuildingPrivilege instance, BuildingPrivilege previous) { }

	// RVA: 0x1F74540 Offset: 0x1F72B40 VA: 0x181F74540
	public static void Serialize(Stream stream, BuildingPrivilege instance) { }

	// RVA: 0x1F747C0 Offset: 0x1F72DC0 VA: 0x181F747C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F747D0 Offset: 0x1F72DD0 VA: 0x181F747D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F74430 Offset: 0x1F72A30 VA: 0x181F74430
	public static byte[] SerializeToBytes(BuildingPrivilege instance) { }

	// RVA: 0x1F74380 Offset: 0x1F72980 VA: 0x181F74380
	public static void SerializeLengthDelimited(Stream stream, BuildingPrivilege instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class BuildingPrivlidge : StorageContainer // TypeDefIndex: 8363
{	// Fields
	private Option __menuOption_Menu_MaxAuth; // 0x3D0
	private Option __menuOption_Menu_RotateVM; // 0x428
	private Option __menuOption_MenuAuthorize; // 0x480
	private Option __menuOption_MenuClearList; // 0x4D8
	private Option __menuOption_MenuDeauthorize; // 0x530
	private float cachedProtectedMinutes; // 0x588
	private float cachedUpkeepPeriodMinutes; // 0x58C
	private float cachedUpkeepCostFraction; // 0x590
	public List<PlayerNameID> authorizedPlayers; // 0x598
	public const BaseEntity.Flags Flag_MaxAuths = 2048;
	public List<ItemDefinition> allowedConstructionItems; // 0x5A0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6ECE60 Offset: 0x6EB460 VA: 0x1806ECE60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6EE4A0 Offset: 0x6ECAA0 VA: 0x1806EE4A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6EE1C0 Offset: 0x6EC7C0 VA: 0x1806EE1C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6ECE30 Offset: 0x6EB430 VA: 0x1806ECE30
	public float CalculateUpkeepPeriodMinutes() { }

	// RVA: 0x6ECE00 Offset: 0x6EB400 VA: 0x1806ECE00
	public float CalculateUpkeepCostFraction() { }

	// RVA: 0x6ECC60 Offset: 0x6EB260 VA: 0x1806ECC60
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts) { }

	// RVA: 0x6EDB90 Offset: 0x6EC190 VA: 0x1806EDB90
	public float GetProtectedMinutes(bool force = False) { }

	// RVA: 0x6EE2B0 Offset: 0x6EC8B0 VA: 0x1806EE2B0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x6EDC80 Offset: 0x6EC280 VA: 0x1806EDC80
	public bool IsAuthed(BasePlayer player) { }

	// RVA: 0x6EDBD0 Offset: 0x6EC1D0 VA: 0x1806EDBD0
	public bool IsAuthed(ulong userID) { }

	// RVA: 0x6ECC10 Offset: 0x6EB210 VA: 0x1806ECC10
	public bool AnyAuthed() { }

	// RVA: 0x6EDD40 Offset: 0x6EC340 VA: 0x1806EDD40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void BuildingDirty() { }

	[BaseEntity.Menu] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	[BaseEntity.Menu.Description] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	[BaseEntity.Menu.Icon] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_MaxAuth(BasePlayer player) { }

	// RVA: 0x6EE050 Offset: 0x6EC650 VA: 0x1806EE050
	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	[BaseEntity.Menu.Description] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	[BaseEntity.Menu.Icon] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	// RVA: 0x6EDEA0 Offset: 0x6EC4A0 VA: 0x1806EDEA0
	public void MenuAuthorize(BasePlayer player) { }

	// RVA: 0x6EDE60 Offset: 0x6EC460 VA: 0x1806EDE60
	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	[BaseEntity.Menu.Description] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	[BaseEntity.Menu.Icon] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	// RVA: 0x6EE010 Offset: 0x6EC610 VA: 0x1806EE010
	public void MenuDeauthorize(BasePlayer player) { }

	// RVA: 0x6EE000 Offset: 0x6EC600 VA: 0x1806EE000
	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	[BaseEntity.Menu.Description] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	[BaseEntity.Menu.Icon] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	// RVA: 0x6EDFC0 Offset: 0x6EC5C0 VA: 0x1806EDFC0
	public void MenuClearList(BasePlayer player) { }

	// RVA: 0x6EDEE0 Offset: 0x6EC4E0 VA: 0x1806EDEE0
	public bool MenuClearList_ShowIf(BasePlayer player) { }

	// RVA: 0x6EE310 Offset: 0x6EC910 VA: 0x1806EE310 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	[BaseEntity.Menu.Description] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	[BaseEntity.Menu.Icon] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	[BaseEntity.Menu.ShowIf] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	// RVA: 0x6EE180 Offset: 0x6EC780 VA: 0x1806EE180
	public void Menu_RotateVM(BasePlayer player) { }

	// RVA: 0x6EE0A0 Offset: 0x6EC6A0 VA: 0x1806EE0A0
	public bool Menu_RotateTC_ShowIf(BasePlayer player) { }

	// RVA: 0x6EDA30 Offset: 0x6EC030 VA: 0x1806EDA30 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x6EDBC0 Offset: 0x6EC1C0 VA: 0x1806EDBC0 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x6EE3E0 Offset: 0x6EC9E0 VA: 0x1806EE3E0
	public void .ctor() { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass20_0 // TypeDefIndex: 8364
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705980 Offset: 0x703F80 VA: 0x180705980
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass21_0 // TypeDefIndex: 8365
{	// Fields
	public ulong userID; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7059B0 Offset: 0x703FB0 VA: 0x1807059B0
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

public class BuildingBlock : StabilityEntity // TypeDefIndex: 8538
{	// Fields
	private bool forceSkinRefresh; // 0x268
	private int modelState; // 0x26C
	private int lastModelState; // 0x270
	public BuildingGrade.Enum grade; // 0x274
	private BuildingGrade.Enum lastGrade; // 0x278
	private ConstructionSkin currentSkin; // 0x280
	private DeferredAction skinChange; // 0x288
	private MeshRenderer placeholderRenderer; // 0x290
	private MeshCollider placeholderCollider; // 0x298
	private static Material HighlightMaterial; // 0x0
	public static BuildingBlock.UpdateSkinWorkQueue updateSkinQueueClient; // 0x8
	public bool CullBushes; // 0x2A0
	public Construction blockDefinition; // 0x2A8
	private static Vector3[] outsideLookupOffsets; // 0x10

	// Properties
	public ConstructionGrade currentGrade { get; }

	// Methods

	// RVA: 0x6EB210 Offset: 0x6E9810 VA: 0x1806EB210 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6E9140 Offset: 0x6E7740 VA: 0x1806E9140 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6EB720 Offset: 0x6E9D20 VA: 0x1806EB720 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x6E9590 Offset: 0x6E7B90 VA: 0x1806E9590
	public List<Option> GetBuildMenu(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6EB780 Offset: 0x6E9D80 VA: 0x1806EB780
	private void RefreshSkin(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6EBCB0 Offset: 0x6EA2B0 VA: 0x1806EBCB0 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x6E8B90 Offset: 0x6E7190 VA: 0x1806E8B90
	private bool CanDemolish(BasePlayer player) { }

	// RVA: 0x6EA970 Offset: 0x6E8F70 VA: 0x1806EA970
	private bool IsDemolishable() { }

	// RVA: 0x6E9F70 Offset: 0x6E8570 VA: 0x1806E9F70
	private bool HasDemolishPrivilege(BasePlayer player) { }

	// RVA: 0x6E9390 Offset: 0x6E7990 VA: 0x1806E9390
	private void Demolish(BasePlayer player) { }

	// RVA: 0x6E9220 Offset: 0x6E7820 VA: 0x1806E9220
	private void DemolishOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x6EBB70 Offset: 0x6EA170 VA: 0x1806EBB70
	public void SetConditionalModel(int state) { }

	// RVA: 0x6E9760 Offset: 0x6E7D60 VA: 0x1806E9760
	public bool GetConditionalModel(int index) { }

	// RVA: 0x6EC510 Offset: 0x6EAB10 VA: 0x1806EC510
	public ConstructionGrade get_currentGrade() { }

	// RVA: 0x6E9780 Offset: 0x6E7D80 VA: 0x1806E9780
	private ConstructionGrade GetGrade(BuildingGrade.Enum iGrade) { }

	// RVA: 0x6E8B60 Offset: 0x6E7160 VA: 0x1806E8B60
	private bool CanChangeToGrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x6EA130 Offset: 0x6E8730 VA: 0x1806EA130
	private bool HasUpgradePrivilege(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x6EAE50 Offset: 0x6E9450 VA: 0x1806EAE50
	private bool IsUpgradeBlocked() { }

	// RVA: 0x6E8990 Offset: 0x6E6F90 VA: 0x1806E8990
	private bool CanAffordUpgrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x6EBB80 Offset: 0x6EA180 VA: 0x1806EBB80
	public void SetGrade(BuildingGrade.Enum iGradeID) { }

	// RVA: 0x6EBD40 Offset: 0x6EA340 VA: 0x1806EBD40
	private void UpdateGrade() { }

	// RVA: 0x6EC130 Offset: 0x6EA730 VA: 0x1806EC130
	private void UpgradeToGrade(BuildingGrade.Enum i, BasePlayer player) { }

	// RVA: 0x6E9B20 Offset: 0x6E8120 VA: 0x1806E9B20
	private void GradeChangingOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x6EB170 Offset: 0x6E9770 VA: 0x1806EB170
	private bool NeedsSkinChange() { }

	// RVA: 0x6EBE60 Offset: 0x6EA460 VA: 0x1806EBE60
	public void UpdateSkin(bool force = False) { }

	// RVA: 0x6E93F0 Offset: 0x6E79F0 VA: 0x1806E93F0
	private void DestroySkin() { }

	// RVA: 0x6EBD80 Offset: 0x6EA380 VA: 0x1806EBD80
	private void UpdatePlaceholder(bool state) { }

	// RVA: 0x6E8FC0 Offset: 0x6E75C0 VA: 0x1806E8FC0
	private void ChangeSkin() { }

	// RVA: 0x6E8DA0 Offset: 0x6E73A0 VA: 0x1806E8DA0
	private void ChangeSkin(GameObjectRef prefab) { }

	// RVA: 0x6EBCA0 Offset: 0x6EA2A0 VA: 0x1806EBCA0 Slot: 127
	public override bool ShouldBlockProjectiles() { }

	// RVA: 0x6EB140 Offset: 0x6E9740 VA: 0x1806EB140 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x6E8960 Offset: 0x6E6F60 VA: 0x1806E8960 Slot: 137
	public override List<ItemAmount> BuildCost() { }

	// RVA: 0x6E94A0 Offset: 0x6E7AA0 VA: 0x1806E94A0
	public void DrawHighlight() { }

	// RVA: 0x6EA280 Offset: 0x6E8880 VA: 0x1806EA280
	public void Highlight(MeshRenderer renderer) { }

	// RVA: 0x6E8CF0 Offset: 0x6E72F0 VA: 0x1806E8CF0
	private bool CanRotate(BasePlayer player) { }

	// RVA: 0x6EAC80 Offset: 0x6E9280 VA: 0x1806EAC80
	private bool IsRotatable() { }

	// RVA: 0x6EACD0 Offset: 0x6E92D0 VA: 0x1806EACD0
	private bool IsRotationBlocked() { }

	// RVA: 0x6EA050 Offset: 0x6E8650 VA: 0x1806EA050
	private bool HasRotationPrivilege(BasePlayer player) { }

	// RVA: 0x6EBAC0 Offset: 0x6EA0C0 VA: 0x1806EBAC0
	private void Rotation(BasePlayer player) { }

	// RVA: 0x6EB880 Offset: 0x6E9E80 VA: 0x1806EB880
	private void RotationOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x6EAFD0 Offset: 0x6E95D0 VA: 0x1806EAFD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6EB810 Offset: 0x6E9E10 VA: 0x1806EB810 Slot: 27
	public override void ResetState() { }

	// RVA: 0x6EA8F0 Offset: 0x6E8EF0 VA: 0x1806EA8F0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x6EB6B0 Offset: 0x6E9CB0 VA: 0x1806EB6B0 Slot: 30
	public override void PostInitShared() { }

	// RVA: 0x6D3240 Offset: 0x6D1840 VA: 0x1806D3240 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x6E8D70 Offset: 0x6E7370 VA: 0x1806E8D70 Slot: 122
	public override string Categorize() { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x6EA9F0 Offset: 0x6E8FF0 VA: 0x1806EA9F0 Slot: 106
	public override bool IsOutside() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x6EC4F0 Offset: 0x6EAAF0 VA: 0x1806EC4F0
	public void .ctor() { }

	// RVA: 0x6EC1E0 Offset: 0x6EA7E0 VA: 0x1806EC1E0
	private static void .cctor() { }

}

public static class BuildingBlock.BlockFlags // TypeDefIndex: 8539
{	// Fields
	public const BaseEntity.Flags CanRotate = 128;
	public const BaseEntity.Flags CanDemolish = 256;

}

public class BuildingBlock.UpdateSkinWorkQueue : ObjectWorkQueue<BuildingBlock> // TypeDefIndex: 8540
{	// Methods

	// RVA: 0x705A90 Offset: 0x704090 VA: 0x180705A90 Slot: 6
	protected override void RunJob(BuildingBlock entity) { }

	// RVA: 0x705AD0 Offset: 0x7040D0 VA: 0x180705AD0 Slot: 5
	protected override bool ShouldAdd(BuildingBlock entity) { }

	// RVA: 0x705AE0 Offset: 0x7040E0 VA: 0x180705AE0
	public void .ctor() { }

}

private sealed class BuildingBlock.<>c__DisplayClass31_0 // TypeDefIndex: 8541
{	// Fields
	public BuildingGrade.Enum iNewGrade; // 0x10
	public BuildingBlock <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7059D0 Offset: 0x703FD0 VA: 0x1807059D0
	internal void <GradeChangingOptions>b__0(BasePlayer ply) { }

}

public class BuildingProximity : PrefabAttribute // TypeDefIndex: 9049
{	// Fields
	private const float check_radius = 2;
	private const float check_forgiveness = 0,01;
	private const float foundation_width = 3;
	private const float foundation_extents = 1,5;

	// Methods

	// RVA: 0x6EE720 Offset: 0x6ECD20 VA: 0x1806EE720
	public static bool Check(BasePlayer player, Construction construction, Vector3 position, Quaternion rotation) { }

	// RVA: 0x6EEF10 Offset: 0x6ED510 VA: 0x1806EEF10
	private static BuildingProximity.ProximityInfo GetProximity(Construction construction1, Vector3 position1, Quaternion rotation1, Construction construction2, Vector3 position2, Quaternion rotation2) { }

	// RVA: 0x6EF4A0 Offset: 0x6EDAA0 VA: 0x1806EF4A0
	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x6EEEB0 Offset: 0x6ED4B0 VA: 0x1806EEEB0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6EF5C0 Offset: 0x6EDBC0 VA: 0x1806EF5C0
	public void .ctor() { }

}

private struct BuildingProximity.ProximityInfo // TypeDefIndex: 9050
{	// Fields
	public bool hit; // 0x0
	public bool connection; // 0x1
	public Line line; // 0x4
	public float sqrDist; // 0x1C

}

public class BuildingBlockDecay : Decay // TypeDefIndex: 9526
{	// Methods

	// RVA: 0x6E8950 Offset: 0x6E6F50 VA: 0x1806E8950
	public void .ctor() { }

}

public class BuildingGradeDecay : Decay // TypeDefIndex: 9527
{	// Fields
	public BuildingGrade.Enum decayGrade; // 0x98

	// Methods

	// RVA: 0x6E8950 Offset: 0x6E6F50 VA: 0x1806E8950
	public void .ctor() { }

}

public abstract class BuildingManager // TypeDefIndex: 9826
{	// Fields
	public static ClientBuildingManager client; // 0x0
	protected ListHashSet<DecayEntity> decayEntities; // 0x10
	protected ListDictionary<uint, BuildingManager.Building> buildingDictionary; // 0x18

	// Methods

	// RVA: 0x6EC8B0 Offset: 0x6EAEB0 VA: 0x1806EC8B0
	public BuildingManager.Building GetBuilding(uint buildingID) { }

	// RVA: 0x6EC710 Offset: 0x6EAD10 VA: 0x1806EC710
	public void Add(DecayEntity ent) { }

	// RVA: 0x6EC920 Offset: 0x6EAF20 VA: 0x1806EC920
	public void Remove(DecayEntity ent) { }

	// RVA: 0x6EC860 Offset: 0x6EAE60 VA: 0x1806EC860
	public void Clear() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract BuildingManager.Building CreateBuilding(uint id);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void DisposeBuilding(ref BuildingManager.Building building);

	// RVA: 0x6ECB70 Offset: 0x6EB170 VA: 0x1806ECB70
	protected void .ctor() { }

	// RVA: 0x6ECB10 Offset: 0x6EB110 VA: 0x1806ECB10
	private static void .cctor() { }

}

public class BuildingManager.Building // TypeDefIndex: 9827
{	// Fields
	public uint ID; // 0x10
	public ListHashSet<BuildingPrivlidge> buildingPrivileges; // 0x18
	public ListHashSet<BuildingBlock> buildingBlocks; // 0x20
	public ListHashSet<DecayEntity> decayEntities; // 0x28
	public NavMeshObstacle buildingNavMeshObstacle; // 0x30
	public ListHashSet<NavMeshObstacle> navmeshCarvers; // 0x38
	public bool isNavMeshCarvingDirty; // 0x40
	public bool isNavMeshCarveOptimized; // 0x41

	// Methods

	// RVA: 0x6EFD00 Offset: 0x6EE300 VA: 0x1806EFD00
	public bool IsEmpty() { }

	// RVA: 0x6EFAE0 Offset: 0x6EE0E0 VA: 0x1806EFAE0
	public BuildingPrivlidge GetDominatingBuildingPrivilege() { }

	// RVA: 0x6EFC60 Offset: 0x6EE260 VA: 0x1806EFC60
	public bool HasBuildingPrivileges() { }

	// RVA: 0x6EFC10 Offset: 0x6EE210 VA: 0x1806EFC10
	public bool HasBuildingBlocks() { }

	// RVA: 0x6EFCB0 Offset: 0x6EE2B0 VA: 0x1806EFCB0
	public bool HasDecayEntities() { }

	// RVA: 0x6EF6C0 Offset: 0x6EDCC0 VA: 0x1806EF6C0
	public void AddBuildingPrivilege(BuildingPrivlidge ent) { }

	// RVA: 0x6EFE50 Offset: 0x6EE450 VA: 0x1806EFE50
	public void RemoveBuildingPrivilege(BuildingPrivlidge ent) { }

	// RVA: 0x6EF620 Offset: 0x6EDC20 VA: 0x1806EF620
	public void AddBuildingBlock(BuildingBlock ent) { }

	// RVA: 0x6EFDC0 Offset: 0x6EE3C0 VA: 0x1806EFDC0
	public void RemoveBuildingBlock(BuildingBlock ent) { }

	// RVA: 0x6EF760 Offset: 0x6EDD60 VA: 0x1806EF760
	public void AddDecayEntity(DecayEntity ent) { }

	// RVA: 0x6EFEE0 Offset: 0x6EE4E0 VA: 0x1806EFEE0
	public void RemoveDecayEntity(DecayEntity ent) { }

	// RVA: 0x6EF800 Offset: 0x6EDE00 VA: 0x1806EF800
	public void Add(DecayEntity ent) { }

	// RVA: 0x6EFF70 Offset: 0x6EE570 VA: 0x1806EFF70
	public void Remove(DecayEntity ent) { }

	// RVA: 0x6EFA60 Offset: 0x6EE060 VA: 0x1806EFA60
	public void Dirty() { }

	// RVA: 0x6F0170 Offset: 0x6EE770 VA: 0x1806F0170
	public void .ctor() { }

}

public class BuildingGrade : ScriptableObject // TypeDefIndex: 10717
{	// Fields
	public BuildingGrade.Enum type; // 0x18
	public float baseHealth; // 0x1C
	public List<ItemAmount> baseCost; // 0x20
	public PhysicMaterial physicMaterial; // 0x28
	public ProtectionProperties damageProtecton; // 0x30
	public BaseEntity.Menu.Option upgradeMenu; // 0x38

	// Methods

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public enum BuildingGrade.Enum // TypeDefIndex: 10718
{	// Fields
	public int value__; // 0x0
	public const BuildingGrade.Enum None = -1;
	public const BuildingGrade.Enum Twigs = 0;
	public const BuildingGrade.Enum Wood = 1;
	public const BuildingGrade.Enum Stone = 2;
	public const BuildingGrade.Enum Metal = 3;
	public const BuildingGrade.Enum TopTier = 4;
	public const BuildingGrade.Enum Count = 5;

}

