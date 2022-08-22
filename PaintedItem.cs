public class PaintedItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6429
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageCrc; // 0x14
	public ulong editedBy; // 0x18

	// Methods

	// RVA: 0x1F93190 Offset: 0x1F91790 VA: 0x181F93190
	public static void ResetToPool(PaintedItem instance) { }

	// RVA: 0x1F93210 Offset: 0x1F91810 VA: 0x181F93210
	public void ResetToPool() { }

	// RVA: 0x1F92EF0 Offset: 0x1F914F0 VA: 0x181F92EF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F920C0 Offset: 0x1F906C0 VA: 0x181F920C0
	public void CopyTo(PaintedItem instance) { }

	// RVA: 0x1F920F0 Offset: 0x1F906F0 VA: 0x181F920F0
	public PaintedItem Copy() { }

	// RVA: 0x1F92D30 Offset: 0x1F91330 VA: 0x181F92D30
	public static PaintedItem Deserialize(Stream stream) { }

	// RVA: 0x1F923B0 Offset: 0x1F909B0 VA: 0x181F923B0
	public static PaintedItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F92430 Offset: 0x1F90A30 VA: 0x181F92430
	public static PaintedItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F92AC0 Offset: 0x1F910C0 VA: 0x181F92AC0
	public static PaintedItem Deserialize(byte[] buffer) { }

	// RVA: 0x1F92FF0 Offset: 0x1F915F0 VA: 0x181F92FF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F936D0 Offset: 0x1F91CD0 VA: 0x181F936D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F936F0 Offset: 0x1F91CF0 VA: 0x181F936F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintedItem previous) { }

	// RVA: 0x1F93170 Offset: 0x1F91770 VA: 0x181F93170 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F926F0 Offset: 0x1F90CF0 VA: 0x181F926F0
	public static PaintedItem Deserialize(byte[] buffer, PaintedItem instance, bool isDelta = False) { }

	// RVA: 0x1F92940 Offset: 0x1F90F40 VA: 0x181F92940
	public static PaintedItem Deserialize(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F92160 Offset: 0x1F90760 VA: 0x181F92160
	public static PaintedItem DeserializeLengthDelimited(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F924C0 Offset: 0x1F90AC0 VA: 0x181F924C0
	public static PaintedItem DeserializeLength(Stream stream, int length, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F93290 Offset: 0x1F91890 VA: 0x181F93290
	public static void SerializeDelta(Stream stream, PaintedItem instance, PaintedItem previous) { }

	// RVA: 0x1F935C0 Offset: 0x1F91BC0 VA: 0x181F935C0
	public static void Serialize(Stream stream, PaintedItem instance) { }

	// RVA: 0x1F936C0 Offset: 0x1F91CC0 VA: 0x181F936C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F936D0 Offset: 0x1F91CD0 VA: 0x181F936D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F934B0 Offset: 0x1F91AB0 VA: 0x181F934B0
	public static byte[] SerializeToBytes(PaintedItem instance) { }

	// RVA: 0x1F93400 Offset: 0x1F91A00 VA: 0x181F93400
	public static void SerializeLengthDelimited(Stream stream, PaintedItem instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

