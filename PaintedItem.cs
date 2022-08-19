public class PaintedItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6429
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageCrc; // 0x14
	public ulong editedBy; // 0x18

	// Methods

	// RVA: 0x1F93090 Offset: 0x1F91690 VA: 0x181F93090
	public static void ResetToPool(PaintedItem instance) { }

	// RVA: 0x1F93110 Offset: 0x1F91710 VA: 0x181F93110
	public void ResetToPool() { }

	// RVA: 0x1F92DF0 Offset: 0x1F913F0 VA: 0x181F92DF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F91FC0 Offset: 0x1F905C0 VA: 0x181F91FC0
	public void CopyTo(PaintedItem instance) { }

	// RVA: 0x1F91FF0 Offset: 0x1F905F0 VA: 0x181F91FF0
	public PaintedItem Copy() { }

	// RVA: 0x1F92C30 Offset: 0x1F91230 VA: 0x181F92C30
	public static PaintedItem Deserialize(Stream stream) { }

	// RVA: 0x1F922B0 Offset: 0x1F908B0 VA: 0x181F922B0
	public static PaintedItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F92330 Offset: 0x1F90930 VA: 0x181F92330
	public static PaintedItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F929C0 Offset: 0x1F90FC0 VA: 0x181F929C0
	public static PaintedItem Deserialize(byte[] buffer) { }

	// RVA: 0x1F92EF0 Offset: 0x1F914F0 VA: 0x181F92EF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F935D0 Offset: 0x1F91BD0 VA: 0x181F935D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F935F0 Offset: 0x1F91BF0 VA: 0x181F935F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintedItem previous) { }

	// RVA: 0x1F93070 Offset: 0x1F91670 VA: 0x181F93070 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F925F0 Offset: 0x1F90BF0 VA: 0x181F925F0
	public static PaintedItem Deserialize(byte[] buffer, PaintedItem instance, bool isDelta = False) { }

	// RVA: 0x1F92840 Offset: 0x1F90E40 VA: 0x181F92840
	public static PaintedItem Deserialize(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F92060 Offset: 0x1F90660 VA: 0x181F92060
	public static PaintedItem DeserializeLengthDelimited(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F923C0 Offset: 0x1F909C0 VA: 0x181F923C0
	public static PaintedItem DeserializeLength(Stream stream, int length, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F93190 Offset: 0x1F91790 VA: 0x181F93190
	public static void SerializeDelta(Stream stream, PaintedItem instance, PaintedItem previous) { }

	// RVA: 0x1F934C0 Offset: 0x1F91AC0 VA: 0x181F934C0
	public static void Serialize(Stream stream, PaintedItem instance) { }

	// RVA: 0x1F935C0 Offset: 0x1F91BC0 VA: 0x181F935C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F935D0 Offset: 0x1F91BD0 VA: 0x181F935D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F933B0 Offset: 0x1F919B0 VA: 0x181F933B0
	public static byte[] SerializeToBytes(PaintedItem instance) { }

	// RVA: 0x1F93300 Offset: 0x1F91900 VA: 0x181F93300
	public static void SerializeLengthDelimited(Stream stream, PaintedItem instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

