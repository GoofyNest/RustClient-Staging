public class SimpleUID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6350
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14

	// Methods

	// RVA: 0x1E0DBD0 Offset: 0x1E0C1D0 VA: 0x181E0DBD0
	public static void ResetToPool(SimpleUID instance) { }

	// RVA: 0x1E0DC50 Offset: 0x1E0C250 VA: 0x181E0DC50
	public void ResetToPool() { }

	// RVA: 0x1E0DAA0 Offset: 0x1E0C0A0 VA: 0x181E0DAA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(SimpleUID instance) { }

	// RVA: 0x1E0D120 Offset: 0x1E0B720 VA: 0x181E0D120
	public SimpleUID Copy() { }

	// RVA: 0x1E0D6C0 Offset: 0x1E0BCC0 VA: 0x181E0D6C0
	public static SimpleUID Deserialize(Stream stream) { }

	// RVA: 0x1E0D190 Offset: 0x1E0B790 VA: 0x181E0D190
	public static SimpleUID DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0D630 Offset: 0x1E0BC30 VA: 0x181E0D630
	public static SimpleUID DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0D980 Offset: 0x1E0BF80 VA: 0x181E0D980
	public static SimpleUID Deserialize(byte[] buffer) { }

	// RVA: 0x1E0DB90 Offset: 0x1E0C190 VA: 0x181E0DB90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0E120 Offset: 0x1E0C720 VA: 0x181E0E120 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0E1F0 Offset: 0x1E0C7F0 VA: 0x181E0E1F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleUID previous) { }

	// RVA: 0x1E0DBB0 Offset: 0x1E0C1B0 VA: 0x181E0DBB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0D880 Offset: 0x1E0BE80 VA: 0x181E0D880
	public static SimpleUID Deserialize(byte[] buffer, SimpleUID instance, bool isDelta = False) { }

	// RVA: 0x1E0D740 Offset: 0x1E0BD40 VA: 0x181E0D740
	public static SimpleUID Deserialize(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0D210 Offset: 0x1E0B810 VA: 0x181E0D210
	public static SimpleUID DeserializeLengthDelimited(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0D430 Offset: 0x1E0BA30 VA: 0x181E0D430
	public static SimpleUID DeserializeLength(Stream stream, int length, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0DCD0 Offset: 0x1E0C2D0 VA: 0x181E0DCD0
	public static void SerializeDelta(Stream stream, SimpleUID instance, SimpleUID previous) { }

	// RVA: 0x1E0E040 Offset: 0x1E0C640 VA: 0x181E0E040
	public static void Serialize(Stream stream, SimpleUID instance) { }

	// RVA: 0x1E0E110 Offset: 0x1E0C710 VA: 0x181E0E110
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0E120 Offset: 0x1E0C720 VA: 0x181E0E120
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0DE90 Offset: 0x1E0C490 VA: 0x181E0DE90
	public static byte[] SerializeToBytes(SimpleUID instance) { }

	// RVA: 0x1E0DDE0 Offset: 0x1E0C3E0 VA: 0x181E0DDE0
	public static void SerializeLengthDelimited(Stream stream, SimpleUID instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

