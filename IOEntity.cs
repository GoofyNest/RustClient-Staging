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

	// RVA: 0x1C03E50 Offset: 0x1C02450 VA: 0x181C03E50
	public static void ResetToPool(IOEntity instance) { }

	// RVA: 0x1C03AE0 Offset: 0x1C020E0 VA: 0x181C03AE0
	public void ResetToPool() { }

	// RVA: 0x1C03A20 Offset: 0x1C02020 VA: 0x181C03A20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C02380 Offset: 0x1C00980 VA: 0x181C02380
	public void CopyTo(IOEntity instance) { }

	// RVA: 0x1C02690 Offset: 0x1C00C90 VA: 0x181C02690
	public IOEntity Copy() { }

	// RVA: 0x1C03400 Offset: 0x1C01A00 VA: 0x181C03400
	public static IOEntity Deserialize(Stream stream) { }

	// RVA: 0x1C02710 Offset: 0x1C00D10 VA: 0x181C02710
	public static IOEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C02D00 Offset: 0x1C01300 VA: 0x181C02D00
	public static IOEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C032E0 Offset: 0x1C018E0 VA: 0x181C032E0
	public static IOEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1C03AA0 Offset: 0x1C020A0 VA: 0x181C03AA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C04E00 Offset: 0x1C03400 VA: 0x181C04E00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C04E20 Offset: 0x1C03420 VA: 0x181C04E20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity previous) { }

	// RVA: 0x1C03AC0 Offset: 0x1C020C0 VA: 0x181C03AC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C03920 Offset: 0x1C01F20 VA: 0x181C03920
	public static IOEntity Deserialize(byte[] buffer, IOEntity instance, bool isDelta = False) { }

	// RVA: 0x1C03480 Offset: 0x1C01A80 VA: 0x181C03480
	public static IOEntity Deserialize(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C02790 Offset: 0x1C00D90 VA: 0x181C02790
	public static IOEntity DeserializeLengthDelimited(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C02D90 Offset: 0x1C01390 VA: 0x181C02D90
	public static IOEntity DeserializeLength(Stream stream, int length, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C041C0 Offset: 0x1C027C0 VA: 0x181C041C0
	public static void SerializeDelta(Stream stream, IOEntity instance, IOEntity previous) { }

	// RVA: 0x1C04990 Offset: 0x1C02F90 VA: 0x181C04990
	public static void Serialize(Stream stream, IOEntity instance) { }

	// RVA: 0x1C04DF0 Offset: 0x1C033F0 VA: 0x181C04DF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C04E00 Offset: 0x1C03400 VA: 0x181C04E00
	public void ToProto(Stream stream) { }

	// RVA: 0x1C04880 Offset: 0x1C02E80 VA: 0x181C04880
	public static byte[] SerializeToBytes(IOEntity instance) { }

	// RVA: 0x1C047D0 Offset: 0x1C02DD0 VA: 0x181C047D0
	public static void SerializeLengthDelimited(Stream stream, IOEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1C015C0 Offset: 0x1BFFBC0 VA: 0x181C015C0
	public static void ResetToPool(IOEntity.IOConnection instance) { }

	// RVA: 0x1C01800 Offset: 0x1BFFE00 VA: 0x181C01800
	public void ResetToPool() { }

	// RVA: 0x1C01190 Offset: 0x1BFF790 VA: 0x181C01190 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFF5E0 Offset: 0x1BFDBE0 VA: 0x181BFF5E0
	public void CopyTo(IOEntity.IOConnection instance) { }

	// RVA: 0x1BFF790 Offset: 0x1BFDD90 VA: 0x181BFF790
	public IOEntity.IOConnection Copy() { }

	// RVA: 0x1C009D0 Offset: 0x1BFEFD0 VA: 0x181C009D0
	public static IOEntity.IOConnection Deserialize(Stream stream) { }

	// RVA: 0x1BFFC80 Offset: 0x1BFE280 VA: 0x181BFFC80
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFFD00 Offset: 0x1BFE300 VA: 0x181BFFD00
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C00D60 Offset: 0x1BFF360 VA: 0x181C00D60
	public static IOEntity.IOConnection Deserialize(byte[] buffer) { }

	// RVA: 0x1C01210 Offset: 0x1BFF810 VA: 0x181C01210
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C02340 Offset: 0x1C00940 VA: 0x181C02340 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C02360 Offset: 0x1C00960 VA: 0x181C02360 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection previous) { }

	// RVA: 0x1C015A0 Offset: 0x1BFFBA0 VA: 0x181C015A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C001D0 Offset: 0x1BFE7D0 VA: 0x181C001D0
	public static IOEntity.IOConnection Deserialize(byte[] buffer, IOEntity.IOConnection instance, bool isDelta = False) { }

	// RVA: 0x1C00640 Offset: 0x1BFEC40 VA: 0x181C00640
	public static IOEntity.IOConnection Deserialize(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1BFF810 Offset: 0x1BFDE10 VA: 0x181BFF810
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1BFFD90 Offset: 0x1BFE390 VA: 0x181BFFD90
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1C01A40 Offset: 0x1C00040 VA: 0x181C01A40
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection instance, IOEntity.IOConnection previous) { }

	// RVA: 0x1C02000 Offset: 0x1C00600 VA: 0x181C02000
	public static void Serialize(Stream stream, IOEntity.IOConnection instance) { }

	// RVA: 0x1C02330 Offset: 0x1C00930 VA: 0x181C02330
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C02340 Offset: 0x1C00940 VA: 0x181C02340
	public void ToProto(Stream stream) { }

	// RVA: 0x1C01EF0 Offset: 0x1C004F0 VA: 0x181C01EF0
	public static byte[] SerializeToBytes(IOEntity.IOConnection instance) { }

	// RVA: 0x1C01E40 Offset: 0x1C00440 VA: 0x181C01E40
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class IOEntity.IOConnection.LineVec : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6356
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector4 vec; // 0x14

	// Methods

	// RVA: 0x1C15430 Offset: 0x1C13A30 VA: 0x181C15430
	public static void ResetToPool(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C153B0 Offset: 0x1C139B0 VA: 0x181C153B0
	public void ResetToPool() { }

	// RVA: 0x1C152F0 Offset: 0x1C138F0 VA: 0x181C152F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C14950 Offset: 0x1C12F50 VA: 0x181C14950
	public void CopyTo(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C14970 Offset: 0x1C12F70 VA: 0x181C14970
	public IOEntity.IOConnection.LineVec Copy() { }

	// RVA: 0x1C14F00 Offset: 0x1C13500 VA: 0x181C14F00
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream) { }

	// RVA: 0x1C14C00 Offset: 0x1C13200 VA: 0x181C14C00
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C14C80 Offset: 0x1C13280 VA: 0x181C14C80
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C151D0 Offset: 0x1C137D0 VA: 0x181C151D0
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer) { }

	// RVA: 0x1C15370 Offset: 0x1C13970 VA: 0x181C15370
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C15A10 Offset: 0x1C14010 VA: 0x181C15A10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C15A30 Offset: 0x1C14030 VA: 0x181C15A30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C15390 Offset: 0x1C13990 VA: 0x181C15390 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C14F80 Offset: 0x1C13580 VA: 0x181C14F80
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer, IOEntity.IOConnection.LineVec instance, bool isDelta = False) { }

	// RVA: 0x1C15080 Offset: 0x1C13680 VA: 0x181C15080
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C149E0 Offset: 0x1C12FE0 VA: 0x181C149E0
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C14D10 Offset: 0x1C13310 VA: 0x181C14D10
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C154B0 Offset: 0x1C13AB0 VA: 0x181C154B0
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LineVec instance, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C15890 Offset: 0x1C13E90 VA: 0x181C15890
	public static void Serialize(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C15A00 Offset: 0x1C14000 VA: 0x181C15A00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C15A10 Offset: 0x1C14010 VA: 0x181C15A10
	public void ToProto(Stream stream) { }

	// RVA: 0x1C15780 Offset: 0x1C13D80 VA: 0x181C15780
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C156D0 Offset: 0x1C13CD0 VA: 0x181C156D0
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1C13550 Offset: 0x1C11B50 VA: 0x181C13550
	public static void ResetToPool(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C13460 Offset: 0x1C11A60 VA: 0x181C13460
	public void ResetToPool() { }

	// RVA: 0x1C12CA0 Offset: 0x1C112A0 VA: 0x181C12CA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C10FF0 Offset: 0x1C0F5F0 VA: 0x181C10FF0
	public void CopyTo(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C11050 Offset: 0x1C0F650 VA: 0x181C11050
	public IOEntity.IOConnection.LinePointList Copy() { }

	// RVA: 0x1C11F90 Offset: 0x1C10590 VA: 0x181C11F90
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream) { }

	// RVA: 0x1C11100 Offset: 0x1C0F700 VA: 0x181C11100
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C11BE0 Offset: 0x1C101E0 VA: 0x181C11BE0
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C12560 Offset: 0x1C10B60 VA: 0x181C12560
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer) { }

	// RVA: 0x1C12E20 Offset: 0x1C11420 VA: 0x181C12E20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C14910 Offset: 0x1C12F10 VA: 0x181C14910 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C14930 Offset: 0x1C12F30 VA: 0x181C14930 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C130F0 Offset: 0x1C116F0 VA: 0x181C130F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C12910 Offset: 0x1C10F10 VA: 0x181C12910
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer, IOEntity.IOConnection.LinePointList instance, bool isDelta = False) { }

	// RVA: 0x1C12290 Offset: 0x1C10890 VA: 0x181C12290
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C114E0 Offset: 0x1C0FAE0 VA: 0x181C114E0
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C11870 Offset: 0x1C0FE70 VA: 0x181C11870
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C13640 Offset: 0x1C11C40 VA: 0x181C13640
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LinePointList instance, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C14280 Offset: 0x1C12880 VA: 0x181C14280
	public static void Serialize(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C14900 Offset: 0x1C12F00 VA: 0x181C14900
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C14910 Offset: 0x1C12F10 VA: 0x181C14910
	public void ToProto(Stream stream) { }

	// RVA: 0x1C14170 Offset: 0x1C12770 VA: 0x181C14170
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C140C0 Offset: 0x1C126C0 VA: 0x181C140C0
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x7480E0 Offset: 0x7466E0 VA: 0x1807480E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x748710 Offset: 0x746D10 VA: 0x180748710 Slot: 27
	public override void ResetState() { }

	// RVA: 0x746E10 Offset: 0x745410 VA: 0x180746E10
	public string GetDisplayName() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 145
	public virtual bool IsRootEntity() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 146
	public virtual bool get_IsGravitySource() { }

	// RVA: 0x746900 Offset: 0x744F00 VA: 0x180746900
	public IOEntity FindGravitySource(ref Vector3 worldHandlePosition, int depth, bool ignoreSelf) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 147
	public virtual void SetFuelType(ItemDefinition def, IOEntity source) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 148
	public virtual bool WantsPower() { }

	// RVA: 0x748750 Offset: 0x746D50 VA: 0x180748750 Slot: 149
	public virtual bool WantsPassthroughPower() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 150
	public virtual int ConsumptionAmount() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 151
	public virtual int MaximalPowerOutput() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 152
	public virtual bool AllowDrainFrom(int outputSlot) { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60 Slot: 153
	public virtual bool IsPowered() { }

	// RVA: 0x747090 Offset: 0x745690 VA: 0x180747090
	public bool IsConnectedToAnySlot(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	// RVA: 0x7473B0 Offset: 0x7459B0 VA: 0x1807473B0
	public bool IsConnectedTo(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	// RVA: 0x7471F0 Offset: 0x7457F0 VA: 0x1807471F0
	public bool IsConnectedTo(IOEntity entity, int depth, bool defaultReturn = False) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 154
	protected virtual bool ConsiderConnectedTo(IOEntity entity) { }

	// RVA: 0x7485D0 Offset: 0x746BD0 VA: 0x1807485D0
	public void RequestAdditionalData(int slot, bool input) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x746790 Offset: 0x744D90 VA: 0x180746790
	private void Client_ReceiveAdditionalData(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7485C0 Offset: 0x746BC0 VA: 0x1807485C0 Slot: 155
	public virtual void ProcessAdditionalData(int first, int second, float third, float fourth) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 156
	protected virtual float get_LiquidPassthroughGravityThreshold() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 157
	protected virtual bool get_DisregardGravityRestrictionsOnLiquid() { }

	// RVA: 0x746640 Offset: 0x744C40 VA: 0x180746640 Slot: 158
	public virtual bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	// RVA: 0x747520 Offset: 0x745B20 VA: 0x180747520 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x746C10 Offset: 0x745210 VA: 0x180746C10
	public int GetConnectedInputCount() { }

	// RVA: 0x746D10 Offset: 0x745310 VA: 0x180746D10
	public int GetConnectedOutputCount() { }

	// RVA: 0x746EC0 Offset: 0x7454C0 VA: 0x180746EC0
	public bool HasConnections() { }

	// RVA: 0x746880 Offset: 0x744E80 VA: 0x180746880 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7487D0 Offset: 0x746DD0 VA: 0x1807487D0
	public void .ctor() { }

	// RVA: 0x748770 Offset: 0x746D70 VA: 0x180748770
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

	// RVA: 0x7489A0 Offset: 0x746FA0 VA: 0x1807489A0
	public void Init() { }

	// RVA: 0x7488E0 Offset: 0x746EE0 VA: 0x1807488E0
	public void InitClient() { }

	// RVA: 0x748810 Offset: 0x746E10 VA: 0x180748810
	public IOEntity Get(bool isServer = True) { }

	// RVA: 0x7487E0 Offset: 0x746DE0 VA: 0x1807487E0
	public void Clear() { }

	// RVA: 0x748A80 Offset: 0x747080 VA: 0x180748A80
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

	// RVA: 0x748DE0 Offset: 0x7473E0 VA: 0x180748DE0
	public void OnDestroy() { }

	// RVA: 0x748B80 Offset: 0x747180 VA: 0x180748B80
	public void Clear() { }

	// RVA: 0x748A90 Offset: 0x747090 VA: 0x180748A90
	public void CleanupLines() { }

	// RVA: 0x748DF0 Offset: 0x7473F0 VA: 0x180748DF0
	public void UpdateLines(Transform transform) { }

	// RVA: 0x748C50 Offset: 0x747250 VA: 0x180748C50
	public float GetLength() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

