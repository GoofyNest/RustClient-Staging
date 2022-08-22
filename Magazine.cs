public class Magazine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6317
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int capacity; // 0x14
	public int contents; // 0x18
	public int ammoType; // 0x1C

	// Methods

	// RVA: 0x1F29A50 Offset: 0x1F28050 VA: 0x181F29A50
	public static void ResetToPool(Magazine instance) { }

	// RVA: 0x1F299C0 Offset: 0x1F27FC0 VA: 0x181F299C0
	public void ResetToPool() { }

	// RVA: 0x1F296E0 Offset: 0x1F27CE0 VA: 0x181F296E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28460 Offset: 0x1E26A60 VA: 0x181E28460
	public void CopyTo(Magazine instance) { }

	// RVA: 0x1F287B0 Offset: 0x1F26DB0 VA: 0x181F287B0
	public Magazine Copy() { }

	// RVA: 0x1F29270 Offset: 0x1F27870 VA: 0x181F29270
	public static Magazine Deserialize(Stream stream) { }

	// RVA: 0x1F28830 Offset: 0x1F26E30 VA: 0x181F28830
	public static Magazine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F28D90 Offset: 0x1F27390 VA: 0x181F28D90
	public static Magazine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F28E20 Offset: 0x1F27420 VA: 0x181F28E20
	public static Magazine Deserialize(byte[] buffer) { }

	// RVA: 0x1F297F0 Offset: 0x1F27DF0 VA: 0x181F297F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F29F90 Offset: 0x1F28590 VA: 0x181F29F90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F29FB0 Offset: 0x1F285B0 VA: 0x181F29FB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Magazine previous) { }

	// RVA: 0x1F299A0 Offset: 0x1F27FA0 VA: 0x181F299A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F29460 Offset: 0x1F27A60 VA: 0x181F29460
	public static Magazine Deserialize(byte[] buffer, Magazine instance, bool isDelta = False) { }

	// RVA: 0x1F290C0 Offset: 0x1F276C0 VA: 0x181F290C0
	public static Magazine Deserialize(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F288B0 Offset: 0x1F26EB0 VA: 0x181F288B0
	public static Magazine DeserializeLengthDelimited(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F28B30 Offset: 0x1F27130 VA: 0x181F28B30
	public static Magazine DeserializeLength(Stream stream, int length, Magazine instance, bool isDelta) { }

	// RVA: 0x1F29AE0 Offset: 0x1F280E0 VA: 0x181F29AE0
	public static void SerializeDelta(Stream stream, Magazine instance, Magazine previous) { }

	// RVA: 0x1F29E60 Offset: 0x1F28460 VA: 0x181F29E60
	public static void Serialize(Stream stream, Magazine instance) { }

	// RVA: 0x1F29F80 Offset: 0x1F28580 VA: 0x181F29F80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F29F90 Offset: 0x1F28590 VA: 0x181F29F90
	public void ToProto(Stream stream) { }

	// RVA: 0x1F29D50 Offset: 0x1F28350 VA: 0x181F29D50
	public static byte[] SerializeToBytes(Magazine instance) { }

	// RVA: 0x1F29CA0 Offset: 0x1F282A0 VA: 0x181F29CA0
	public static void SerializeLengthDelimited(Stream stream, Magazine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

