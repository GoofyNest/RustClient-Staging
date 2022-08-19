public class Magazine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6317
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int capacity; // 0x14
	public int contents; // 0x18
	public int ammoType; // 0x1C

	// Methods

	// RVA: 0x1F29C10 Offset: 0x1F28210 VA: 0x181F29C10
	public static void ResetToPool(Magazine instance) { }

	// RVA: 0x1F29B80 Offset: 0x1F28180 VA: 0x181F29B80
	public void ResetToPool() { }

	// RVA: 0x1F298A0 Offset: 0x1F27EA0 VA: 0x181F298A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28620 Offset: 0x1E26C20 VA: 0x181E28620
	public void CopyTo(Magazine instance) { }

	// RVA: 0x1F28970 Offset: 0x1F26F70 VA: 0x181F28970
	public Magazine Copy() { }

	// RVA: 0x1F29430 Offset: 0x1F27A30 VA: 0x181F29430
	public static Magazine Deserialize(Stream stream) { }

	// RVA: 0x1F289F0 Offset: 0x1F26FF0 VA: 0x181F289F0
	public static Magazine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F28F50 Offset: 0x1F27550 VA: 0x181F28F50
	public static Magazine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F28FE0 Offset: 0x1F275E0 VA: 0x181F28FE0
	public static Magazine Deserialize(byte[] buffer) { }

	// RVA: 0x1F299B0 Offset: 0x1F27FB0 VA: 0x181F299B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2A150 Offset: 0x1F28750 VA: 0x181F2A150 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2A170 Offset: 0x1F28770 VA: 0x181F2A170 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Magazine previous) { }

	// RVA: 0x1F29B60 Offset: 0x1F28160 VA: 0x181F29B60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F29620 Offset: 0x1F27C20 VA: 0x181F29620
	public static Magazine Deserialize(byte[] buffer, Magazine instance, bool isDelta = False) { }

	// RVA: 0x1F29280 Offset: 0x1F27880 VA: 0x181F29280
	public static Magazine Deserialize(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F28A70 Offset: 0x1F27070 VA: 0x181F28A70
	public static Magazine DeserializeLengthDelimited(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F28CF0 Offset: 0x1F272F0 VA: 0x181F28CF0
	public static Magazine DeserializeLength(Stream stream, int length, Magazine instance, bool isDelta) { }

	// RVA: 0x1F29CA0 Offset: 0x1F282A0 VA: 0x181F29CA0
	public static void SerializeDelta(Stream stream, Magazine instance, Magazine previous) { }

	// RVA: 0x1F2A020 Offset: 0x1F28620 VA: 0x181F2A020
	public static void Serialize(Stream stream, Magazine instance) { }

	// RVA: 0x1F2A140 Offset: 0x1F28740 VA: 0x181F2A140
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2A150 Offset: 0x1F28750 VA: 0x181F2A150
	public void ToProto(Stream stream) { }

	// RVA: 0x1F29F10 Offset: 0x1F28510 VA: 0x181F29F10
	public static byte[] SerializeToBytes(Magazine instance) { }

	// RVA: 0x1F29E60 Offset: 0x1F28460 VA: 0x181F29E60
	public static void SerializeLengthDelimited(Stream stream, Magazine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

