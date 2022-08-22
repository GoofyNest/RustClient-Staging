public class PaintableSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6421
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> crcs; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1F916E0 Offset: 0x1F8FCE0 VA: 0x181F916E0
	public static void ResetToPool(PaintableSign instance) { }

	// RVA: 0x1F91590 Offset: 0x1F8FB90 VA: 0x181F91590
	public void ResetToPool() { }

	// RVA: 0x1F91390 Offset: 0x1F8F990 VA: 0x181F91390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F904C0 Offset: 0x1F8EAC0 VA: 0x181F904C0
	public void CopyTo(PaintableSign instance) { }

	// RVA: 0x1F906C0 Offset: 0x1F8ECC0 VA: 0x181F906C0
	public PaintableSign Copy() { }

	// RVA: 0x1F910C0 Offset: 0x1F8F6C0 VA: 0x181F910C0
	public static PaintableSign Deserialize(Stream stream) { }

	// RVA: 0x1F90A70 Offset: 0x1F8F070 VA: 0x181F90A70
	public static PaintableSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F90AF0 Offset: 0x1F8F0F0 VA: 0x181F90AF0
	public static PaintableSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F90FA0 Offset: 0x1F8F5A0 VA: 0x181F90FA0
	public static PaintableSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F91550 Offset: 0x1F8FB50 VA: 0x181F91550
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F91DC0 Offset: 0x1F903C0 VA: 0x181F91DC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F91DE0 Offset: 0x1F903E0 VA: 0x181F91DE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintableSign previous) { }

	// RVA: 0x1F91570 Offset: 0x1F8FB70 VA: 0x181F91570 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F90EA0 Offset: 0x1F8F4A0 VA: 0x181F90EA0
	public static PaintableSign Deserialize(byte[] buffer, PaintableSign instance, bool isDelta = False) { }

	// RVA: 0x1F91140 Offset: 0x1F8F740 VA: 0x181F91140
	public static PaintableSign Deserialize(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F90740 Offset: 0x1F8ED40 VA: 0x181F90740
	public static PaintableSign DeserializeLengthDelimited(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F90B80 Offset: 0x1F8F180 VA: 0x181F90B80
	public static PaintableSign DeserializeLength(Stream stream, int length, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F91830 Offset: 0x1F8FE30 VA: 0x181F91830
	public static void SerializeDelta(Stream stream, PaintableSign instance, PaintableSign previous) { }

	// RVA: 0x1F91BD0 Offset: 0x1F901D0 VA: 0x181F91BD0
	public static void Serialize(Stream stream, PaintableSign instance) { }

	// RVA: 0x1F91DB0 Offset: 0x1F903B0 VA: 0x181F91DB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F91DC0 Offset: 0x1F903C0 VA: 0x181F91DC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F91AC0 Offset: 0x1F900C0 VA: 0x181F91AC0
	public static byte[] SerializeToBytes(PaintableSign instance) { }

	// RVA: 0x1F91A10 Offset: 0x1F90010 VA: 0x181F91A10
	public static void SerializeLengthDelimited(Stream stream, PaintableSign instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

