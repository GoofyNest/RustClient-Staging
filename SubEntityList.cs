public class SubEntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6395
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> subEntityIds; // 0x18

	// Methods

	// RVA: 0x1DC26C0 Offset: 0x1DC0CC0 VA: 0x181DC26C0
	public static void ResetToPool(SubEntityList instance) { }

	// RVA: 0x1DC25E0 Offset: 0x1DC0BE0 VA: 0x181DC25E0
	public void ResetToPool() { }

	// RVA: 0x1DC2450 Offset: 0x1DC0A50 VA: 0x181DC2450 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC1760 Offset: 0x1DBFD60 VA: 0x181DC1760
	public void CopyTo(SubEntityList instance) { }

	// RVA: 0x1DC1880 Offset: 0x1DBFE80 VA: 0x181DC1880
	public SubEntityList Copy() { }

	// RVA: 0x1DC22B0 Offset: 0x1DC08B0 VA: 0x181DC22B0
	public static SubEntityList Deserialize(Stream stream) { }

	// RVA: 0x1DC19E0 Offset: 0x1DBFFE0 VA: 0x181DC19E0
	public static SubEntityList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC1F60 Offset: 0x1DC0560 VA: 0x181DC1F60
	public static SubEntityList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC2330 Offset: 0x1DC0930 VA: 0x181DC2330
	public static SubEntityList Deserialize(byte[] buffer) { }

	// RVA: 0x1DC25A0 Offset: 0x1DC0BA0 VA: 0x181DC25A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC2BF0 Offset: 0x1DC11F0 VA: 0x181DC2BF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC2C10 Offset: 0x1DC1210 VA: 0x181DC2C10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SubEntityList previous) { }

	// RVA: 0x1DC25C0 Offset: 0x1DC0BC0 VA: 0x181DC25C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC1FF0 Offset: 0x1DC05F0 VA: 0x181DC1FF0
	public static SubEntityList Deserialize(byte[] buffer, SubEntityList instance, bool isDelta = False) { }

	// RVA: 0x1DC20F0 Offset: 0x1DC06F0 VA: 0x181DC20F0
	public static SubEntityList Deserialize(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC1A60 Offset: 0x1DC0060 VA: 0x181DC1A60
	public static SubEntityList DeserializeLengthDelimited(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC1CF0 Offset: 0x1DC02F0 VA: 0x181DC1CF0
	public static SubEntityList DeserializeLength(Stream stream, int length, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC27A0 Offset: 0x1DC0DA0 VA: 0x181DC27A0
	public static void SerializeDelta(Stream stream, SubEntityList instance, SubEntityList previous) { }

	// RVA: 0x1DC2AA0 Offset: 0x1DC10A0 VA: 0x181DC2AA0
	public static void Serialize(Stream stream, SubEntityList instance) { }

	// RVA: 0x1DC2BE0 Offset: 0x1DC11E0 VA: 0x181DC2BE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC2BF0 Offset: 0x1DC11F0 VA: 0x181DC2BF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC2990 Offset: 0x1DC0F90 VA: 0x181DC2990
	public static byte[] SerializeToBytes(SubEntityList instance) { }

	// RVA: 0x1DC28E0 Offset: 0x1DC0EE0 VA: 0x181DC28E0
	public static void SerializeLengthDelimited(Stream stream, SubEntityList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

