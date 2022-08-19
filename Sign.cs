public class Sign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6319
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageid; // 0x14
	public List<uint> imageIds; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1E0AF30 Offset: 0x1E09530 VA: 0x181E0AF30
	public static void ResetToPool(Sign instance) { }

	// RVA: 0x1E0ADD0 Offset: 0x1E093D0 VA: 0x181E0ADD0
	public void ResetToPool() { }

	// RVA: 0x1E0ABC0 Offset: 0x1E091C0 VA: 0x181E0ABC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E09C40 Offset: 0x1E08240 VA: 0x181E09C40
	public void CopyTo(Sign instance) { }

	// RVA: 0x1E09E40 Offset: 0x1E08440 VA: 0x181E09E40
	public Sign Copy() { }

	// RVA: 0x1E0AB40 Offset: 0x1E09140 VA: 0x181E0AB40
	public static Sign Deserialize(Stream stream) { }

	// RVA: 0x1E09EC0 Offset: 0x1E084C0 VA: 0x181E09EC0
	public static Sign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0A600 Offset: 0x1E08C00 VA: 0x181E0A600
	public static Sign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0AA20 Offset: 0x1E09020 VA: 0x181E0AA20
	public static Sign Deserialize(byte[] buffer) { }

	// RVA: 0x1E0AD90 Offset: 0x1E09390 VA: 0x181E0AD90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0B6D0 Offset: 0x1E09CD0 VA: 0x181E0B6D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0B6F0 Offset: 0x1E09CF0 VA: 0x181E0B6F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Sign previous) { }

	// RVA: 0x1E0ADB0 Offset: 0x1E093B0 VA: 0x181E0ADB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0A690 Offset: 0x1E08C90 VA: 0x181E0A690
	public static Sign Deserialize(byte[] buffer, Sign instance, bool isDelta = False) { }

	// RVA: 0x1E0A790 Offset: 0x1E08D90 VA: 0x181E0A790
	public static Sign Deserialize(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E09F40 Offset: 0x1E08540 VA: 0x181E09F40
	public static Sign DeserializeLengthDelimited(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E0A2B0 Offset: 0x1E088B0 VA: 0x181E0A2B0
	public static Sign DeserializeLength(Stream stream, int length, Sign instance, bool isDelta) { }

	// RVA: 0x1E0B090 Offset: 0x1E09690 VA: 0x181E0B090
	public static void SerializeDelta(Stream stream, Sign instance, Sign previous) { }

	// RVA: 0x1E0B490 Offset: 0x1E09A90 VA: 0x181E0B490
	public static void Serialize(Stream stream, Sign instance) { }

	// RVA: 0x1E0B6C0 Offset: 0x1E09CC0 VA: 0x181E0B6C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0B6D0 Offset: 0x1E09CD0 VA: 0x181E0B6D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0B380 Offset: 0x1E09980 VA: 0x181E0B380
	public static byte[] SerializeToBytes(Sign instance) { }

	// RVA: 0x1E0B2D0 Offset: 0x1E098D0 VA: 0x181E0B2D0
	public static void SerializeLengthDelimited(Stream stream, Sign instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

