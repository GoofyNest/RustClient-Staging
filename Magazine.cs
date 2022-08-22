public class Magazine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6317
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int capacity; // 0x14
	public int contents; // 0x18
	public int ammoType; // 0x1C

	// Methods

	// RVA: 0x1F29D10 Offset: 0x1F28310 VA: 0x181F29D10
	public static void ResetToPool(Magazine instance) { }

	// RVA: 0x1F29C80 Offset: 0x1F28280 VA: 0x181F29C80
	public void ResetToPool() { }

	// RVA: 0x1F299A0 Offset: 0x1F27FA0 VA: 0x181F299A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28720 Offset: 0x1E26D20 VA: 0x181E28720
	public void CopyTo(Magazine instance) { }

	// RVA: 0x1F28A70 Offset: 0x1F27070 VA: 0x181F28A70
	public Magazine Copy() { }

	// RVA: 0x1F29530 Offset: 0x1F27B30 VA: 0x181F29530
	public static Magazine Deserialize(Stream stream) { }

	// RVA: 0x1F28AF0 Offset: 0x1F270F0 VA: 0x181F28AF0
	public static Magazine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F29050 Offset: 0x1F27650 VA: 0x181F29050
	public static Magazine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F290E0 Offset: 0x1F276E0 VA: 0x181F290E0
	public static Magazine Deserialize(byte[] buffer) { }

	// RVA: 0x1F29AB0 Offset: 0x1F280B0 VA: 0x181F29AB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2A250 Offset: 0x1F28850 VA: 0x181F2A250 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2A270 Offset: 0x1F28870 VA: 0x181F2A270 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Magazine previous) { }

	// RVA: 0x1F29C60 Offset: 0x1F28260 VA: 0x181F29C60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F29720 Offset: 0x1F27D20 VA: 0x181F29720
	public static Magazine Deserialize(byte[] buffer, Magazine instance, bool isDelta = False) { }

	// RVA: 0x1F29380 Offset: 0x1F27980 VA: 0x181F29380
	public static Magazine Deserialize(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F28B70 Offset: 0x1F27170 VA: 0x181F28B70
	public static Magazine DeserializeLengthDelimited(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F28DF0 Offset: 0x1F273F0 VA: 0x181F28DF0
	public static Magazine DeserializeLength(Stream stream, int length, Magazine instance, bool isDelta) { }

	// RVA: 0x1F29DA0 Offset: 0x1F283A0 VA: 0x181F29DA0
	public static void SerializeDelta(Stream stream, Magazine instance, Magazine previous) { }

	// RVA: 0x1F2A120 Offset: 0x1F28720 VA: 0x181F2A120
	public static void Serialize(Stream stream, Magazine instance) { }

	// RVA: 0x1F2A240 Offset: 0x1F28840 VA: 0x181F2A240
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2A250 Offset: 0x1F28850 VA: 0x181F2A250
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2A010 Offset: 0x1F28610 VA: 0x181F2A010
	public static byte[] SerializeToBytes(Magazine instance) { }

	// RVA: 0x1F29F60 Offset: 0x1F28560 VA: 0x181F29F60
	public static void SerializeLengthDelimited(Stream stream, Magazine instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

