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

	// RVA: 0x1C04010 Offset: 0x1C02610 VA: 0x181C04010
	public static void ResetToPool(IOEntity instance) { }

	// RVA: 0x1C03CA0 Offset: 0x1C022A0 VA: 0x181C03CA0
	public void ResetToPool() { }

	// RVA: 0x1C03BE0 Offset: 0x1C021E0 VA: 0x181C03BE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C02540 Offset: 0x1C00B40 VA: 0x181C02540
	public void CopyTo(IOEntity instance) { }

	// RVA: 0x1C02850 Offset: 0x1C00E50 VA: 0x181C02850
	public IOEntity Copy() { }

	// RVA: 0x1C035C0 Offset: 0x1C01BC0 VA: 0x181C035C0
	public static IOEntity Deserialize(Stream stream) { }

	// RVA: 0x1C028D0 Offset: 0x1C00ED0 VA: 0x181C028D0
	public static IOEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C02EC0 Offset: 0x1C014C0 VA: 0x181C02EC0
	public static IOEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C034A0 Offset: 0x1C01AA0 VA: 0x181C034A0
	public static IOEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1C03C60 Offset: 0x1C02260 VA: 0x181C03C60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C04FC0 Offset: 0x1C035C0 VA: 0x181C04FC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C04FE0 Offset: 0x1C035E0 VA: 0x181C04FE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity previous) { }

	// RVA: 0x1C03C80 Offset: 0x1C02280 VA: 0x181C03C80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C03AE0 Offset: 0x1C020E0 VA: 0x181C03AE0
	public static IOEntity Deserialize(byte[] buffer, IOEntity instance, bool isDelta = False) { }

	// RVA: 0x1C03640 Offset: 0x1C01C40 VA: 0x181C03640
	public static IOEntity Deserialize(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C02950 Offset: 0x1C00F50 VA: 0x181C02950
	public static IOEntity DeserializeLengthDelimited(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C02F50 Offset: 0x1C01550 VA: 0x181C02F50
	public static IOEntity DeserializeLength(Stream stream, int length, IOEntity instance, bool isDelta) { }

	// RVA: 0x1C04380 Offset: 0x1C02980 VA: 0x181C04380
	public static void SerializeDelta(Stream stream, IOEntity instance, IOEntity previous) { }

	// RVA: 0x1C04B50 Offset: 0x1C03150 VA: 0x181C04B50
	public static void Serialize(Stream stream, IOEntity instance) { }

	// RVA: 0x1C04FB0 Offset: 0x1C035B0 VA: 0x181C04FB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C04FC0 Offset: 0x1C035C0 VA: 0x181C04FC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C04A40 Offset: 0x1C03040 VA: 0x181C04A40
	public static byte[] SerializeToBytes(IOEntity instance) { }

	// RVA: 0x1C04990 Offset: 0x1C02F90 VA: 0x181C04990
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

	// RVA: 0x1C01780 Offset: 0x1BFFD80 VA: 0x181C01780
	public static void ResetToPool(IOEntity.IOConnection instance) { }

	// RVA: 0x1C019C0 Offset: 0x1BFFFC0 VA: 0x181C019C0
	public void ResetToPool() { }

	// RVA: 0x1C01350 Offset: 0x1BFF950 VA: 0x181C01350 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFF7A0 Offset: 0x1BFDDA0 VA: 0x181BFF7A0
	public void CopyTo(IOEntity.IOConnection instance) { }

	// RVA: 0x1BFF950 Offset: 0x1BFDF50 VA: 0x181BFF950
	public IOEntity.IOConnection Copy() { }

	// RVA: 0x1C00B90 Offset: 0x1BFF190 VA: 0x181C00B90
	public static IOEntity.IOConnection Deserialize(Stream stream) { }

	// RVA: 0x1BFFE40 Offset: 0x1BFE440 VA: 0x181BFFE40
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFFEC0 Offset: 0x1BFE4C0 VA: 0x181BFFEC0
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C00F20 Offset: 0x1BFF520 VA: 0x181C00F20
	public static IOEntity.IOConnection Deserialize(byte[] buffer) { }

	// RVA: 0x1C013D0 Offset: 0x1BFF9D0 VA: 0x181C013D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C02500 Offset: 0x1C00B00 VA: 0x181C02500 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C02520 Offset: 0x1C00B20 VA: 0x181C02520 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection previous) { }

	// RVA: 0x1C01760 Offset: 0x1BFFD60 VA: 0x181C01760 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C00390 Offset: 0x1BFE990 VA: 0x181C00390
	public static IOEntity.IOConnection Deserialize(byte[] buffer, IOEntity.IOConnection instance, bool isDelta = False) { }

	// RVA: 0x1C00800 Offset: 0x1BFEE00 VA: 0x181C00800
	public static IOEntity.IOConnection Deserialize(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1BFF9D0 Offset: 0x1BFDFD0 VA: 0x181BFF9D0
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1BFFF50 Offset: 0x1BFE550 VA: 0x181BFFF50
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1C01C00 Offset: 0x1C00200 VA: 0x181C01C00
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection instance, IOEntity.IOConnection previous) { }

	// RVA: 0x1C021C0 Offset: 0x1C007C0 VA: 0x181C021C0
	public static void Serialize(Stream stream, IOEntity.IOConnection instance) { }

	// RVA: 0x1C024F0 Offset: 0x1C00AF0 VA: 0x181C024F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C02500 Offset: 0x1C00B00 VA: 0x181C02500
	public void ToProto(Stream stream) { }

	// RVA: 0x1C020B0 Offset: 0x1C006B0 VA: 0x181C020B0
	public static byte[] SerializeToBytes(IOEntity.IOConnection instance) { }

	// RVA: 0x1C02000 Offset: 0x1C00600 VA: 0x181C02000
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

	// RVA: 0x1C155F0 Offset: 0x1C13BF0 VA: 0x181C155F0
	public static void ResetToPool(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C15570 Offset: 0x1C13B70 VA: 0x181C15570
	public void ResetToPool() { }

	// RVA: 0x1C154B0 Offset: 0x1C13AB0 VA: 0x181C154B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C14B10 Offset: 0x1C13110 VA: 0x181C14B10
	public void CopyTo(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C14B30 Offset: 0x1C13130 VA: 0x181C14B30
	public IOEntity.IOConnection.LineVec Copy() { }

	// RVA: 0x1C150C0 Offset: 0x1C136C0 VA: 0x181C150C0
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream) { }

	// RVA: 0x1C14DC0 Offset: 0x1C133C0 VA: 0x181C14DC0
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C14E40 Offset: 0x1C13440 VA: 0x181C14E40
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C15390 Offset: 0x1C13990 VA: 0x181C15390
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer) { }

	// RVA: 0x1C15530 Offset: 0x1C13B30 VA: 0x181C15530
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C15BD0 Offset: 0x1C141D0 VA: 0x181C15BD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C15BF0 Offset: 0x1C141F0 VA: 0x181C15BF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C15550 Offset: 0x1C13B50 VA: 0x181C15550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C15140 Offset: 0x1C13740 VA: 0x181C15140
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer, IOEntity.IOConnection.LineVec instance, bool isDelta = False) { }

	// RVA: 0x1C15240 Offset: 0x1C13840 VA: 0x181C15240
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C14BA0 Offset: 0x1C131A0 VA: 0x181C14BA0
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C14ED0 Offset: 0x1C134D0 VA: 0x181C14ED0
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C15670 Offset: 0x1C13C70 VA: 0x181C15670
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LineVec instance, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C15A50 Offset: 0x1C14050 VA: 0x181C15A50
	public static void Serialize(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C15BC0 Offset: 0x1C141C0 VA: 0x181C15BC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C15BD0 Offset: 0x1C141D0 VA: 0x181C15BD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C15940 Offset: 0x1C13F40 VA: 0x181C15940
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C15890 Offset: 0x1C13E90 VA: 0x181C15890
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

	// RVA: 0x1C13710 Offset: 0x1C11D10 VA: 0x181C13710
	public static void ResetToPool(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C13620 Offset: 0x1C11C20 VA: 0x181C13620
	public void ResetToPool() { }

	// RVA: 0x1C12E60 Offset: 0x1C11460 VA: 0x181C12E60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C111B0 Offset: 0x1C0F7B0 VA: 0x181C111B0
	public void CopyTo(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C11210 Offset: 0x1C0F810 VA: 0x181C11210
	public IOEntity.IOConnection.LinePointList Copy() { }

	// RVA: 0x1C12150 Offset: 0x1C10750 VA: 0x181C12150
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream) { }

	// RVA: 0x1C112C0 Offset: 0x1C0F8C0 VA: 0x181C112C0
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C11DA0 Offset: 0x1C103A0 VA: 0x181C11DA0
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C12720 Offset: 0x1C10D20 VA: 0x181C12720
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer) { }

	// RVA: 0x1C12FE0 Offset: 0x1C115E0 VA: 0x181C12FE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C14AD0 Offset: 0x1C130D0 VA: 0x181C14AD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C14AF0 Offset: 0x1C130F0 VA: 0x181C14AF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C132B0 Offset: 0x1C118B0 VA: 0x181C132B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C12AD0 Offset: 0x1C110D0 VA: 0x181C12AD0
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer, IOEntity.IOConnection.LinePointList instance, bool isDelta = False) { }

	// RVA: 0x1C12450 Offset: 0x1C10A50 VA: 0x181C12450
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C116A0 Offset: 0x1C0FCA0 VA: 0x181C116A0
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C11A30 Offset: 0x1C10030 VA: 0x181C11A30
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C13800 Offset: 0x1C11E00 VA: 0x181C13800
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LinePointList instance, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C14440 Offset: 0x1C12A40 VA: 0x181C14440
	public static void Serialize(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C14AC0 Offset: 0x1C130C0 VA: 0x181C14AC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C14AD0 Offset: 0x1C130D0 VA: 0x181C14AD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C14330 Offset: 0x1C12930 VA: 0x181C14330
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C14280 Offset: 0x1C12880 VA: 0x181C14280
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class IOEntity : DecayEntity // TypeDefIndex: 8587
{	// Fields
	[HeaderAttribute] // RVA: 0xAE900 Offset: 0xADD00 VA: 0x1800AE900
	public Transform debugOrigin; // 0x258
	public ItemDefinition sourceItem; // 0x260
	[ServerVar] // RVA: 0xAFD00 Offset: 0xAF100 VA: 0x1800AFD00
	[HelpAttribute] // RVA: 0xAFD00 Offset: 0xAF100 VA: 0x1800AFD00
	public static float framebudgetms; // 0x0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float responsetime; // 0x4
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
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

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

