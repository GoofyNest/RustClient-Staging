public class PrefabData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6509
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string category; // 0x18
	public uint id; // 0x20
	public VectorData position; // 0x24
	public VectorData rotation; // 0x30
	public VectorData scale; // 0x3C

	// Methods

	// RVA: 0x2047F80 Offset: 0x2046580 VA: 0x182047F80
	public static void ResetToPool(PrefabData instance) { }

	// RVA: 0x2048060 Offset: 0x2046660 VA: 0x182048060
	public void ResetToPool() { }

	// RVA: 0x2047BC0 Offset: 0x20461C0 VA: 0x182047BC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2046860 Offset: 0x2044E60 VA: 0x182046860
	public void CopyTo(PrefabData instance) { }

	// RVA: 0x20468D0 Offset: 0x2044ED0 VA: 0x1820468D0
	public PrefabData Copy() { }

	// RVA: 0x2047610 Offset: 0x2045C10 VA: 0x182047610
	public static PrefabData Deserialize(Stream stream) { }

	// RVA: 0x2046990 Offset: 0x2044F90 VA: 0x182046990
	public static PrefabData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2046D30 Offset: 0x2045330 VA: 0x182046D30
	public static PrefabData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2047890 Offset: 0x2045E90 VA: 0x182047890
	public static PrefabData Deserialize(byte[] buffer) { }

	// RVA: 0x2047D20 Offset: 0x2046320 VA: 0x182047D20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2048B20 Offset: 0x2047120 VA: 0x182048B20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2048B40 Offset: 0x2047140 VA: 0x182048B40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PrefabData previous) { }

	// RVA: 0x2047F60 Offset: 0x2046560 VA: 0x182047F60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2047300 Offset: 0x2045900 VA: 0x182047300
	public static PrefabData Deserialize(byte[] buffer, PrefabData instance, bool isDelta = False) { }

	// RVA: 0x20470C0 Offset: 0x20456C0 VA: 0x1820470C0
	public static PrefabData Deserialize(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x2046A10 Offset: 0x2045010 VA: 0x182046A10
	public static PrefabData DeserializeLengthDelimited(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x2046DC0 Offset: 0x20453C0 VA: 0x182046DC0
	public static PrefabData DeserializeLength(Stream stream, int length, PrefabData instance, bool isDelta) { }

	// RVA: 0x2048140 Offset: 0x2046740 VA: 0x182048140
	public static void SerializeDelta(Stream stream, PrefabData instance, PrefabData previous) { }

	// RVA: 0x2048760 Offset: 0x2046D60 VA: 0x182048760
	public static void Serialize(Stream stream, PrefabData instance) { }

	// RVA: 0x2048B10 Offset: 0x2047110 VA: 0x182048B10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2048B20 Offset: 0x2047120 VA: 0x182048B20
	public void ToProto(Stream stream) { }

	// RVA: 0x2048650 Offset: 0x2046C50 VA: 0x182048650
	public static byte[] SerializeToBytes(PrefabData instance) { }

	// RVA: 0x20485A0 Offset: 0x2046BA0 VA: 0x1820485A0
	public static void SerializeLengthDelimited(Stream stream, PrefabData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

