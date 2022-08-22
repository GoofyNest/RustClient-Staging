public class Sign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6319
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageid; // 0x14
	public List<uint> imageIds; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1E0B030 Offset: 0x1E09630 VA: 0x181E0B030
	public static void ResetToPool(Sign instance) { }

	// RVA: 0x1E0AED0 Offset: 0x1E094D0 VA: 0x181E0AED0
	public void ResetToPool() { }

	// RVA: 0x1E0ACC0 Offset: 0x1E092C0 VA: 0x181E0ACC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E09D40 Offset: 0x1E08340 VA: 0x181E09D40
	public void CopyTo(Sign instance) { }

	// RVA: 0x1E09F40 Offset: 0x1E08540 VA: 0x181E09F40
	public Sign Copy() { }

	// RVA: 0x1E0AC40 Offset: 0x1E09240 VA: 0x181E0AC40
	public static Sign Deserialize(Stream stream) { }

	// RVA: 0x1E09FC0 Offset: 0x1E085C0 VA: 0x181E09FC0
	public static Sign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0A700 Offset: 0x1E08D00 VA: 0x181E0A700
	public static Sign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0AB20 Offset: 0x1E09120 VA: 0x181E0AB20
	public static Sign Deserialize(byte[] buffer) { }

	// RVA: 0x1E0AE90 Offset: 0x1E09490 VA: 0x181E0AE90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0B7D0 Offset: 0x1E09DD0 VA: 0x181E0B7D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0B7F0 Offset: 0x1E09DF0 VA: 0x181E0B7F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Sign previous) { }

	// RVA: 0x1E0AEB0 Offset: 0x1E094B0 VA: 0x181E0AEB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0A790 Offset: 0x1E08D90 VA: 0x181E0A790
	public static Sign Deserialize(byte[] buffer, Sign instance, bool isDelta = False) { }

	// RVA: 0x1E0A890 Offset: 0x1E08E90 VA: 0x181E0A890
	public static Sign Deserialize(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E0A040 Offset: 0x1E08640 VA: 0x181E0A040
	public static Sign DeserializeLengthDelimited(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E0A3B0 Offset: 0x1E089B0 VA: 0x181E0A3B0
	public static Sign DeserializeLength(Stream stream, int length, Sign instance, bool isDelta) { }

	// RVA: 0x1E0B190 Offset: 0x1E09790 VA: 0x181E0B190
	public static void SerializeDelta(Stream stream, Sign instance, Sign previous) { }

	// RVA: 0x1E0B590 Offset: 0x1E09B90 VA: 0x181E0B590
	public static void Serialize(Stream stream, Sign instance) { }

	// RVA: 0x1E0B7C0 Offset: 0x1E09DC0 VA: 0x181E0B7C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0B7D0 Offset: 0x1E09DD0 VA: 0x181E0B7D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0B480 Offset: 0x1E09A80 VA: 0x181E0B480
	public static byte[] SerializeToBytes(Sign instance) { }

	// RVA: 0x1E0B3D0 Offset: 0x1E099D0 VA: 0x181E0B3D0
	public static void SerializeLengthDelimited(Stream stream, Sign instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

