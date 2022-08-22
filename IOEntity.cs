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

	// RVA: 0x1C04900 Offset: 0x1C02F00 VA: 0x181C04900
	public static void ResetToPool(IOEntity instance) { }

	// RVA: 0x1C04590 Offset: 0x1C02B90 VA: 0x181C04590
	public void ResetToPool() { }

	// RVA: 0x1C044D0 Offset: 0x1C02AD0 VA: 0x181C044D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C02E30 Offset: 0x1C01430 VA: 0x181C02E30
	public void CopyTo(IOEntity instance) { }

	// RVA: 0x1C03140 Offset: 0x1C01740 VA: 0x181C03140
	public IOEntity Copy() { }

	// RVA: 0x1C03EB0 Offset: 0x1C024B0 VA: 0x181C03EB0
	public static IOEntity Deserialize(Stream stream) { }

	// RVA: 0x1C031C0 Offset: 0x1C017C0 VA: 0x181C031C0
	public static IOEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C037B0 Offset: 0x1C01DB0 VA: 0x181C037B0
	public static IOEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C03D90 Offset: 0x1C02390 VA: 0x181C03D90
	public static IOEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1C04550 Offset: 0x1C02B50 VA: 0x181C04550
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C058B0 Offset: 0x1C03EB0 VA: 0x181C058B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C058D0 Offset: 0x1C03ED0 VA: 0x181C058D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity previous) { }

	// RVA: 0x1C04570 Offset: 0x1C02B70 VA: 0x181C04570 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C043D0 Offset: 0x1C029D0 VA: 0x181C043D0
	public static IOEntity Deserialize(byte[] buffer, IOEntity instance, bool isDelta = False) { }

	// RVA: 0x1C03F30 Offset: 0x1C02530 VA: 0x181C03F30
	public static IOEntity Deserialize(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C03240 Offset: 0x1C01840 VA: 0x181C03240
	public static IOEntity DeserializeLengthDelimited(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C03840 Offset: 0x1C01E40 VA: 0x181C03840
	public static IOEntity DeserializeLength(Stream stream, int length, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C04C70 Offset: 0x1C03270 VA: 0x181C04C70
	public static void SerializeDelta(Stream stream, IOEntity instance, IOEntity previous) { }

	// RVA: 0x1C05440 Offset: 0x1C03A40 VA: 0x181C05440
	public static void Serialize(Stream stream, IOEntity instance) { }

	// RVA: 0x1C058A0 Offset: 0x1C03EA0 VA: 0x181C058A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C058B0 Offset: 0x1C03EB0 VA: 0x181C058B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C05330 Offset: 0x1C03930 VA: 0x181C05330
	public static byte[] SerializeToBytes(IOEntity instance) { }

	// RVA: 0x1C05280 Offset: 0x1C03880 VA: 0x181C05280
	public static void SerializeLengthDelimited(Stream stream, IOEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1C02070 Offset: 0x1C00670 VA: 0x181C02070
	public static void ResetToPool(IOEntity.IOConnection instance) { }

	// RVA: 0x1C022B0 Offset: 0x1C008B0 VA: 0x181C022B0
	public void ResetToPool() { }

	// RVA: 0x1C01C40 Offset: 0x1C00240 VA: 0x181C01C40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C00090 Offset: 0x1BFE690 VA: 0x181C00090
	public void CopyTo(IOEntity.IOConnection instance) { }

	// RVA: 0x1C00240 Offset: 0x1BFE840 VA: 0x181C00240
	public IOEntity.IOConnection Copy() { }

	// RVA: 0x1C01480 Offset: 0x1BFFA80 VA: 0x181C01480
	public static IOEntity.IOConnection Deserialize(Stream stream) { }

	// RVA: 0x1C00730 Offset: 0x1BFED30 VA: 0x181C00730
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C007B0 Offset: 0x1BFEDB0 VA: 0x181C007B0
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C01810 Offset: 0x1BFFE10 VA: 0x181C01810
	public static IOEntity.IOConnection Deserialize(byte[] buffer) { }

	// RVA: 0x1C01CC0 Offset: 0x1C002C0 VA: 0x181C01CC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C02DF0 Offset: 0x1C013F0 VA: 0x181C02DF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C02E10 Offset: 0x1C01410 VA: 0x181C02E10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection previous) { }

	// RVA: 0x1C02050 Offset: 0x1C00650 VA: 0x181C02050 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C00C80 Offset: 0x1BFF280 VA: 0x181C00C80
	public static IOEntity.IOConnection Deserialize(byte[] buffer, IOEntity.IOConnection instance, bool isDelta = False) { }

	// RVA: 0x1C010F0 Offset: 0x1BFF6F0 VA: 0x181C010F0
	public static IOEntity.IOConnection Deserialize(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1C002C0 Offset: 0x1BFE8C0 VA: 0x181C002C0
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1C00840 Offset: 0x1BFEE40 VA: 0x181C00840
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1C024F0 Offset: 0x1C00AF0 VA: 0x181C024F0
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection instance, IOEntity.IOConnection previous) { }

	// RVA: 0x1C02AB0 Offset: 0x1C010B0 VA: 0x181C02AB0
	public static void Serialize(Stream stream, IOEntity.IOConnection instance) { }

	// RVA: 0x1C02DE0 Offset: 0x1C013E0 VA: 0x181C02DE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C02DF0 Offset: 0x1C013F0 VA: 0x181C02DF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C029A0 Offset: 0x1C00FA0 VA: 0x181C029A0
	public static byte[] SerializeToBytes(IOEntity.IOConnection instance) { }

	// RVA: 0x1C028F0 Offset: 0x1C00EF0 VA: 0x181C028F0
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class IOEntity.IOConnection.LineVec : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6356
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector4 vec; // 0x14

	// Methods

	// RVA: 0x1C15EE0 Offset: 0x1C144E0 VA: 0x181C15EE0
	public static void ResetToPool(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C15E60 Offset: 0x1C14460 VA: 0x181C15E60
	public void ResetToPool() { }

	// RVA: 0x1C15DA0 Offset: 0x1C143A0 VA: 0x181C15DA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C15400 Offset: 0x1C13A00 VA: 0x181C15400
	public void CopyTo(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C15420 Offset: 0x1C13A20 VA: 0x181C15420
	public IOEntity.IOConnection.LineVec Copy() { }

	// RVA: 0x1C159B0 Offset: 0x1C13FB0 VA: 0x181C159B0
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream) { }

	// RVA: 0x1C156B0 Offset: 0x1C13CB0 VA: 0x181C156B0
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C15730 Offset: 0x1C13D30 VA: 0x181C15730
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C15C80 Offset: 0x1C14280 VA: 0x181C15C80
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer) { }

	// RVA: 0x1C15E20 Offset: 0x1C14420 VA: 0x181C15E20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C164C0 Offset: 0x1C14AC0 VA: 0x181C164C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C164E0 Offset: 0x1C14AE0 VA: 0x181C164E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C15E40 Offset: 0x1C14440 VA: 0x181C15E40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C15A30 Offset: 0x1C14030 VA: 0x181C15A30
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer, IOEntity.IOConnection.LineVec instance, bool isDelta = False) { }

	// RVA: 0x1C15B30 Offset: 0x1C14130 VA: 0x181C15B30
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C15490 Offset: 0x1C13A90 VA: 0x181C15490
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C157C0 Offset: 0x1C13DC0 VA: 0x181C157C0
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C15F60 Offset: 0x1C14560 VA: 0x181C15F60
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LineVec instance, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C16340 Offset: 0x1C14940 VA: 0x181C16340
	public static void Serialize(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C164B0 Offset: 0x1C14AB0 VA: 0x181C164B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C164C0 Offset: 0x1C14AC0 VA: 0x181C164C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C16230 Offset: 0x1C14830 VA: 0x181C16230
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C16180 Offset: 0x1C14780 VA: 0x181C16180
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1C14000 Offset: 0x1C12600 VA: 0x181C14000
	public static void ResetToPool(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C13F10 Offset: 0x1C12510 VA: 0x181C13F10
	public void ResetToPool() { }

	// RVA: 0x1C13750 Offset: 0x1C11D50 VA: 0x181C13750 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C11AA0 Offset: 0x1C100A0 VA: 0x181C11AA0
	public void CopyTo(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C11B00 Offset: 0x1C10100 VA: 0x181C11B00
	public IOEntity.IOConnection.LinePointList Copy() { }

	// RVA: 0x1C12A40 Offset: 0x1C11040 VA: 0x181C12A40
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream) { }

	// RVA: 0x1C11BB0 Offset: 0x1C101B0 VA: 0x181C11BB0
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C12690 Offset: 0x1C10C90 VA: 0x181C12690
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C13010 Offset: 0x1C11610 VA: 0x181C13010
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer) { }

	// RVA: 0x1C138D0 Offset: 0x1C11ED0 VA: 0x181C138D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C153C0 Offset: 0x1C139C0 VA: 0x181C153C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C153E0 Offset: 0x1C139E0 VA: 0x181C153E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C13BA0 Offset: 0x1C121A0 VA: 0x181C13BA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C133C0 Offset: 0x1C119C0 VA: 0x181C133C0
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer, IOEntity.IOConnection.LinePointList instance, bool isDelta = False) { }

	// RVA: 0x1C12D40 Offset: 0x1C11340 VA: 0x181C12D40
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C11F90 Offset: 0x1C10590 VA: 0x181C11F90
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C12320 Offset: 0x1C10920 VA: 0x181C12320
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C140F0 Offset: 0x1C126F0 VA: 0x181C140F0
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LinePointList instance, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C14D30 Offset: 0x1C13330 VA: 0x181C14D30
	public static void Serialize(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C153B0 Offset: 0x1C139B0 VA: 0x181C153B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C153C0 Offset: 0x1C139C0 VA: 0x181C153C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C14C20 Offset: 0x1C13220 VA: 0x181C14C20
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C14B70 Offset: 0x1C13170 VA: 0x181C14B70
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x748140 Offset: 0x746740 VA: 0x180748140 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x748770 Offset: 0x746D70 VA: 0x180748770 Slot: 27
	public override void ResetState() { }

	// RVA: 0x746E70 Offset: 0x745470 VA: 0x180746E70
	public string GetDisplayName() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 145
	public virtual bool IsRootEntity() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 146
	public virtual bool get_IsGravitySource() { }

	// RVA: 0x746960 Offset: 0x744F60 VA: 0x180746960
	public IOEntity FindGravitySource(ref Vector3 worldHandlePosition, int depth, bool ignoreSelf) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 147
	public virtual void SetFuelType(ItemDefinition def, IOEntity source) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 148
	public virtual bool WantsPower() { }

	// RVA: 0x7487B0 Offset: 0x746DB0 VA: 0x1807487B0 Slot: 149
	public virtual bool WantsPassthroughPower() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 150
	public virtual int ConsumptionAmount() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 151
	public virtual int MaximalPowerOutput() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 152
	public virtual bool AllowDrainFrom(int outputSlot) { }

	// RVA: 0x557BF0 Offset: 0x5561F0 VA: 0x180557BF0 Slot: 153
	public virtual bool IsPowered() { }

	// RVA: 0x7470F0 Offset: 0x7456F0 VA: 0x1807470F0
	public bool IsConnectedToAnySlot(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	// RVA: 0x747410 Offset: 0x745A10 VA: 0x180747410
	public bool IsConnectedTo(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	// RVA: 0x747250 Offset: 0x745850 VA: 0x180747250
	public bool IsConnectedTo(IOEntity entity, int depth, bool defaultReturn = False) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 154
	protected virtual bool ConsiderConnectedTo(IOEntity entity) { }

	// RVA: 0x748630 Offset: 0x746C30 VA: 0x180748630
	public void RequestAdditionalData(int slot, bool input) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7467F0 Offset: 0x744DF0 VA: 0x1807467F0
	private void Client_ReceiveAdditionalData(BaseEntity.RPCMessage msg) { }

	// RVA: 0x748620 Offset: 0x746C20 VA: 0x180748620 Slot: 155
	public virtual void ProcessAdditionalData(int first, int second, float third, float fourth) { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 156
	protected virtual float get_LiquidPassthroughGravityThreshold() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 157
	protected virtual bool get_DisregardGravityRestrictionsOnLiquid() { }

	// RVA: 0x7466A0 Offset: 0x744CA0 VA: 0x1807466A0 Slot: 158
	public virtual bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	// RVA: 0x747580 Offset: 0x745B80 VA: 0x180747580 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x746C70 Offset: 0x745270 VA: 0x180746C70
	public int GetConnectedInputCount() { }

	// RVA: 0x746D70 Offset: 0x745370 VA: 0x180746D70
	public int GetConnectedOutputCount() { }

	// RVA: 0x746F20 Offset: 0x745520 VA: 0x180746F20
	public bool HasConnections() { }

	// RVA: 0x7468E0 Offset: 0x744EE0 VA: 0x1807468E0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x748830 Offset: 0x746E30 VA: 0x180748830
	public void .ctor() { }

	// RVA: 0x7487D0 Offset: 0x746DD0 VA: 0x1807487D0
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

	// RVA: 0x748A00 Offset: 0x747000 VA: 0x180748A00
	public void Init() { }

	// RVA: 0x748940 Offset: 0x746F40 VA: 0x180748940
	public void InitClient() { }

	// RVA: 0x748870 Offset: 0x746E70 VA: 0x180748870
	public IOEntity Get(bool isServer = True) { }

	// RVA: 0x748840 Offset: 0x746E40 VA: 0x180748840
	public void Clear() { }

	// RVA: 0x748AE0 Offset: 0x7470E0 VA: 0x180748AE0
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

	// RVA: 0x748E40 Offset: 0x747440 VA: 0x180748E40
	public void OnDestroy() { }

	// RVA: 0x748BE0 Offset: 0x7471E0 VA: 0x180748BE0
	public void Clear() { }

	// RVA: 0x748AF0 Offset: 0x7470F0 VA: 0x180748AF0
	public void CleanupLines() { }

	// RVA: 0x748E50 Offset: 0x747450 VA: 0x180748E50
	public void UpdateLines(Transform transform) { }

	// RVA: 0x748CB0 Offset: 0x7472B0 VA: 0x180748CB0
	public float GetLength() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

