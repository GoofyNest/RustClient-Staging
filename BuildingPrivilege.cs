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

	// RVA: 0x14AA9D0 Offset: 0x14A8FD0 VA: 0x1814AA9D0
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
	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	public bool get_Valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9974F0 Offset: 0x995AF0 VA: 0x1809974F0
	public void set_Valid(bool value) { }

	// RVA: 0x14AAB10 Offset: 0x14A9110 VA: 0x1814AAB10
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
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Repo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
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
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
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
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
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
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
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

	// RVA: 0x1F71310 Offset: 0x1F6F910 VA: 0x181F71310
	public static void ResetToPool(BuildingBlock instance) { }

	// RVA: 0x1F713A0 Offset: 0x1F6F9A0 VA: 0x181F713A0
	public void ResetToPool() { }

	// RVA: 0x1F71030 Offset: 0x1F6F630 VA: 0x181F71030 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68BE0 Offset: 0x1D671E0 VA: 0x181D68BE0
	public void CopyTo(BuildingBlock instance) { }

	// RVA: 0x1F70100 Offset: 0x1F6E700 VA: 0x181F70100
	public BuildingBlock Copy() { }

	// RVA: 0x1F70C90 Offset: 0x1F6F290 VA: 0x181F70C90
	public static BuildingBlock Deserialize(Stream stream) { }

	// RVA: 0x1F70180 Offset: 0x1F6E780 VA: 0x181F70180
	public static BuildingBlock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F706E0 Offset: 0x1F6ECE0 VA: 0x181F706E0
	public static BuildingBlock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F709F0 Offset: 0x1F6EFF0 VA: 0x181F709F0
	public static BuildingBlock Deserialize(byte[] buffer) { }

	// RVA: 0x1F71140 Offset: 0x1F6F740 VA: 0x181F71140
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F718E0 Offset: 0x1F6FEE0 VA: 0x181F718E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F71900 Offset: 0x1F6FF00 VA: 0x181F71900 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BuildingBlock previous) { }

	// RVA: 0x1F712F0 Offset: 0x1F6F8F0 VA: 0x181F712F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F70770 Offset: 0x1F6ED70 VA: 0x181F70770
	public static BuildingBlock Deserialize(byte[] buffer, BuildingBlock instance, bool isDelta = False) { }

	// RVA: 0x1F70E80 Offset: 0x1F6F480 VA: 0x181F70E80
	public static BuildingBlock Deserialize(Stream stream, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F70200 Offset: 0x1F6E800 VA: 0x181F70200
	public static BuildingBlock DeserializeLengthDelimited(Stream stream, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F70480 Offset: 0x1F6EA80 VA: 0x181F70480
	public static BuildingBlock DeserializeLength(Stream stream, int length, BuildingBlock instance, bool isDelta) { }

	// RVA: 0x1F71430 Offset: 0x1F6FA30 VA: 0x181F71430
	public static void SerializeDelta(Stream stream, BuildingBlock instance, BuildingBlock previous) { }

	// RVA: 0x1F717B0 Offset: 0x1F6FDB0 VA: 0x181F717B0
	public static void Serialize(Stream stream, BuildingBlock instance) { }

	// RVA: 0x1F718D0 Offset: 0x1F6FED0 VA: 0x181F718D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F718E0 Offset: 0x1F6FEE0 VA: 0x181F718E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F716A0 Offset: 0x1F6FCA0 VA: 0x181F716A0
	public static byte[] SerializeToBytes(BuildingBlock instance) { }

	// RVA: 0x1F715F0 Offset: 0x1F6FBF0 VA: 0x181F715F0
	public static void SerializeLengthDelimited(Stream stream, BuildingBlock instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1F731B0 Offset: 0x1F717B0 VA: 0x181F731B0
	public static void ResetToPool(BuildingPrivilege instance) { }

	// RVA: 0x1F733A0 Offset: 0x1F719A0 VA: 0x181F733A0
	public void ResetToPool() { }

	// RVA: 0x1F72EB0 Offset: 0x1F714B0 VA: 0x181F72EB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F71920 Offset: 0x1F6FF20 VA: 0x181F71920
	public void CopyTo(BuildingPrivilege instance) { }

	// RVA: 0x1F71A60 Offset: 0x1F70060 VA: 0x181F71A60
	public BuildingPrivilege Copy() { }

	// RVA: 0x1F726A0 Offset: 0x1F70CA0 VA: 0x181F726A0
	public static BuildingPrivilege Deserialize(Stream stream) { }

	// RVA: 0x1F71F30 Offset: 0x1F70530 VA: 0x181F71F30
	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F71FB0 Offset: 0x1F705B0 VA: 0x181F71FB0
	public static BuildingPrivilege DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F72B90 Offset: 0x1F71190 VA: 0x181F72B90
	public static BuildingPrivilege Deserialize(byte[] buffer) { }

	// RVA: 0x1F72F30 Offset: 0x1F71530 VA: 0x181F72F30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F73CF0 Offset: 0x1F722F0 VA: 0x181F73CF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F73D10 Offset: 0x1F72310 VA: 0x181F73D10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BuildingPrivilege previous) { }

	// RVA: 0x1F73190 Offset: 0x1F71790 VA: 0x181F73190 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F72360 Offset: 0x1F70960 VA: 0x181F72360
	public static BuildingPrivilege Deserialize(byte[] buffer, BuildingPrivilege instance, bool isDelta = False) { }

	// RVA: 0x1F72920 Offset: 0x1F70F20 VA: 0x181F72920
	public static BuildingPrivilege Deserialize(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F71BF0 Offset: 0x1F701F0 VA: 0x181F71BF0
	public static BuildingPrivilege DeserializeLengthDelimited(Stream stream, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F72040 Offset: 0x1F70640 VA: 0x181F72040
	public static BuildingPrivilege DeserializeLength(Stream stream, int length, BuildingPrivilege instance, bool isDelta) { }

	// RVA: 0x1F73590 Offset: 0x1F71B90 VA: 0x181F73590
	public static void SerializeDelta(Stream stream, BuildingPrivilege instance, BuildingPrivilege previous) { }

	// RVA: 0x1F73A60 Offset: 0x1F72060 VA: 0x181F73A60
	public static void Serialize(Stream stream, BuildingPrivilege instance) { }

	// RVA: 0x1F73CE0 Offset: 0x1F722E0 VA: 0x181F73CE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F73CF0 Offset: 0x1F722F0 VA: 0x181F73CF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F73950 Offset: 0x1F71F50 VA: 0x181F73950
	public static byte[] SerializeToBytes(BuildingPrivilege instance) { }

	// RVA: 0x1F738A0 Offset: 0x1F71EA0 VA: 0x181F738A0
	public static void SerializeLengthDelimited(Stream stream, BuildingPrivilege instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x6ECDC0 Offset: 0x6EB3C0 VA: 0x1806ECDC0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6EE400 Offset: 0x6ECA00 VA: 0x1806EE400 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6EE120 Offset: 0x6EC720 VA: 0x1806EE120 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6ECD90 Offset: 0x6EB390 VA: 0x1806ECD90
	public float CalculateUpkeepPeriodMinutes() { }

	// RVA: 0x6ECD60 Offset: 0x6EB360 VA: 0x1806ECD60
	public float CalculateUpkeepCostFraction() { }

	// RVA: 0x6ECBC0 Offset: 0x6EB1C0 VA: 0x1806ECBC0
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts) { }

	// RVA: 0x6EDAF0 Offset: 0x6EC0F0 VA: 0x1806EDAF0
	public float GetProtectedMinutes(bool force = False) { }

	// RVA: 0x6EE210 Offset: 0x6EC810 VA: 0x1806EE210 Slot: 27
	public override void ResetState() { }

	// RVA: 0x6EDBE0 Offset: 0x6EC1E0 VA: 0x1806EDBE0
	public bool IsAuthed(BasePlayer player) { }

	// RVA: 0x6EDB30 Offset: 0x6EC130 VA: 0x1806EDB30
	public bool IsAuthed(ulong userID) { }

	// RVA: 0x6ECB70 Offset: 0x6EB170 VA: 0x1806ECB70
	public bool AnyAuthed() { }

	// RVA: 0x6EDCA0 Offset: 0x6EC2A0 VA: 0x1806EDCA0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void BuildingDirty() { }

	[BaseEntity.Menu] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	[BaseEntity.Menu.Description] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	[BaseEntity.Menu.Icon] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDC20 Offset: 0xCD020 VA: 0x1800CDC20
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_MaxAuth(BasePlayer player) { }

	// RVA: 0x6EDFB0 Offset: 0x6EC5B0 VA: 0x1806EDFB0
	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	[BaseEntity.Menu.Description] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	[BaseEntity.Menu.Icon] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	// RVA: 0x6EDE00 Offset: 0x6EC400 VA: 0x1806EDE00
	public void MenuAuthorize(BasePlayer player) { }

	// RVA: 0x6EDDC0 Offset: 0x6EC3C0 VA: 0x1806EDDC0
	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	[BaseEntity.Menu.Description] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	[BaseEntity.Menu.Icon] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCE2B0 Offset: 0xCD6B0 VA: 0x1800CE2B0
	// RVA: 0x6EDF70 Offset: 0x6EC570 VA: 0x1806EDF70
	public void MenuDeauthorize(BasePlayer player) { }

	// RVA: 0x6EDF60 Offset: 0x6EC560 VA: 0x1806EDF60
	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	[BaseEntity.Menu.Description] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	[BaseEntity.Menu.Icon] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCF8F0 Offset: 0xCECF0 VA: 0x1800CF8F0
	// RVA: 0x6EDF20 Offset: 0x6EC520 VA: 0x1806EDF20
	public void MenuClearList(BasePlayer player) { }

	// RVA: 0x6EDE40 Offset: 0x6EC440 VA: 0x1806EDE40
	public bool MenuClearList_ShowIf(BasePlayer player) { }

	// RVA: 0x6EE270 Offset: 0x6EC870 VA: 0x1806EE270 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	[BaseEntity.Menu.Description] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	[BaseEntity.Menu.Icon] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	[BaseEntity.Menu.ShowIf] // RVA: 0xCFB40 Offset: 0xCEF40 VA: 0x1800CFB40
	// RVA: 0x6EE0E0 Offset: 0x6EC6E0 VA: 0x1806EE0E0
	public void Menu_RotateVM(BasePlayer player) { }

	// RVA: 0x6EE000 Offset: 0x6EC600 VA: 0x1806EE000
	public bool Menu_RotateTC_ShowIf(BasePlayer player) { }

	// RVA: 0x6ED990 Offset: 0x6EBF90 VA: 0x1806ED990 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x6EDB20 Offset: 0x6EC120 VA: 0x1806EDB20 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x6EE340 Offset: 0x6EC940 VA: 0x1806EE340
	public void .ctor() { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass20_0 // TypeDefIndex: 8364
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705920 Offset: 0x703F20 VA: 0x180705920
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class BuildingPrivlidge.<>c__DisplayClass21_0 // TypeDefIndex: 8365
{	// Fields
	public ulong userID; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705950 Offset: 0x703F50 VA: 0x180705950
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

	// RVA: 0x6EB170 Offset: 0x6E9770 VA: 0x1806EB170 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6E90A0 Offset: 0x6E76A0 VA: 0x1806E90A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6EB680 Offset: 0x6E9C80 VA: 0x1806EB680 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x6E94F0 Offset: 0x6E7AF0 VA: 0x1806E94F0
	public List<Option> GetBuildMenu(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6EB6E0 Offset: 0x6E9CE0 VA: 0x1806EB6E0
	private void RefreshSkin(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6EBC10 Offset: 0x6EA210 VA: 0x1806EBC10 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x6E8AF0 Offset: 0x6E70F0 VA: 0x1806E8AF0
	private bool CanDemolish(BasePlayer player) { }

	// RVA: 0x6EA8D0 Offset: 0x6E8ED0 VA: 0x1806EA8D0
	private bool IsDemolishable() { }

	// RVA: 0x6E9ED0 Offset: 0x6E84D0 VA: 0x1806E9ED0
	private bool HasDemolishPrivilege(BasePlayer player) { }

	// RVA: 0x6E92F0 Offset: 0x6E78F0 VA: 0x1806E92F0
	private void Demolish(BasePlayer player) { }

	// RVA: 0x6E9180 Offset: 0x6E7780 VA: 0x1806E9180
	private void DemolishOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x6EBAD0 Offset: 0x6EA0D0 VA: 0x1806EBAD0
	public void SetConditionalModel(int state) { }

	// RVA: 0x6E96C0 Offset: 0x6E7CC0 VA: 0x1806E96C0
	public bool GetConditionalModel(int index) { }

	// RVA: 0x6EC470 Offset: 0x6EAA70 VA: 0x1806EC470
	public ConstructionGrade get_currentGrade() { }

	// RVA: 0x6E96E0 Offset: 0x6E7CE0 VA: 0x1806E96E0
	private ConstructionGrade GetGrade(BuildingGrade.Enum iGrade) { }

	// RVA: 0x6E8AC0 Offset: 0x6E70C0 VA: 0x1806E8AC0
	private bool CanChangeToGrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x6EA090 Offset: 0x6E8690 VA: 0x1806EA090
	private bool HasUpgradePrivilege(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x6EADB0 Offset: 0x6E93B0 VA: 0x1806EADB0
	private bool IsUpgradeBlocked() { }

	// RVA: 0x6E88F0 Offset: 0x6E6EF0 VA: 0x1806E88F0
	private bool CanAffordUpgrade(BuildingGrade.Enum iGrade, BasePlayer player) { }

	// RVA: 0x6EBAE0 Offset: 0x6EA0E0 VA: 0x1806EBAE0
	public void SetGrade(BuildingGrade.Enum iGradeID) { }

	// RVA: 0x6EBCA0 Offset: 0x6EA2A0 VA: 0x1806EBCA0
	private void UpdateGrade() { }

	// RVA: 0x6EC090 Offset: 0x6EA690 VA: 0x1806EC090
	private void UpgradeToGrade(BuildingGrade.Enum i, BasePlayer player) { }

	// RVA: 0x6E9A80 Offset: 0x6E8080 VA: 0x1806E9A80
	private void GradeChangingOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x6EB0D0 Offset: 0x6E96D0 VA: 0x1806EB0D0
	private bool NeedsSkinChange() { }

	// RVA: 0x6EBDC0 Offset: 0x6EA3C0 VA: 0x1806EBDC0
	public void UpdateSkin(bool force = False) { }

	// RVA: 0x6E9350 Offset: 0x6E7950 VA: 0x1806E9350
	private void DestroySkin() { }

	// RVA: 0x6EBCE0 Offset: 0x6EA2E0 VA: 0x1806EBCE0
	private void UpdatePlaceholder(bool state) { }

	// RVA: 0x6E8F20 Offset: 0x6E7520 VA: 0x1806E8F20
	private void ChangeSkin() { }

	// RVA: 0x6E8D00 Offset: 0x6E7300 VA: 0x1806E8D00
	private void ChangeSkin(GameObjectRef prefab) { }

	// RVA: 0x6EBC00 Offset: 0x6EA200 VA: 0x1806EBC00 Slot: 127
	public override bool ShouldBlockProjectiles() { }

	// RVA: 0x6EB0A0 Offset: 0x6E96A0 VA: 0x1806EB0A0 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x6E88C0 Offset: 0x6E6EC0 VA: 0x1806E88C0 Slot: 137
	public override List<ItemAmount> BuildCost() { }

	// RVA: 0x6E9400 Offset: 0x6E7A00 VA: 0x1806E9400
	public void DrawHighlight() { }

	// RVA: 0x6EA1E0 Offset: 0x6E87E0 VA: 0x1806EA1E0
	public void Highlight(MeshRenderer renderer) { }

	// RVA: 0x6E8C50 Offset: 0x6E7250 VA: 0x1806E8C50
	private bool CanRotate(BasePlayer player) { }

	// RVA: 0x6EABE0 Offset: 0x6E91E0 VA: 0x1806EABE0
	private bool IsRotatable() { }

	// RVA: 0x6EAC30 Offset: 0x6E9230 VA: 0x1806EAC30
	private bool IsRotationBlocked() { }

	// RVA: 0x6E9FB0 Offset: 0x6E85B0 VA: 0x1806E9FB0
	private bool HasRotationPrivilege(BasePlayer player) { }

	// RVA: 0x6EBA20 Offset: 0x6EA020 VA: 0x1806EBA20
	private void Rotation(BasePlayer player) { }

	// RVA: 0x6EB7E0 Offset: 0x6E9DE0 VA: 0x1806EB7E0
	private void RotationOptions(ref List<Option> options, BasePlayer player) { }

	// RVA: 0x6EAF30 Offset: 0x6E9530 VA: 0x1806EAF30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6EB770 Offset: 0x6E9D70 VA: 0x1806EB770 Slot: 27
	public override void ResetState() { }

	// RVA: 0x6EA850 Offset: 0x6E8E50 VA: 0x1806EA850 Slot: 28
	public override void InitShared() { }

	// RVA: 0x6EB610 Offset: 0x6E9C10 VA: 0x1806EB610 Slot: 30
	public override void PostInitShared() { }

	// RVA: 0x6D31A0 Offset: 0x6D17A0 VA: 0x1806D31A0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x6E8CD0 Offset: 0x6E72D0 VA: 0x1806E8CD0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x6EA950 Offset: 0x6E8F50 VA: 0x1806EA950 Slot: 106
	public override bool IsOutside() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x6EC450 Offset: 0x6EAA50 VA: 0x1806EC450
	public void .ctor() { }

	// RVA: 0x6EC140 Offset: 0x6EA740 VA: 0x1806EC140
	private static void .cctor() { }

}

public static class BuildingBlock.BlockFlags // TypeDefIndex: 8539
{	// Fields
	public const BaseEntity.Flags CanRotate = 128;
	public const BaseEntity.Flags CanDemolish = 256;

}

public class BuildingBlock.UpdateSkinWorkQueue : ObjectWorkQueue<BuildingBlock> // TypeDefIndex: 8540
{	// Methods

	// RVA: 0x705A30 Offset: 0x704030 VA: 0x180705A30 Slot: 6
	protected override void RunJob(BuildingBlock entity) { }

	// RVA: 0x705A70 Offset: 0x704070 VA: 0x180705A70 Slot: 5
	protected override bool ShouldAdd(BuildingBlock entity) { }

	// RVA: 0x705A80 Offset: 0x704080 VA: 0x180705A80
	public void .ctor() { }

}

private sealed class BuildingBlock.<>c__DisplayClass31_0 // TypeDefIndex: 8541
{	// Fields
	public BuildingGrade.Enum iNewGrade; // 0x10
	public BuildingBlock <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705970 Offset: 0x703F70 VA: 0x180705970
	internal void <GradeChangingOptions>b__0(BasePlayer ply) { }

}

public class BuildingProximity : PrefabAttribute // TypeDefIndex: 9049
{	// Fields
	private const float check_radius = 2;
	private const float check_forgiveness = 0,01;
	private const float foundation_width = 3;
	private const float foundation_extents = 1,5;

	// Methods

	// RVA: 0x6EE680 Offset: 0x6ECC80 VA: 0x1806EE680
	public static bool Check(BasePlayer player, Construction construction, Vector3 position, Quaternion rotation) { }

	// RVA: 0x6EEE70 Offset: 0x6ED470 VA: 0x1806EEE70
	private static BuildingProximity.ProximityInfo GetProximity(Construction construction1, Vector3 position1, Quaternion rotation1, Construction construction2, Vector3 position2, Quaternion rotation2) { }

	// RVA: 0x6EF400 Offset: 0x6EDA00 VA: 0x1806EF400
	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x6EEE10 Offset: 0x6ED410 VA: 0x1806EEE10 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6EF520 Offset: 0x6EDB20 VA: 0x1806EF520
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

	// RVA: 0x6E88B0 Offset: 0x6E6EB0 VA: 0x1806E88B0
	public void .ctor() { }

}

public class BuildingGradeDecay : Decay // TypeDefIndex: 9527
{	// Fields
	public BuildingGrade.Enum decayGrade; // 0x98

	// Methods

	// RVA: 0x6E88B0 Offset: 0x6E6EB0 VA: 0x1806E88B0
	public void .ctor() { }

}

public abstract class BuildingManager // TypeDefIndex: 9826
{	// Fields
	public static ClientBuildingManager client; // 0x0
	protected ListHashSet<DecayEntity> decayEntities; // 0x10
	protected ListDictionary<uint, BuildingManager.Building> buildingDictionary; // 0x18

	// Methods

	// RVA: 0x6EC810 Offset: 0x6EAE10 VA: 0x1806EC810
	public BuildingManager.Building GetBuilding(uint buildingID) { }

	// RVA: 0x6EC670 Offset: 0x6EAC70 VA: 0x1806EC670
	public void Add(DecayEntity ent) { }

	// RVA: 0x6EC880 Offset: 0x6EAE80 VA: 0x1806EC880
	public void Remove(DecayEntity ent) { }

	// RVA: 0x6EC7C0 Offset: 0x6EADC0 VA: 0x1806EC7C0
	public void Clear() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract BuildingManager.Building CreateBuilding(uint id);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void DisposeBuilding(ref BuildingManager.Building building);

	// RVA: 0x6ECAD0 Offset: 0x6EB0D0 VA: 0x1806ECAD0
	protected void .ctor() { }

	// RVA: 0x6ECA70 Offset: 0x6EB070 VA: 0x1806ECA70
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

	// RVA: 0x6EFC60 Offset: 0x6EE260 VA: 0x1806EFC60
	public bool IsEmpty() { }

	// RVA: 0x6EFA40 Offset: 0x6EE040 VA: 0x1806EFA40
	public BuildingPrivlidge GetDominatingBuildingPrivilege() { }

	// RVA: 0x6EFBC0 Offset: 0x6EE1C0 VA: 0x1806EFBC0
	public bool HasBuildingPrivileges() { }

	// RVA: 0x6EFB70 Offset: 0x6EE170 VA: 0x1806EFB70
	public bool HasBuildingBlocks() { }

	// RVA: 0x6EFC10 Offset: 0x6EE210 VA: 0x1806EFC10
	public bool HasDecayEntities() { }

	// RVA: 0x6EF620 Offset: 0x6EDC20 VA: 0x1806EF620
	public void AddBuildingPrivilege(BuildingPrivlidge ent) { }

	// RVA: 0x6EFDB0 Offset: 0x6EE3B0 VA: 0x1806EFDB0
	public void RemoveBuildingPrivilege(BuildingPrivlidge ent) { }

	// RVA: 0x6EF580 Offset: 0x6EDB80 VA: 0x1806EF580
	public void AddBuildingBlock(BuildingBlock ent) { }

	// RVA: 0x6EFD20 Offset: 0x6EE320 VA: 0x1806EFD20
	public void RemoveBuildingBlock(BuildingBlock ent) { }

	// RVA: 0x6EF6C0 Offset: 0x6EDCC0 VA: 0x1806EF6C0
	public void AddDecayEntity(DecayEntity ent) { }

	// RVA: 0x6EFE40 Offset: 0x6EE440 VA: 0x1806EFE40
	public void RemoveDecayEntity(DecayEntity ent) { }

	// RVA: 0x6EF760 Offset: 0x6EDD60 VA: 0x1806EF760
	public void Add(DecayEntity ent) { }

	// RVA: 0x6EFED0 Offset: 0x6EE4D0 VA: 0x1806EFED0
	public void Remove(DecayEntity ent) { }

	// RVA: 0x6EF9C0 Offset: 0x6EDFC0 VA: 0x1806EF9C0
	public void Dirty() { }

	// RVA: 0x6F00D0 Offset: 0x6EE6D0 VA: 0x1806F00D0
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

