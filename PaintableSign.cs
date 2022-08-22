public class PaintableSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6421
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> crcs; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1F921C0 Offset: 0x1F907C0 VA: 0x181F921C0
	public static void ResetToPool(PaintableSign instance) { }

	// RVA: 0x1F92070 Offset: 0x1F90670 VA: 0x181F92070
	public void ResetToPool() { }

	// RVA: 0x1F91E70 Offset: 0x1F90470 VA: 0x181F91E70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F90FA0 Offset: 0x1F8F5A0 VA: 0x181F90FA0
	public void CopyTo(PaintableSign instance) { }

	// RVA: 0x1F911A0 Offset: 0x1F8F7A0 VA: 0x181F911A0
	public PaintableSign Copy() { }

	// RVA: 0x1F91BA0 Offset: 0x1F901A0 VA: 0x181F91BA0
	public static PaintableSign Deserialize(Stream stream) { }

	// RVA: 0x1F91550 Offset: 0x1F8FB50 VA: 0x181F91550
	public static PaintableSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F915D0 Offset: 0x1F8FBD0 VA: 0x181F915D0
	public static PaintableSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F91A80 Offset: 0x1F90080 VA: 0x181F91A80
	public static PaintableSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F92030 Offset: 0x1F90630 VA: 0x181F92030
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F928A0 Offset: 0x1F90EA0 VA: 0x181F928A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F928C0 Offset: 0x1F90EC0 VA: 0x181F928C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintableSign previous) { }

	// RVA: 0x1F92050 Offset: 0x1F90650 VA: 0x181F92050 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F91980 Offset: 0x1F8FF80 VA: 0x181F91980
	public static PaintableSign Deserialize(byte[] buffer, PaintableSign instance, bool isDelta = False) { }

	// RVA: 0x1F91C20 Offset: 0x1F90220 VA: 0x181F91C20
	public static PaintableSign Deserialize(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F91220 Offset: 0x1F8F820 VA: 0x181F91220
	public static PaintableSign DeserializeLengthDelimited(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F91660 Offset: 0x1F8FC60 VA: 0x181F91660
	public static PaintableSign DeserializeLength(Stream stream, int length, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F92310 Offset: 0x1F90910 VA: 0x181F92310
	public static void SerializeDelta(Stream stream, PaintableSign instance, PaintableSign previous) { }

	// RVA: 0x1F926B0 Offset: 0x1F90CB0 VA: 0x181F926B0
	public static void Serialize(Stream stream, PaintableSign instance) { }

	// RVA: 0x1F92890 Offset: 0x1F90E90 VA: 0x181F92890
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F928A0 Offset: 0x1F90EA0 VA: 0x181F928A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F925A0 Offset: 0x1F90BA0 VA: 0x181F925A0
	public static byte[] SerializeToBytes(PaintableSign instance) { }

	// RVA: 0x1F924F0 Offset: 0x1F90AF0 VA: 0x181F924F0
	public static void SerializeLengthDelimited(Stream stream, PaintableSign instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

