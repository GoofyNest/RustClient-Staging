public class SimpleUID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6350
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14

	// Methods

	// RVA: 0x1E0D3B0 Offset: 0x1E0B9B0 VA: 0x181E0D3B0
	public static void ResetToPool(SimpleUID instance) { }

	// RVA: 0x1E0D430 Offset: 0x1E0BA30 VA: 0x181E0D430
	public void ResetToPool() { }

	// RVA: 0x1E0D280 Offset: 0x1E0B880 VA: 0x181E0D280 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(SimpleUID instance) { }

	// RVA: 0x1E0C900 Offset: 0x1E0AF00 VA: 0x181E0C900
	public SimpleUID Copy() { }

	// RVA: 0x1E0CEA0 Offset: 0x1E0B4A0 VA: 0x181E0CEA0
	public static SimpleUID Deserialize(Stream stream) { }

	// RVA: 0x1E0C970 Offset: 0x1E0AF70 VA: 0x181E0C970
	public static SimpleUID DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0CE10 Offset: 0x1E0B410 VA: 0x181E0CE10
	public static SimpleUID DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0D160 Offset: 0x1E0B760 VA: 0x181E0D160
	public static SimpleUID Deserialize(byte[] buffer) { }

	// RVA: 0x1E0D370 Offset: 0x1E0B970 VA: 0x181E0D370
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0D900 Offset: 0x1E0BF00 VA: 0x181E0D900 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0D9D0 Offset: 0x1E0BFD0 VA: 0x181E0D9D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleUID previous) { }

	// RVA: 0x1E0D390 Offset: 0x1E0B990 VA: 0x181E0D390 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0D060 Offset: 0x1E0B660 VA: 0x181E0D060
	public static SimpleUID Deserialize(byte[] buffer, SimpleUID instance, bool isDelta = False) { }

	// RVA: 0x1E0CF20 Offset: 0x1E0B520 VA: 0x181E0CF20
	public static SimpleUID Deserialize(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0C9F0 Offset: 0x1E0AFF0 VA: 0x181E0C9F0
	public static SimpleUID DeserializeLengthDelimited(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0CC10 Offset: 0x1E0B210 VA: 0x181E0CC10
	public static SimpleUID DeserializeLength(Stream stream, int length, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0D4B0 Offset: 0x1E0BAB0 VA: 0x181E0D4B0
	public static void SerializeDelta(Stream stream, SimpleUID instance, SimpleUID previous) { }

	// RVA: 0x1E0D820 Offset: 0x1E0BE20 VA: 0x181E0D820
	public static void Serialize(Stream stream, SimpleUID instance) { }

	// RVA: 0x1E0D8F0 Offset: 0x1E0BEF0 VA: 0x181E0D8F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0D900 Offset: 0x1E0BF00 VA: 0x181E0D900
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0D670 Offset: 0x1E0BC70 VA: 0x181E0D670
	public static byte[] SerializeToBytes(SimpleUID instance) { }

	// RVA: 0x1E0D5C0 Offset: 0x1E0BBC0 VA: 0x181E0D5C0
	public static void SerializeLengthDelimited(Stream stream, SimpleUID instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

