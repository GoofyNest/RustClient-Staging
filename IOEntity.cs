public class IOEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6354
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<IOEntity.IOConnection> inputs; // 0x18
	public List<IOEntity.IOConnection> outputs; // 0x20
	public uint genericEntRef1; // 0x28
	public uint genericEntRef2; // 0x2C
	public uint genericEntRef3; // 0x30
	public int genericInt1; // 0x34
	public int genericInt2; // 0x38
	public float genericFloat1; // 0x3C
	public float genericFloat2; // 0x40
	public int genericInt3; // 0x44

	// Methods

	// RVA: 0x1C04110 Offset: 0x1C02710 VA: 0x181C04110
	public static void ResetToPool(IOEntity instance) { }

	// RVA: 0x1C03DA0 Offset: 0x1C023A0 VA: 0x181C03DA0
	public void ResetToPool() { }

	// RVA: 0x1C03CE0 Offset: 0x1C022E0 VA: 0x181C03CE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C02640 Offset: 0x1C00C40 VA: 0x181C02640
	public void CopyTo(IOEntity instance) { }

	// RVA: 0x1C02950 Offset: 0x1C00F50 VA: 0x181C02950
	public IOEntity Copy() { }

	// RVA: 0x1C036C0 Offset: 0x1C01CC0 VA: 0x181C036C0
	public static IOEntity Deserialize(Stream stream) { }

	// RVA: 0x1C029D0 Offset: 0x1C00FD0 VA: 0x181C029D0
	public static IOEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C02FC0 Offset: 0x1C015C0 VA: 0x181C02FC0
	public static IOEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C035A0 Offset: 0x1C01BA0 VA: 0x181C035A0
	public static IOEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1C03D60 Offset: 0x1C02360 VA: 0x181C03D60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C050C0 Offset: 0x1C036C0 VA: 0x181C050C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C050E0 Offset: 0x1C036E0 VA: 0x181C050E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity previous) { }

	// RVA: 0x1C03D80 Offset: 0x1C02380 VA: 0x181C03D80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C03BE0 Offset: 0x1C021E0 VA: 0x181C03BE0
	public static IOEntity Deserialize(byte[] buffer, IOEntity instance, bool isDelta = False) { }

	// RVA: 0x1C03740 Offset: 0x1C01D40 VA: 0x181C03740
	public static IOEntity Deserialize(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C02A50 Offset: 0x1C01050 VA: 0x181C02A50
	public static IOEntity DeserializeLengthDelimited(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C03050 Offset: 0x1C01650 VA: 0x181C03050
	public static IOEntity DeserializeLength(Stream stream, int length, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C04480 Offset: 0x1C02A80 VA: 0x181C04480
	public static void SerializeDelta(Stream stream, IOEntity instance, IOEntity previous) { }

	// RVA: 0x1C04C50 Offset: 0x1C03250 VA: 0x181C04C50
	public static void Serialize(Stream stream, IOEntity instance) { }

	// RVA: 0x1C050B0 Offset: 0x1C036B0 VA: 0x181C050B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C050C0 Offset: 0x1C036C0 VA: 0x181C050C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C04B40 Offset: 0x1C03140 VA: 0x181C04B40
	public static byte[] SerializeToBytes(IOEntity instance) { }

	// RVA: 0x1C04A90 Offset: 0x1C03090 VA: 0x181C04A90
	public static void SerializeLengthDelimited(Stream stream, IOEntity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class IOEntity.IOConnection : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6355
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string niceName; // 0x18
	public int type; // 0x20
	public uint connectedID; // 0x24
	public int connectedToSlot; // 0x28
	public bool inUse; // 0x2C
	public List<IOEntity.IOConnection.LineVec> linePointList; // 0x30
	public int colour; // 0x38

	// Methods

	// RVA: 0x1C01880 Offset: 0x1BFFE80 VA: 0x181C01880
	public static void ResetToPool(IOEntity.IOConnection instance) { }

	// RVA: 0x1C01AC0 Offset: 0x1C000C0 VA: 0x181C01AC0
	public void ResetToPool() { }

	// RVA: 0x1C01450 Offset: 0x1BFFA50 VA: 0x181C01450 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFF8A0 Offset: 0x1BFDEA0 VA: 0x181BFF8A0
	public void CopyTo(IOEntity.IOConnection instance) { }

	// RVA: 0x1BFFA50 Offset: 0x1BFE050 VA: 0x181BFFA50
	public IOEntity.IOConnection Copy() { }

	// RVA: 0x1C00C90 Offset: 0x1BFF290 VA: 0x181C00C90
	public static IOEntity.IOConnection Deserialize(Stream stream) { }

	// RVA: 0x1BFFF40 Offset: 0x1BFE540 VA: 0x181BFFF40
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFFFC0 Offset: 0x1BFE5C0 VA: 0x181BFFFC0
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C01020 Offset: 0x1BFF620 VA: 0x181C01020
	public static IOEntity.IOConnection Deserialize(byte[] buffer) { }

	// RVA: 0x1C014D0 Offset: 0x1BFFAD0 VA: 0x181C014D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C02600 Offset: 0x1C00C00 VA: 0x181C02600 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C02620 Offset: 0x1C00C20 VA: 0x181C02620 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection previous) { }

	// RVA: 0x1C01860 Offset: 0x1BFFE60 VA: 0x181C01860 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C00490 Offset: 0x1BFEA90 VA: 0x181C00490
	public static IOEntity.IOConnection Deserialize(byte[] buffer, IOEntity.IOConnection instance, bool isDelta = False) { }

	// RVA: 0x1C00900 Offset: 0x1BFEF00 VA: 0x181C00900
	public static IOEntity.IOConnection Deserialize(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1BFFAD0 Offset: 0x1BFE0D0 VA: 0x181BFFAD0
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1C00050 Offset: 0x1BFE650 VA: 0x181C00050
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1C01D00 Offset: 0x1C00300 VA: 0x181C01D00
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection instance, IOEntity.IOConnection previous) { }

	// RVA: 0x1C022C0 Offset: 0x1C008C0 VA: 0x181C022C0
	public static void Serialize(Stream stream, IOEntity.IOConnection instance) { }

	// RVA: 0x1C025F0 Offset: 0x1C00BF0 VA: 0x181C025F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C02600 Offset: 0x1C00C00 VA: 0x181C02600
	public void ToProto(Stream stream) { }

	// RVA: 0x1C021B0 Offset: 0x1C007B0 VA: 0x181C021B0
	public static byte[] SerializeToBytes(IOEntity.IOConnection instance) { }

	// RVA: 0x1C02100 Offset: 0x1C00700 VA: 0x181C02100
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class IOEntity.IOConnection.LineVec : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6356
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector4 vec; // 0x14

	// Methods

	// RVA: 0x1C156F0 Offset: 0x1C13CF0 VA: 0x181C156F0
	public static void ResetToPool(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C15670 Offset: 0x1C13C70 VA: 0x181C15670
	public void ResetToPool() { }

	// RVA: 0x1C155B0 Offset: 0x1C13BB0 VA: 0x181C155B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C14C10 Offset: 0x1C13210 VA: 0x181C14C10
	public void CopyTo(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C14C30 Offset: 0x1C13230 VA: 0x181C14C30
	public IOEntity.IOConnection.LineVec Copy() { }

	// RVA: 0x1C151C0 Offset: 0x1C137C0 VA: 0x181C151C0
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream) { }

	// RVA: 0x1C14EC0 Offset: 0x1C134C0 VA: 0x181C14EC0
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C14F40 Offset: 0x1C13540 VA: 0x181C14F40
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C15490 Offset: 0x1C13A90 VA: 0x181C15490
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer) { }

	// RVA: 0x1C15630 Offset: 0x1C13C30 VA: 0x181C15630
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C15CD0 Offset: 0x1C142D0 VA: 0x181C15CD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C15CF0 Offset: 0x1C142F0 VA: 0x181C15CF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C15650 Offset: 0x1C13C50 VA: 0x181C15650 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C15240 Offset: 0x1C13840 VA: 0x181C15240
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer, IOEntity.IOConnection.LineVec instance, bool isDelta = False) { }

	// RVA: 0x1C15340 Offset: 0x1C13940 VA: 0x181C15340
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C14CA0 Offset: 0x1C132A0 VA: 0x181C14CA0
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C14FD0 Offset: 0x1C135D0 VA: 0x181C14FD0
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C15770 Offset: 0x1C13D70 VA: 0x181C15770
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LineVec instance, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C15B50 Offset: 0x1C14150 VA: 0x181C15B50
	public static void Serialize(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C15CC0 Offset: 0x1C142C0 VA: 0x181C15CC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C15CD0 Offset: 0x1C142D0 VA: 0x181C15CD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C15A40 Offset: 0x1C14040 VA: 0x181C15A40
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C15990 Offset: 0x1C13F90 VA: 0x181C15990
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class IOEntity.IOConnection.LinePointList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6357
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector4 a; // 0x14
	public Vector4 b; // 0x24
	public Vector4 c; // 0x34
	public Vector4 d; // 0x44
	public Vector4 e; // 0x54
	public Vector4 f; // 0x64
	public Vector4 g; // 0x74
	public Vector4 h; // 0x84

	// Methods

	// RVA: 0x1C13810 Offset: 0x1C11E10 VA: 0x181C13810
	public static void ResetToPool(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C13720 Offset: 0x1C11D20 VA: 0x181C13720
	public void ResetToPool() { }

	// RVA: 0x1C12F60 Offset: 0x1C11560 VA: 0x181C12F60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C112B0 Offset: 0x1C0F8B0 VA: 0x181C112B0
	public void CopyTo(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C11310 Offset: 0x1C0F910 VA: 0x181C11310
	public IOEntity.IOConnection.LinePointList Copy() { }

	// RVA: 0x1C12250 Offset: 0x1C10850 VA: 0x181C12250
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream) { }

	// RVA: 0x1C113C0 Offset: 0x1C0F9C0 VA: 0x181C113C0
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C11EA0 Offset: 0x1C104A0 VA: 0x181C11EA0
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C12820 Offset: 0x1C10E20 VA: 0x181C12820
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer) { }

	// RVA: 0x1C130E0 Offset: 0x1C116E0 VA: 0x181C130E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C14BD0 Offset: 0x1C131D0 VA: 0x181C14BD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C14BF0 Offset: 0x1C131F0 VA: 0x181C14BF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C133B0 Offset: 0x1C119B0 VA: 0x181C133B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C12BD0 Offset: 0x1C111D0 VA: 0x181C12BD0
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer, IOEntity.IOConnection.LinePointList instance, bool isDelta = False) { }

	// RVA: 0x1C12550 Offset: 0x1C10B50 VA: 0x181C12550
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C117A0 Offset: 0x1C0FDA0 VA: 0x181C117A0
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C11B30 Offset: 0x1C10130 VA: 0x181C11B30
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C13900 Offset: 0x1C11F00 VA: 0x181C13900
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LinePointList instance, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C14540 Offset: 0x1C12B40 VA: 0x181C14540
	public static void Serialize(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C14BC0 Offset: 0x1C131C0 VA: 0x181C14BC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C14BD0 Offset: 0x1C131D0 VA: 0x181C14BD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C14430 Offset: 0x1C12A30 VA: 0x181C14430
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C14380 Offset: 0x1C12980 VA: 0x181C14380
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class IOEntity : DecayEntity // TypeDefIndex: 8587
{	// Fields
	[HeaderAttribute] // RVA: 0xAE9A0 Offset: 0xADDA0 VA: 0x1800AE9A0
	public Transform debugOrigin; // 0x258
	public ItemDefinition sourceItem; // 0x260
	[ServerVar] // RVA: 0xAFDA0 Offset: 0xAF1A0 VA: 0x1800AFDA0
	[HelpAttribute] // RVA: 0xAFDA0 Offset: 0xAF1A0 VA: 0x1800AFDA0
	public static float framebudgetms; // 0x0
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float responsetime; // 0x4
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int backtracking; // 0x8
	public const BaseEntity.Flags Flag_ShortCircuit = 32768;
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public IOEntity.IOSlot[] inputs; // 0x268
	public IOEntity.IOSlot[] outputs; // 0x270
	public IOEntity.IOType ioType; // 0x278
	public int client_powerin; // 0x27C
	public int client_slotpower; // 0x280
	public bool client_extradata_dirty; // 0x284

	// Properties
	public virtual bool IsGravitySource { get; }
	protected virtual float LiquidPassthroughGravityThreshold { get; }
	protected virtual bool DisregardGravityRestrictionsOnLiquid { get; }

	// Methods

	// RVA: 0x7481F0 Offset: 0x7467F0 VA: 0x1807481F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x748820 Offset: 0x746E20 VA: 0x180748820 Slot: 27
	public override void ResetState() { }

	// RVA: 0x746F20 Offset: 0x745520 VA: 0x180746F20
	public string GetDisplayName() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 145
	public virtual bool IsRootEntity() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 146
	public virtual bool get_IsGravitySource() { }

	// RVA: 0x746A10 Offset: 0x745010 VA: 0x180746A10
	public IOEntity FindGravitySource(ref Vector3 worldHandlePosition, int depth, bool ignoreSelf) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 147
	public virtual void SetFuelType(ItemDefinition def, IOEntity source) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 148
	public virtual bool WantsPower() { }

	// RVA: 0x748860 Offset: 0x746E60 VA: 0x180748860 Slot: 149
	public virtual bool WantsPassthroughPower() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 150
	public virtual int ConsumptionAmount() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 151
	public virtual int MaximalPowerOutput() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 152
	public virtual bool AllowDrainFrom(int outputSlot) { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60 Slot: 153
	public virtual bool IsPowered() { }

	// RVA: 0x7471A0 Offset: 0x7457A0 VA: 0x1807471A0
	public bool IsConnectedToAnySlot(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	// RVA: 0x7474C0 Offset: 0x745AC0 VA: 0x1807474C0
	public bool IsConnectedTo(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	// RVA: 0x747300 Offset: 0x745900 VA: 0x180747300
	public bool IsConnectedTo(IOEntity entity, int depth, bool defaultReturn = False) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 154
	protected virtual bool ConsiderConnectedTo(IOEntity entity) { }

	// RVA: 0x7486E0 Offset: 0x746CE0 VA: 0x1807486E0
	public void RequestAdditionalData(int slot, bool input) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7468A0 Offset: 0x744EA0 VA: 0x1807468A0
	private void Client_ReceiveAdditionalData(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7486D0 Offset: 0x746CD0 VA: 0x1807486D0 Slot: 155
	public virtual void ProcessAdditionalData(int first, int second, float third, float fourth) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 156
	protected virtual float get_LiquidPassthroughGravityThreshold() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 157
	protected virtual bool get_DisregardGravityRestrictionsOnLiquid() { }

	// RVA: 0x746750 Offset: 0x744D50 VA: 0x180746750 Slot: 158
	public virtual bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	// RVA: 0x747630 Offset: 0x745C30 VA: 0x180747630 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x746D20 Offset: 0x745320 VA: 0x180746D20
	public int GetConnectedInputCount() { }

	// RVA: 0x746E20 Offset: 0x745420 VA: 0x180746E20
	public int GetConnectedOutputCount() { }

	// RVA: 0x746FD0 Offset: 0x7455D0 VA: 0x180746FD0
	public bool HasConnections() { }

	// RVA: 0x746990 Offset: 0x744F90 VA: 0x180746990 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7488E0 Offset: 0x746EE0 VA: 0x1807488E0
	public void .ctor() { }

	// RVA: 0x748880 Offset: 0x746E80 VA: 0x180748880
	private static void .cctor() { }

}

public enum IOEntity.IOType // TypeDefIndex: 8588
{	// Fields
	public int value__; // 0x0
	public const IOEntity.IOType Electric = 0;
	public const IOEntity.IOType Fluidic = 1;
	public const IOEntity.IOType Kinetic = 2;
	public const IOEntity.IOType Generic = 3;

}

public class IOEntity.IORef // TypeDefIndex: 8589
{	// Fields
	public EntityRef entityRef; // 0x10
	public IOEntity ioEnt; // 0x20

	// Methods

	// RVA: 0x748AB0 Offset: 0x7470B0 VA: 0x180748AB0
	public void Init() { }

	// RVA: 0x7489F0 Offset: 0x746FF0 VA: 0x1807489F0
	public void InitClient() { }

	// RVA: 0x748920 Offset: 0x746F20 VA: 0x180748920
	public IOEntity Get(bool isServer = True) { }

	// RVA: 0x7488F0 Offset: 0x746EF0 VA: 0x1807488F0
	public void Clear() { }

	// RVA: 0x748B90 Offset: 0x747190 VA: 0x180748B90
	public void Set(IOEntity newIOEnt) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class IOEntity.IOSlot // TypeDefIndex: 8590
{	// Fields
	public string niceName; // 0x10
	public IOEntity.IOType type; // 0x18
	public IOEntity.IORef connectedTo; // 0x20
	public int connectedToSlot; // 0x28
	public Vector3[] linePoints; // 0x30
	public float[] slackLevels; // 0x38
	public ClientIOLine line; // 0x40
	public Vector3 handlePosition; // 0x48
	public bool rootConnectionsOnly; // 0x54
	public bool mainPowerSlot; // 0x55
	public WireTool.WireColour wireColour; // 0x58

	// Methods

	// RVA: 0x748EF0 Offset: 0x7474F0 VA: 0x180748EF0
	public void OnDestroy() { }

	// RVA: 0x748C90 Offset: 0x747290 VA: 0x180748C90
	public void Clear() { }

	// RVA: 0x748BA0 Offset: 0x7471A0 VA: 0x180748BA0
	public void CleanupLines() { }

	// RVA: 0x748F00 Offset: 0x747500 VA: 0x180748F00
	public void UpdateLines(Transform transform) { }

	// RVA: 0x748D60 Offset: 0x747360 VA: 0x180748D60
	public float GetLength() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

