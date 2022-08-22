public class LinePoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6433
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 localPosition; // 0x14
	public Vector3 worldNormal; // 0x20

	// Methods

	// RVA: 0x1F22EB0 Offset: 0x1F214B0 VA: 0x181F22EB0
	public static void ResetToPool(LinePoint instance) { }

	// RVA: 0x1F22E20 Offset: 0x1F21420 VA: 0x181F22E20
	public void ResetToPool() { }

	// RVA: 0x1F22B70 Offset: 0x1F21170 VA: 0x181F22B70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F21D50 Offset: 0x1F20350 VA: 0x181F21D50
	public void CopyTo(LinePoint instance) { }

	// RVA: 0x1F21D90 Offset: 0x1F20390 VA: 0x181F21D90
	public LinePoint Copy() { }

	// RVA: 0x1F22520 Offset: 0x1F20B20 VA: 0x181F22520
	public static LinePoint Deserialize(Stream stream) { }

	// RVA: 0x1F21E20 Offset: 0x1F20420 VA: 0x181F21E20
	public static LinePoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F220F0 Offset: 0x1F206F0 VA: 0x181F220F0
	public static LinePoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F22920 Offset: 0x1F20F20 VA: 0x181F22920
	public static LinePoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F22C80 Offset: 0x1F21280 VA: 0x181F22C80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F236F0 Offset: 0x1F21CF0 VA: 0x181F236F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F23710 Offset: 0x1F21D10 VA: 0x181F23710 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LinePoint previous) { }

	// RVA: 0x1F22E00 Offset: 0x1F21400 VA: 0x181F22E00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F226E0 Offset: 0x1F20CE0 VA: 0x181F226E0
	public static LinePoint Deserialize(byte[] buffer, LinePoint instance, bool isDelta = False) { }

	// RVA: 0x1F223A0 Offset: 0x1F209A0 VA: 0x181F223A0
	public static LinePoint Deserialize(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F21EA0 Offset: 0x1F204A0 VA: 0x181F21EA0
	public static LinePoint DeserializeLengthDelimited(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F22180 Offset: 0x1F20780 VA: 0x181F22180
	public static LinePoint DeserializeLength(Stream stream, int length, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F22F40 Offset: 0x1F21540 VA: 0x181F22F40
	public static void SerializeDelta(Stream stream, LinePoint instance, LinePoint previous) { }

	// RVA: 0x1F234A0 Offset: 0x1F21AA0 VA: 0x181F234A0
	public static void Serialize(Stream stream, LinePoint instance) { }

	// RVA: 0x1F236E0 Offset: 0x1F21CE0 VA: 0x181F236E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F236F0 Offset: 0x1F21CF0 VA: 0x181F236F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F23390 Offset: 0x1F21990 VA: 0x181F23390
	public static byte[] SerializeToBytes(LinePoint instance) { }

	// RVA: 0x1F232E0 Offset: 0x1F218E0 VA: 0x181F232E0
	public static void SerializeLengthDelimited(Stream stream, LinePoint instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

