public class PaintableSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6421
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> crcs; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1F919A0 Offset: 0x1F8FFA0 VA: 0x181F919A0
	public static void ResetToPool(PaintableSign instance) { }

	// RVA: 0x1F91850 Offset: 0x1F8FE50 VA: 0x181F91850
	public void ResetToPool() { }

	// RVA: 0x1F91650 Offset: 0x1F8FC50 VA: 0x181F91650 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F90780 Offset: 0x1F8ED80 VA: 0x181F90780
	public void CopyTo(PaintableSign instance) { }

	// RVA: 0x1F90980 Offset: 0x1F8EF80 VA: 0x181F90980
	public PaintableSign Copy() { }

	// RVA: 0x1F91380 Offset: 0x1F8F980 VA: 0x181F91380
	public static PaintableSign Deserialize(Stream stream) { }

	// RVA: 0x1F90D30 Offset: 0x1F8F330 VA: 0x181F90D30
	public static PaintableSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F90DB0 Offset: 0x1F8F3B0 VA: 0x181F90DB0
	public static PaintableSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F91260 Offset: 0x1F8F860 VA: 0x181F91260
	public static PaintableSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F91810 Offset: 0x1F8FE10 VA: 0x181F91810
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F92080 Offset: 0x1F90680 VA: 0x181F92080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F920A0 Offset: 0x1F906A0 VA: 0x181F920A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PaintableSign previous) { }

	// RVA: 0x1F91830 Offset: 0x1F8FE30 VA: 0x181F91830 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F91160 Offset: 0x1F8F760 VA: 0x181F91160
	public static PaintableSign Deserialize(byte[] buffer, PaintableSign instance, bool isDelta = False) { }

	// RVA: 0x1F91400 Offset: 0x1F8FA00 VA: 0x181F91400
	public static PaintableSign Deserialize(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F90A00 Offset: 0x1F8F000 VA: 0x181F90A00
	public static PaintableSign DeserializeLengthDelimited(Stream stream, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F90E40 Offset: 0x1F8F440 VA: 0x181F90E40
	public static PaintableSign DeserializeLength(Stream stream, int length, PaintableSign instance, bool isDelta) { }

	// RVA: 0x1F91AF0 Offset: 0x1F900F0 VA: 0x181F91AF0
	public static void SerializeDelta(Stream stream, PaintableSign instance, PaintableSign previous) { }

	// RVA: 0x1F91E90 Offset: 0x1F90490 VA: 0x181F91E90
	public static void Serialize(Stream stream, PaintableSign instance) { }

	// RVA: 0x1F92070 Offset: 0x1F90670 VA: 0x181F92070
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F92080 Offset: 0x1F90680 VA: 0x181F92080
	public void ToProto(Stream stream) { }

	// RVA: 0x1F91D80 Offset: 0x1F90380 VA: 0x181F91D80
	public static byte[] SerializeToBytes(PaintableSign instance) { }

	// RVA: 0x1F91CD0 Offset: 0x1F902D0 VA: 0x181F91CD0
	public static void SerializeLengthDelimited(Stream stream, PaintableSign instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

