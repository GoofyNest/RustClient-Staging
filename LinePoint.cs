public class LinePoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6433
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 localPosition; // 0x14
	public Vector3 worldNormal; // 0x20

	// Methods

	// RVA: 0x1F23990 Offset: 0x1F21F90 VA: 0x181F23990
	public static void ResetToPool(LinePoint instance) { }

	// RVA: 0x1F23900 Offset: 0x1F21F00 VA: 0x181F23900
	public void ResetToPool() { }

	// RVA: 0x1F23650 Offset: 0x1F21C50 VA: 0x181F23650 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F22830 Offset: 0x1F20E30 VA: 0x181F22830
	public void CopyTo(LinePoint instance) { }

	// RVA: 0x1F22870 Offset: 0x1F20E70 VA: 0x181F22870
	public LinePoint Copy() { }

	// RVA: 0x1F23000 Offset: 0x1F21600 VA: 0x181F23000
	public static LinePoint Deserialize(Stream stream) { }

	// RVA: 0x1F22900 Offset: 0x1F20F00 VA: 0x181F22900
	public static LinePoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F22BD0 Offset: 0x1F211D0 VA: 0x181F22BD0
	public static LinePoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F23400 Offset: 0x1F21A00 VA: 0x181F23400
	public static LinePoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F23760 Offset: 0x1F21D60 VA: 0x181F23760
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F241D0 Offset: 0x1F227D0 VA: 0x181F241D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F241F0 Offset: 0x1F227F0 VA: 0x181F241F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LinePoint previous) { }

	// RVA: 0x1F238E0 Offset: 0x1F21EE0 VA: 0x181F238E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F231C0 Offset: 0x1F217C0 VA: 0x181F231C0
	public static LinePoint Deserialize(byte[] buffer, LinePoint instance, bool isDelta = False) { }

	// RVA: 0x1F22E80 Offset: 0x1F21480 VA: 0x181F22E80
	public static LinePoint Deserialize(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F22980 Offset: 0x1F20F80 VA: 0x181F22980
	public static LinePoint DeserializeLengthDelimited(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F22C60 Offset: 0x1F21260 VA: 0x181F22C60
	public static LinePoint DeserializeLength(Stream stream, int length, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F23A20 Offset: 0x1F22020 VA: 0x181F23A20
	public static void SerializeDelta(Stream stream, LinePoint instance, LinePoint previous) { }

	// RVA: 0x1F23F80 Offset: 0x1F22580 VA: 0x181F23F80
	public static void Serialize(Stream stream, LinePoint instance) { }

	// RVA: 0x1F241C0 Offset: 0x1F227C0 VA: 0x181F241C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F241D0 Offset: 0x1F227D0 VA: 0x181F241D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F23E70 Offset: 0x1F22470 VA: 0x181F23E70
	public static byte[] SerializeToBytes(LinePoint instance) { }

	// RVA: 0x1F23DC0 Offset: 0x1F223C0 VA: 0x181F23DC0
	public static void SerializeLengthDelimited(Stream stream, LinePoint instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

