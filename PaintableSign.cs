public class PaintableSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6421
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> crcs; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1F918A0 Offset: 0x1F8FEA0 VA: 0x181F918A0
	public static void ResetToPool(PaintableSign instance) { }

	// RVA: 0x1F91750 Offset: 0x1F8FD50 VA: 0x181F91750
	public void ResetToPool() { }

	// RVA: 0x1F91550 Offset: 0x1F8FB50 VA: 0x181F91550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F90680 Offset: 0x1F8EC80 VA: 0x181F90680
	public void CopyTo(PaintableSign instance) { }

	// RVA: 0x1F90880 Offset: 0x1F8EE80 VA: 0x181F90880
	public PaintableSign Copy() { }

	// RVA: 0x1F91280 Offset: 0x1F8F880 VA: 0x181F91280
	public static PaintableSign Deserialize(Stream stream) { }

	// RVA: 0x1F90C30 Offset: 0x1F8F230 VA: 0x181F90C30
	public static PaintableSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F90CB0 Offset: 0x1F8F2B0 VA: 0x181F90CB0
	public static PaintableSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F91160 Offset: 0x1F8F760 VA: 0x181F91160
	public static PaintableSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F91710 Offset: 0x1F8FD10 VA: 0x181F91710
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F91F80 Offset: 0x1F90580 VA: 0x181F91F80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F91FA0 Offset: 0x1F905A0 VA: 0x181F91FA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintableSign previous) { }

	// RVA: 0x1F91730 Offset: 0x1F8FD30 VA: 0x181F91730 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F91060 Offset: 0x1F8F660 VA: 0x181F91060
	public static PaintableSign Deserialize(byte[] buffer, PaintableSign instance, bool isDelta = False) { }

	// RVA: 0x1F91300 Offset: 0x1F8F900 VA: 0x181F91300
	public static PaintableSign Deserialize(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F90900 Offset: 0x1F8EF00 VA: 0x181F90900
	public static PaintableSign DeserializeLengthDelimited(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F90D40 Offset: 0x1F8F340 VA: 0x181F90D40
	public static PaintableSign DeserializeLength(Stream stream, int length, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F919F0 Offset: 0x1F8FFF0 VA: 0x181F919F0
	public static void SerializeDelta(Stream stream, PaintableSign instance, PaintableSign previous) { }

	// RVA: 0x1F91D90 Offset: 0x1F90390 VA: 0x181F91D90
	public static void Serialize(Stream stream, PaintableSign instance) { }

	// RVA: 0x1F91F70 Offset: 0x1F90570 VA: 0x181F91F70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F91F80 Offset: 0x1F90580 VA: 0x181F91F80
	public void ToProto(Stream stream) { }

	// RVA: 0x1F91C80 Offset: 0x1F90280 VA: 0x181F91C80
	public static byte[] SerializeToBytes(PaintableSign instance) { }

	// RVA: 0x1F91BD0 Offset: 0x1F901D0 VA: 0x181F91BD0
	public static void SerializeLengthDelimited(Stream stream, PaintableSign instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

