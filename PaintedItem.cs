public class PaintedItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6429
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageCrc; // 0x14
	public ulong editedBy; // 0x18

	// Methods

	// RVA: 0x1F939B0 Offset: 0x1F91FB0 VA: 0x181F939B0
	public static void ResetToPool(PaintedItem instance) { }

	// RVA: 0x1F93A30 Offset: 0x1F92030 VA: 0x181F93A30
	public void ResetToPool() { }

	// RVA: 0x1F93710 Offset: 0x1F91D10 VA: 0x181F93710 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F928E0 Offset: 0x1F90EE0 VA: 0x181F928E0
	public void CopyTo(PaintedItem instance) { }

	// RVA: 0x1F92910 Offset: 0x1F90F10 VA: 0x181F92910
	public PaintedItem Copy() { }

	// RVA: 0x1F93550 Offset: 0x1F91B50 VA: 0x181F93550
	public static PaintedItem Deserialize(Stream stream) { }

	// RVA: 0x1F92BD0 Offset: 0x1F911D0 VA: 0x181F92BD0
	public static PaintedItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F92C50 Offset: 0x1F91250 VA: 0x181F92C50
	public static PaintedItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F932E0 Offset: 0x1F918E0 VA: 0x181F932E0
	public static PaintedItem Deserialize(byte[] buffer) { }

	// RVA: 0x1F93810 Offset: 0x1F91E10 VA: 0x181F93810
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F93EF0 Offset: 0x1F924F0 VA: 0x181F93EF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F93F10 Offset: 0x1F92510 VA: 0x181F93F10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintedItem previous) { }

	// RVA: 0x1F93990 Offset: 0x1F91F90 VA: 0x181F93990 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F92F10 Offset: 0x1F91510 VA: 0x181F92F10
	public static PaintedItem Deserialize(byte[] buffer, PaintedItem instance, bool isDelta = False) { }

	// RVA: 0x1F93160 Offset: 0x1F91760 VA: 0x181F93160
	public static PaintedItem Deserialize(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F92980 Offset: 0x1F90F80 VA: 0x181F92980
	public static PaintedItem DeserializeLengthDelimited(Stream stream, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F92CE0 Offset: 0x1F912E0 VA: 0x181F92CE0
	public static PaintedItem DeserializeLength(Stream stream, int length, PaintedItem instance, bool isDelta) { }

	// RVA: 0x1F93AB0 Offset: 0x1F920B0 VA: 0x181F93AB0
	public static void SerializeDelta(Stream stream, PaintedItem instance, PaintedItem previous) { }

	// RVA: 0x1F93DE0 Offset: 0x1F923E0 VA: 0x181F93DE0
	public static void Serialize(Stream stream, PaintedItem instance) { }

	// RVA: 0x1F93EE0 Offset: 0x1F924E0 VA: 0x181F93EE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F93EF0 Offset: 0x1F924F0 VA: 0x181F93EF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F93CD0 Offset: 0x1F922D0 VA: 0x181F93CD0
	public static byte[] SerializeToBytes(PaintedItem instance) { }

	// RVA: 0x1F93C20 Offset: 0x1F92220 VA: 0x181F93C20
	public static void SerializeLengthDelimited(Stream stream, PaintedItem instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

