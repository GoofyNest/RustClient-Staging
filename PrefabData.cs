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

	// RVA: 0x2047E80 Offset: 0x2046480 VA: 0x182047E80
	public static void ResetToPool(PrefabData instance) { }

	// RVA: 0x2047F60 Offset: 0x2046560 VA: 0x182047F60
	public void ResetToPool() { }

	// RVA: 0x2047AC0 Offset: 0x20460C0 VA: 0x182047AC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2046760 Offset: 0x2044D60 VA: 0x182046760
	public void CopyTo(PrefabData instance) { }

	// RVA: 0x20467D0 Offset: 0x2044DD0 VA: 0x1820467D0
	public PrefabData Copy() { }

	// RVA: 0x2047510 Offset: 0x2045B10 VA: 0x182047510
	public static PrefabData Deserialize(Stream stream) { }

	// RVA: 0x2046890 Offset: 0x2044E90 VA: 0x182046890
	public static PrefabData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2046C30 Offset: 0x2045230 VA: 0x182046C30
	public static PrefabData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2047790 Offset: 0x2045D90 VA: 0x182047790
	public static PrefabData Deserialize(byte[] buffer) { }

	// RVA: 0x2047C20 Offset: 0x2046220 VA: 0x182047C20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2048A20 Offset: 0x2047020 VA: 0x182048A20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2048A40 Offset: 0x2047040 VA: 0x182048A40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PrefabData previous) { }

	// RVA: 0x2047E60 Offset: 0x2046460 VA: 0x182047E60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2047200 Offset: 0x2045800 VA: 0x182047200
	public static PrefabData Deserialize(byte[] buffer, PrefabData instance, bool isDelta = False) { }

	// RVA: 0x2046FC0 Offset: 0x20455C0 VA: 0x182046FC0
	public static PrefabData Deserialize(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x2046910 Offset: 0x2044F10 VA: 0x182046910
	public static PrefabData DeserializeLengthDelimited(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x2046CC0 Offset: 0x20452C0 VA: 0x182046CC0
	public static PrefabData DeserializeLength(Stream stream, int length, PrefabData instance, bool isDelta) { }

	// RVA: 0x2048040 Offset: 0x2046640 VA: 0x182048040
	public static void SerializeDelta(Stream stream, PrefabData instance, PrefabData previous) { }

	// RVA: 0x2048660 Offset: 0x2046C60 VA: 0x182048660
	public static void Serialize(Stream stream, PrefabData instance) { }

	// RVA: 0x2048A10 Offset: 0x2047010 VA: 0x182048A10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2048A20 Offset: 0x2047020 VA: 0x182048A20
	public void ToProto(Stream stream) { }

	// RVA: 0x2048550 Offset: 0x2046B50 VA: 0x182048550
	public static byte[] SerializeToBytes(PrefabData instance) { }

	// RVA: 0x20484A0 Offset: 0x2046AA0 VA: 0x1820484A0
	public static void SerializeLengthDelimited(Stream stream, PrefabData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

