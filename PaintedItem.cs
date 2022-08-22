public class PaintedItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6429
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageCrc; // 0x14
	public ulong editedBy; // 0x18

	// Methods

	// RVA: 0x1F92ED0 Offset: 0x1F914D0 VA: 0x181F92ED0
	public static void ResetToPool(PaintedItem instance) { }

	// RVA: 0x1F92F50 Offset: 0x1F91550 VA: 0x181F92F50
	public void ResetToPool() { }

	// RVA: 0x1F92C30 Offset: 0x1F91230 VA: 0x181F92C30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F91E00 Offset: 0x1F90400 VA: 0x181F91E00
	public void CopyTo(PaintedItem instance) { }

	// RVA: 0x1F91E30 Offset: 0x1F90430 VA: 0x181F91E30
	public PaintedItem Copy() { }

	// RVA: 0x1F92A70 Offset: 0x1F91070 VA: 0x181F92A70
	public static PaintedItem Deserialize(Stream stream) { }

	// RVA: 0x1F920F0 Offset: 0x1F906F0 VA: 0x181F920F0
	public static PaintedItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F92170 Offset: 0x1F90770 VA: 0x181F92170
	public static PaintedItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F92800 Offset: 0x1F90E00 VA: 0x181F92800
	public static PaintedItem Deserialize(byte[] buffer) { }

	// RVA: 0x1F92D30 Offset: 0x1F91330 VA: 0x181F92D30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F93410 Offset: 0x1F91A10 VA: 0x181F93410 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F93430 Offset: 0x1F91A30 VA: 0x181F93430 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintedItem previous) { }

	// RVA: 0x1F92EB0 Offset: 0x1F914B0 VA: 0x181F92EB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F92430 Offset: 0x1F90A30 VA: 0x181F92430
	public static PaintedItem Deserialize(byte[] buffer, PaintedItem instance, bool isDelta = False) { }

	// RVA: 0x1F92680 Offset: 0x1F90C80 VA: 0x181F92680
	public static PaintedItem Deserialize(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F91EA0 Offset: 0x1F904A0 VA: 0x181F91EA0
	public static PaintedItem DeserializeLengthDelimited(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F92200 Offset: 0x1F90800 VA: 0x181F92200
	public static PaintedItem DeserializeLength(Stream stream, int length, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F92FD0 Offset: 0x1F915D0 VA: 0x181F92FD0
	public static void SerializeDelta(Stream stream, PaintedItem instance, PaintedItem previous) { }

	// RVA: 0x1F93300 Offset: 0x1F91900 VA: 0x181F93300
	public static void Serialize(Stream stream, PaintedItem instance) { }

	// RVA: 0x1F93400 Offset: 0x1F91A00 VA: 0x181F93400
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F93410 Offset: 0x1F91A10 VA: 0x181F93410
	public void ToProto(Stream stream) { }

	// RVA: 0x1F931F0 Offset: 0x1F917F0 VA: 0x181F931F0
	public static byte[] SerializeToBytes(PaintedItem instance) { }

	// RVA: 0x1F93140 Offset: 0x1F91740 VA: 0x181F93140
	public static void SerializeLengthDelimited(Stream stream, PaintedItem instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

