public class LinePoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6433
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 localPosition; // 0x14
	public Vector3 worldNormal; // 0x20

	// Methods

	// RVA: 0x1F23170 Offset: 0x1F21770 VA: 0x181F23170
	public static void ResetToPool(LinePoint instance) { }

	// RVA: 0x1F230E0 Offset: 0x1F216E0 VA: 0x181F230E0
	public void ResetToPool() { }

	// RVA: 0x1F22E30 Offset: 0x1F21430 VA: 0x181F22E30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F22010 Offset: 0x1F20610 VA: 0x181F22010
	public void CopyTo(LinePoint instance) { }

	// RVA: 0x1F22050 Offset: 0x1F20650 VA: 0x181F22050
	public LinePoint Copy() { }

	// RVA: 0x1F227E0 Offset: 0x1F20DE0 VA: 0x181F227E0
	public static LinePoint Deserialize(Stream stream) { }

	// RVA: 0x1F220E0 Offset: 0x1F206E0 VA: 0x181F220E0
	public static LinePoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F223B0 Offset: 0x1F209B0 VA: 0x181F223B0
	public static LinePoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F22BE0 Offset: 0x1F211E0 VA: 0x181F22BE0
	public static LinePoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F22F40 Offset: 0x1F21540 VA: 0x181F22F40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F239B0 Offset: 0x1F21FB0 VA: 0x181F239B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F239D0 Offset: 0x1F21FD0 VA: 0x181F239D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LinePoint previous) { }

	// RVA: 0x1F230C0 Offset: 0x1F216C0 VA: 0x181F230C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F229A0 Offset: 0x1F20FA0 VA: 0x181F229A0
	public static LinePoint Deserialize(byte[] buffer, LinePoint instance, bool isDelta = False) { }

	// RVA: 0x1F22660 Offset: 0x1F20C60 VA: 0x181F22660
	public static LinePoint Deserialize(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F22160 Offset: 0x1F20760 VA: 0x181F22160
	public static LinePoint DeserializeLengthDelimited(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F22440 Offset: 0x1F20A40 VA: 0x181F22440
	public static LinePoint DeserializeLength(Stream stream, int length, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F23200 Offset: 0x1F21800 VA: 0x181F23200
	public static void SerializeDelta(Stream stream, LinePoint instance, LinePoint previous) { }

	// RVA: 0x1F23760 Offset: 0x1F21D60 VA: 0x181F23760
	public static void Serialize(Stream stream, LinePoint instance) { }

	// RVA: 0x1F239A0 Offset: 0x1F21FA0 VA: 0x181F239A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F239B0 Offset: 0x1F21FB0 VA: 0x181F239B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F23650 Offset: 0x1F21C50 VA: 0x181F23650
	public static byte[] SerializeToBytes(LinePoint instance) { }

	// RVA: 0x1F235A0 Offset: 0x1F21BA0 VA: 0x181F235A0
	public static void SerializeLengthDelimited(Stream stream, LinePoint instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

