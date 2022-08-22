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
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_Date(int value) { }

	// RVA: 0x14AAC90 Offset: 0x14A9290 VA: 0x1814AAC90
	public DateTime get_BuildDate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public BuildInfo.ScmInfo get_Scm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Scm(BuildInfo.ScmInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public BuildInfo.BuildDesc get_Build() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Build(BuildInfo.BuildDesc value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	public bool get_Valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x997600 Offset: 0x995C00 VA: 0x180997600
	public void set_Valid(bool value) { }

	// RVA: 0x14AADD0 Offset: 0x14A93D0 VA: 0x1814AADD0
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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Type(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_ChangeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ChangeId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Branch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Branch(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Repo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_Repo(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_Author() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_Author(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Id(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Number() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Number(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Tag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Tag(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_Url(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_Node() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
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

	// RVA: 0x1F715D0 Offset: 0x1F6FBD0 VA: 0x181F715D0
	public static void ResetToPool(BuildingBlock instance) { }

	// RVA: 0x1F71660 Offset: 0x1F6FC60 VA: 0x181F71660
	public void ResetToPool() { }

	// RVA: 0x1F712F0 Offset: 0x1F6F8F0 VA: 0x181F712F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68EA0 Offset: 0x1D674A0 VA: 0x181D68EA0
	public void CopyTo(BuildingBlock instance) { }

	// RVA: 0x1F703C0 Offset: 0x1F6E9C0 VA: 0x181F703C0
	public BuildingBlock Copy() { }

	// RVA: 0x1F70F50 Offset: 0x1F6F550 VA: 0x181F70F50
	public static BuildingBlock Deserialize(Stream stream) { }

	// RVA: 0x1F70440 Offset: 0x1F6EA40 VA: 0x181F70440
	public static BuildingBlock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F709A0 Offset: 0x1F6EFA0 VA: 0x181F709A0
	public static BuildingBlock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F70CB0 Offset: 0x1F6F2B0 VA: 0x181F70CB0
	public static BuildingBlock Deserialize(byte[] buffer) { }

	// RVA: 0x1F71400 Offset: 0x1F6FA00 VA: 0x181F71400
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F71BA0 Offset: 0x1F701A0 VA: 0x181F71BA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F71BC0 Offset: 0x1F701C0 VA: 0x181F71BC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BuildingBlock previous) { }

	// RVA: 0x1F715B0 Offset: 0x1F6FBB0 VA: 0x181F715B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F70A30 Offset: 0x1F6F030 VA: 0x181F70A30
	public static BuildingBlock Deserialize(byte[] buffer, BuildingBlock instance, bool isDelta = False) { }

	// RVA: 0x1F71140 Offset: 0x1F6F740 VA: 0x181F71140
	public static BuildingBlock Deserialize(Stream stream, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F704C0 Offset: 0x1F6EAC0 VA: 0x181F704C0
	public static BuildingBlock DeserializeLengthDelimited(Stream stream, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F70740 Offset: 0x1F6ED40 VA: 0x181F70740
	public static BuildingBlock DeserializeLength(Stream stream, int length, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F716F0 Offset: 0x1F6FCF0 VA: 0x181F716F0
	public static void SerializeDelta(Stream stream, BuildingBlock instance, BuildingBlock previous) { }

	// RVA: 0x1F71A70 Offset: 0x1F70070 VA: 0x181F71A70
	public static void Serialize(Stream stream, BuildingBlock instance) { }

	// RVA: 0x1F71B90 Offset: 0x1F70190 VA: 0x181F71B90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F71BA0 Offset: 0x1F701A0 VA: 0x181F71BA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F71960 Offset: 0x1F6FF60 VA: 0x181F71960
	public static byte[] SerializeToBytes(BuildingBlock instance) { }

	// RVA: 0x1F718B0 Offset: 0x1F6FEB0 VA: 0x181F718B0
	public static void SerializeLengthDelimited(Stream stream, BuildingBlock instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1F73470 Offset: 0x1F71A70 VA: 0x181F73470
	public static void ResetToPool(BuildingPrivilege instance) { }

	// RVA: 0x1F73660 Offset: 0x1F71C60 VA: 0x181F73660
	public void ResetToPool() { }

	// RVA: 0x1F73170 Offset: 0x1F71770 VA: 0x181F73170 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F71BE0 Offset: 0x1F701E0 VA: 0x181F71BE0
	public void CopyTo(BuildingPrivilege instance) { }

	// RVA: 0x1F71D20 Offset: 0x1F70320 VA: 0x181F71D20
	public BuildingPrivilege Copy() { }

	// RVA: 0x1F72960 Offset: 0x1F70F60 VA: 0x181F72960
	public static BuildingPrivilege Deserialize(Stream stream) { }

	// RVA: 0x1F721F0 Offset: 0x1F707F0 VA: 0x181F721F0
	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F72270 Offset: 0x1F70870 VA: 0x181F72270
	public static BuildingPrivilege DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F72E50 Offset: 0x1F71450 VA: 0x181F72E50
	public static BuildingPrivilege Deserialize(byte[] buffer) { }

	// RVA: 0x1F731F0 Offset: 0x1F717F0 VA: 0x181F731F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F73FB0 Offset: 0x1F725B0 VA: 0x181F73FB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F73FD0 Offset: 0x1F725D0 VA: 0x181F73FD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BuildingPrivilege previous) { }

	// RVA: 0x1F73450 Offset: 0x1F71A50 VA: 0x181F73450 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F72620 Offset: 0x1F70C20 VA: 0x181F72620
	public static BuildingPrivilege Deserialize(byte[] buffer, BuildingPrivilege instance, bool isDelta = False) { }

	// RVA: 0x1F72BE0 Offset: 0x1F711E0 VA: 0x181F72BE0
	public static BuildingPrivilege Deserialize(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F71EB0 Offset: 0x1F704B0 VA: 0x181F71EB0
	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F72300 Offset: 0x1F70900 VA: 0x181F72300
	public static BuildingPrivilege DeserializeLength(Stream stream, int length, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F73850 Offset: 0x1F71E50 VA: 0x181F73850
	public static void SerializeDelta(Stream stream, BuildingPrivilege instance, BuildingPrivilege previous) { }

	// RVA: 0x1F73D20 Offset: 0x1F72320 VA: 0x181F73D20
	public static void Serialize(Stream stream, BuildingPrivilege instance) { }

	// RVA: 0x1F73FA0 Offset: 0x1F725A0 VA: 0x181F73FA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F73FB0 Offset: 0x1F725B0 VA: 0x181F73FB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F73C10 Offset: 0x1F72210 VA: 0x181F73C10
	public static byte[] SerializeToBytes(BuildingPrivilege instance) { }

	// RVA: 0x1F73B60 Offset: 0x1F72160 VA: 0x181F73B60
	public static void SerializeLengthDelimited(Stream stream, BuildingPrivilege instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x6ECED0 Offset: 0x6EB4D0 VA: 0x1806ECED0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6EE510 Offset: 0x6ECB10 VA: 0x1806EE510 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6EE230 Offset: 0x6EC830 VA: 0x1806EE230 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6ECEA0 Offset: 0x6EB4A0 VA: 0x1806ECEA0
	public float CalculateUpkeepPeriodMinutes() { }

	// RVA: 0x6ECE70 Offset: 0x6EB470 VA: 0x1806ECE70
	public float CalculateUpkeepCostFraction() { }

	// RVA: 0x6ECCD0 Offset: 0x6EB2D0 VA: 0x1806ECCD0
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts) { }

	// RVA: 0x6EDC00 Offset: 0x6EC200 VA: 0x1806EDC00
	public float GetProtectedMinutes(bool force = False) { }

	// RVA: 0x6EE320 Offset: 0x6EC920 VA: 0x1806EE320 Slot: 27
	public override void ResetState() { }

	// RVA: 0x6EDCF0 Offset: 0x6EC2F0 VA: 0x1806EDCF0
	public bool IsAuthed(BasePlayer player) { }

	// RVA: 0x6EDC40 Offset: 0x6EC240 VA: 0x1806EDC40
	public bool IsAuthed(ulong userID) { }

	// RVA: 0x6ECC80 Offset: 0x6EB280 VA: 0x1806ECC80
	public bool AnyAuthed() { }

	// RVA: 0x6EDDB0 Offset: 0x6EC3B0 VA: 0x1806EDDB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void BuildingDirty() { }

	[BaseEntity.Menu] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	[BaseEntity.Menu.Description] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	[BaseEntity.Menu.Icon] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_MaxAuth(BasePlayer player) { }

	// RVA: 0x6EE0C0 Offset: 0x6EC6C0 VA: 0x1806EE0C0
	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	[BaseEntity.Menu.Description] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	[BaseEntity.Menu.Icon] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	// RVA: 0x6EDF10 Offset: 0x6EC510 VA: 0x1806EDF10
	public void MenuAuthorize(BasePlayer player) { }

	// RVA: 0x6EDED0 Offset: 0x6EC4D0 VA: 0x1806EDED0
	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	[BaseEntity.Menu.Description] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	[BaseEntity.Menu.Icon] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	// RVA: 0x6EE080 Offset: 0x6EC680 VA: 0x1806EE080
	public void MenuDeauthorize(BasePlayer player) { }

	// RVA: 0x6EE070 Offset: 0x6EC670 VA: 0x1806EE070
	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	[BaseEntity.Menu.Description] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	[BaseEntity.Menu.Icon] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	// RVA: 0x6EE030 Offset: 0x6EC630 VA: 0x1806EE030
	public void MenuClearList(BasePlayer player) { }

	// RVA: 0x6EDF50 Offset: 0x6EC550 VA: 0x1806EDF50
	public bool MenuClearList_ShowIf(BasePlayer player) { }

	// RVA: 0x6EE380 Offset: 0x6EC980 VA: 0x1806EE380 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	[BaseEntity.Menu.Description] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	[BaseEntity.Menu.Icon] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	[BaseEntity.Menu.ShowIf] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	// RVA: 0x6EE1F0 Offset: 0x6EC7F0 VA: 0x1806EE1F0
	public void Menu_RotateVM(BasePlayer player) { }

	// RVA: 0x6EE110 Offset: 0x6EC710 VA: 0x1806EE110
	public bool Menu_RotateTC_ShowIf(BasePlayer player) { }

	// RVA: 0x6EDAA0 Offset: 0x6EC0A0 VA: 0x1806EDAA0 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x6EDC30 Offset: 0x6EC230 VA: 0x1806EDC30 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x6EE450 Offset: 0x6ECA50 VA: 0x1806EE450
	public void .ctor() { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass20_0 // TypeDefIndex: 8364
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705A30 Offset: 0x704030 VA: 0x180705A30
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass21_0 // TypeDefIndex: 8365
{	// Fields
	public ulong userID; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705A60 Offset: 0x704060 VA: 0x180705A60
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

	// RVA: 0x6EB280 Offset: 0x6E9880 VA: 0x1806EB280 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6E91B0 Offset: 0x6E77B0 VA: 0x1806E91B0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6EB790 Offset: 0x6E9D90 VA: 0x1806EB790 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x6E9600 Offset: 0x6E7C00 VA: 0x1806E9600
	public List<Option> GetBuildMenu(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6EB7F0 Offset: 0x6E9DF0 VA: 0x1806EB7F0
	private void RefreshSkin(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6EBD20 Offset: 0x6EA320 VA: 0x1806EBD20 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x6E8C00 Offset: 0x6E7200 VA: 0x1806E8C00
	private bool CanDemolish(BasePlayer player) { }

	// RVA: 0x6EA9E0 Offset: 0x6E8FE0 VA: 0x1806EA9E0
	private bool IsDemolishable() { }

	// RVA: 0x6E9FE0 Offset: 0x6E85E0 VA: 0x1806E9FE0
	private bool HasDemolishPrivilege(BasePlayer player) { }

	// RVA: 0x6E9400 Offset: 0x6E7A00 VA: 0x1806E9400
	private void Demolish(BasePlayer player) { }

	// RVA: 0x6E9290 Offset: 0x6E7890 VA: 0x1806E9290
	private void DemolishOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x6EBBE0 Offset: 0x6EA1E0 VA: 0x1806EBBE0
	public void SetConditionalModel(int state) { }

	// RVA: 0x6E97D0 Offset: 0x6E7DD0 VA: 0x1806E97D0
	public bool GetConditionalModel(int index) { }

	// RVA: 0x6EC580 Offset: 0x6EAB80 VA: 0x1806EC580
	public ConstructionGrade get_currentGrade() { }

	// RVA: 0x6E97F0 Offset: 0x6E7DF0 VA: 0x1806E97F0
	private ConstructionGrade GetGrade(BuildingGrade.Enum iGrade) { }

	// RVA: 0x6E8BD0 Offset: 0x6E71D0 VA: 0x1806E8BD0
	private bool CanChangeToGrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x6EA1A0 Offset: 0x6E87A0 VA: 0x1806EA1A0
	private bool HasUpgradePrivilege(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x6EAEC0 Offset: 0x6E94C0 VA: 0x1806EAEC0
	private bool IsUpgradeBlocked() { }

	// RVA: 0x6E8A00 Offset: 0x6E7000 VA: 0x1806E8A00
	private bool CanAffordUpgrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x6EBBF0 Offset: 0x6EA1F0 VA: 0x1806EBBF0
	public void SetGrade(BuildingGrade.Enum iGradeID) { }

	// RVA: 0x6EBDB0 Offset: 0x6EA3B0 VA: 0x1806EBDB0
	private void UpdateGrade() { }

	// RVA: 0x6EC1A0 Offset: 0x6EA7A0 VA: 0x1806EC1A0
	private void UpgradeToGrade(BuildingGrade.Enum i, BasePlayer player) { }

	// RVA: 0x6E9B90 Offset: 0x6E8190 VA: 0x1806E9B90
	private void GradeChangingOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x6EB1E0 Offset: 0x6E97E0 VA: 0x1806EB1E0
	private bool NeedsSkinChange() { }

	// RVA: 0x6EBED0 Offset: 0x6EA4D0 VA: 0x1806EBED0
	public void UpdateSkin(bool force = False) { }

	// RVA: 0x6E9460 Offset: 0x6E7A60 VA: 0x1806E9460
	private void DestroySkin() { }

	// RVA: 0x6EBDF0 Offset: 0x6EA3F0 VA: 0x1806EBDF0
	private void UpdatePlaceholder(bool state) { }

	// RVA: 0x6E9030 Offset: 0x6E7630 VA: 0x1806E9030
	private void ChangeSkin() { }

	// RVA: 0x6E8E10 Offset: 0x6E7410 VA: 0x1806E8E10
	private void ChangeSkin(GameObjectRef prefab) { }

	// RVA: 0x6EBD10 Offset: 0x6EA310 VA: 0x1806EBD10 Slot: 127
	public override bool ShouldBlockProjectiles() { }

	// RVA: 0x6EB1B0 Offset: 0x6E97B0 VA: 0x1806EB1B0 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x6E89D0 Offset: 0x6E6FD0 VA: 0x1806E89D0 Slot: 137
	public override List<ItemAmount> BuildCost() { }

	// RVA: 0x6E9510 Offset: 0x6E7B10 VA: 0x1806E9510
	public void DrawHighlight() { }

	// RVA: 0x6EA2F0 Offset: 0x6E88F0 VA: 0x1806EA2F0
	public void Highlight(MeshRenderer renderer) { }

	// RVA: 0x6E8D60 Offset: 0x6E7360 VA: 0x1806E8D60
	private bool CanRotate(BasePlayer player) { }

	// RVA: 0x6EACF0 Offset: 0x6E92F0 VA: 0x1806EACF0
	private bool IsRotatable() { }

	// RVA: 0x6EAD40 Offset: 0x6E9340 VA: 0x1806EAD40
	private bool IsRotationBlocked() { }

	// RVA: 0x6EA0C0 Offset: 0x6E86C0 VA: 0x1806EA0C0
	private bool HasRotationPrivilege(BasePlayer player) { }

	// RVA: 0x6EBB30 Offset: 0x6EA130 VA: 0x1806EBB30
	private void Rotation(BasePlayer player) { }

	// RVA: 0x6EB8F0 Offset: 0x6E9EF0 VA: 0x1806EB8F0
	private void RotationOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x6EB040 Offset: 0x6E9640 VA: 0x1806EB040 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6EB880 Offset: 0x6E9E80 VA: 0x1806EB880 Slot: 27
	public override void ResetState() { }

	// RVA: 0x6EA960 Offset: 0x6E8F60 VA: 0x1806EA960 Slot: 28
	public override void InitShared() { }

	// RVA: 0x6EB720 Offset: 0x6E9D20 VA: 0x1806EB720 Slot: 30
	public override void PostInitShared() { }

	// RVA: 0x6D32B0 Offset: 0x6D18B0 VA: 0x1806D32B0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x6E8DE0 Offset: 0x6E73E0 VA: 0x1806E8DE0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x6EAA60 Offset: 0x6E9060 VA: 0x1806EAA60 Slot: 106
	public override bool IsOutside() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x6EC560 Offset: 0x6EAB60 VA: 0x1806EC560
	public void .ctor() { }

	// RVA: 0x6EC250 Offset: 0x6EA850 VA: 0x1806EC250
	private static void .cctor() { }

}

public static class BuildingBlock.BlockFlags // TypeDefIndex: 8539
{	// Fields
	public const BaseEntity.Flags CanRotate = 128;
	public const BaseEntity.Flags CanDemolish = 256;

}

public class BuildingBlock.UpdateSkinWorkQueue : ObjectWorkQueue<BuildingBlock> // TypeDefIndex: 8540
{	// Methods

	// RVA: 0x705B40 Offset: 0x704140 VA: 0x180705B40 Slot: 6
	protected override void RunJob(BuildingBlock entity) { }

	// RVA: 0x705B80 Offset: 0x704180 VA: 0x180705B80 Slot: 5
	protected override bool ShouldAdd(BuildingBlock entity) { }

	// RVA: 0x705B90 Offset: 0x704190 VA: 0x180705B90
	public void .ctor() { }

}

private sealed class BuildingBlock.<>c__DisplayClass31_0 // TypeDefIndex: 8541
{	// Fields
	public BuildingGrade.Enum iNewGrade; // 0x10
	public BuildingBlock <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705A80 Offset: 0x704080 VA: 0x180705A80
	internal void <GradeChangingOptions>b__0(BasePlayer ply) { }

}

public class BuildingProximity : PrefabAttribute // TypeDefIndex: 9049
{	// Fields
	private const float check_radius = 2;
	private const float check_forgiveness = 0,01;
	private const float foundation_width = 3;
	private const float foundation_extents = 1,5;

	// Methods

	// RVA: 0x6EE790 Offset: 0x6ECD90 VA: 0x1806EE790
	public static bool Check(BasePlayer player, Construction construction, Vector3 position, Quaternion rotation) { }

	// RVA: 0x6EEF80 Offset: 0x6ED580 VA: 0x1806EEF80
	private static BuildingProximity.ProximityInfo GetProximity(Construction construction1, Vector3 position1, Quaternion rotation1, Construction construction2, Vector3 position2, Quaternion rotation2) { }

	// RVA: 0x6EF510 Offset: 0x6EDB10 VA: 0x1806EF510
	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x6EEF20 Offset: 0x6ED520 VA: 0x1806EEF20 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6EF630 Offset: 0x6EDC30 VA: 0x1806EF630
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

	// RVA: 0x6E89C0 Offset: 0x6E6FC0 VA: 0x1806E89C0
	public void .ctor() { }

}

public class BuildingGradeDecay : Decay // TypeDefIndex: 9527
{	// Fields
	public BuildingGrade.Enum decayGrade; // 0x98

	// Methods

	// RVA: 0x6E89C0 Offset: 0x6E6FC0 VA: 0x1806E89C0
	public void .ctor() { }

}

public abstract class BuildingManager // TypeDefIndex: 9826
{	// Fields
	public static ClientBuildingManager client; // 0x0
	protected ListHashSet<DecayEntity> decayEntities; // 0x10
	protected ListDictionary<uint, BuildingManager.Building> buildingDictionary; // 0x18

	// Methods

	// RVA: 0x6EC920 Offset: 0x6EAF20 VA: 0x1806EC920
	public BuildingManager.Building GetBuilding(uint buildingID) { }

	// RVA: 0x6EC780 Offset: 0x6EAD80 VA: 0x1806EC780
	public void Add(DecayEntity ent) { }

	// RVA: 0x6EC990 Offset: 0x6EAF90 VA: 0x1806EC990
	public void Remove(DecayEntity ent) { }

	// RVA: 0x6EC8D0 Offset: 0x6EAED0 VA: 0x1806EC8D0
	public void Clear() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract BuildingManager.Building CreateBuilding(uint id);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void DisposeBuilding(ref BuildingManager.Building building);

	// RVA: 0x6ECBE0 Offset: 0x6EB1E0 VA: 0x1806ECBE0
	protected void .ctor() { }

	// RVA: 0x6ECB80 Offset: 0x6EB180 VA: 0x1806ECB80
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

	// RVA: 0x6EFD70 Offset: 0x6EE370 VA: 0x1806EFD70
	public bool IsEmpty() { }

	// RVA: 0x6EFB50 Offset: 0x6EE150 VA: 0x1806EFB50
	public BuildingPrivlidge GetDominatingBuildingPrivilege() { }

	// RVA: 0x6EFCD0 Offset: 0x6EE2D0 VA: 0x1806EFCD0
	public bool HasBuildingPrivileges() { }

	// RVA: 0x6EFC80 Offset: 0x6EE280 VA: 0x1806EFC80
	public bool HasBuildingBlocks() { }

	// RVA: 0x6EFD20 Offset: 0x6EE320 VA: 0x1806EFD20
	public bool HasDecayEntities() { }

	// RVA: 0x6EF730 Offset: 0x6EDD30 VA: 0x1806EF730
	public void AddBuildingPrivilege(BuildingPrivlidge ent) { }

	// RVA: 0x6EFEC0 Offset: 0x6EE4C0 VA: 0x1806EFEC0
	public void RemoveBuildingPrivilege(BuildingPrivlidge ent) { }

	// RVA: 0x6EF690 Offset: 0x6EDC90 VA: 0x1806EF690
	public void AddBuildingBlock(BuildingBlock ent) { }

	// RVA: 0x6EFE30 Offset: 0x6EE430 VA: 0x1806EFE30
	public void RemoveBuildingBlock(BuildingBlock ent) { }

	// RVA: 0x6EF7D0 Offset: 0x6EDDD0 VA: 0x1806EF7D0
	public void AddDecayEntity(DecayEntity ent) { }

	// RVA: 0x6EFF50 Offset: 0x6EE550 VA: 0x1806EFF50
	public void RemoveDecayEntity(DecayEntity ent) { }

	// RVA: 0x6EF870 Offset: 0x6EDE70 VA: 0x1806EF870
	public void Add(DecayEntity ent) { }

	// RVA: 0x6EFFE0 Offset: 0x6EE5E0 VA: 0x1806EFFE0
	public void Remove(DecayEntity ent) { }

	// RVA: 0x6EFAD0 Offset: 0x6EE0D0 VA: 0x1806EFAD0
	public void Dirty() { }

	// RVA: 0x6F01E0 Offset: 0x6EE7E0 VA: 0x1806F01E0
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

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
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

