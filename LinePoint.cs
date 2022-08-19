public class LinePoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6433
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 localPosition; // 0x14
	public Vector3 worldNormal; // 0x20

	// Methods

	// RVA: 0x1F23070 Offset: 0x1F21670 VA: 0x181F23070
	public static void ResetToPool(LinePoint instance) { }

	// RVA: 0x1F22FE0 Offset: 0x1F215E0 VA: 0x181F22FE0
	public void ResetToPool() { }

	// RVA: 0x1F22D30 Offset: 0x1F21330 VA: 0x181F22D30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F21F10 Offset: 0x1F20510 VA: 0x181F21F10
	public void CopyTo(LinePoint instance) { }

	// RVA: 0x1F21F50 Offset: 0x1F20550 VA: 0x181F21F50
	public LinePoint Copy() { }

	// RVA: 0x1F226E0 Offset: 0x1F20CE0 VA: 0x181F226E0
	public static LinePoint Deserialize(Stream stream) { }

	// RVA: 0x1F21FE0 Offset: 0x1F205E0 VA: 0x181F21FE0
	public static LinePoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F222B0 Offset: 0x1F208B0 VA: 0x181F222B0
	public static LinePoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F22AE0 Offset: 0x1F210E0 VA: 0x181F22AE0
	public static LinePoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F22E40 Offset: 0x1F21440 VA: 0x181F22E40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F238B0 Offset: 0x1F21EB0 VA: 0x181F238B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F238D0 Offset: 0x1F21ED0 VA: 0x181F238D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LinePoint previous) { }

	// RVA: 0x1F22FC0 Offset: 0x1F215C0 VA: 0x181F22FC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F228A0 Offset: 0x1F20EA0 VA: 0x181F228A0
	public static LinePoint Deserialize(byte[] buffer, LinePoint instance, bool isDelta = False) { }

	// RVA: 0x1F22560 Offset: 0x1F20B60 VA: 0x181F22560
	public static LinePoint Deserialize(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F22060 Offset: 0x1F20660 VA: 0x181F22060
	public static LinePoint DeserializeLengthDelimited(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F22340 Offset: 0x1F20940 VA: 0x181F22340
	public static LinePoint DeserializeLength(Stream stream, int length, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F23100 Offset: 0x1F21700 VA: 0x181F23100
	public static void SerializeDelta(Stream stream, LinePoint instance, LinePoint previous) { }

	// RVA: 0x1F23660 Offset: 0x1F21C60 VA: 0x181F23660
	public static void Serialize(Stream stream, LinePoint instance) { }

	// RVA: 0x1F238A0 Offset: 0x1F21EA0 VA: 0x181F238A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F238B0 Offset: 0x1F21EB0 VA: 0x181F238B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F23550 Offset: 0x1F21B50 VA: 0x181F23550
	public static byte[] SerializeToBytes(LinePoint instance) { }

	// RVA: 0x1F234A0 Offset: 0x1F21AA0 VA: 0x181F234A0
	public static void SerializeLengthDelimited(Stream stream, LinePoint instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

