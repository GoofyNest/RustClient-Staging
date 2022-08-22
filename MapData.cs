public class MapData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6508
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F2B070 Offset: 0x1F29670 VA: 0x181F2B070
	public static void ResetToPool(MapData instance) { }

	// RVA: 0x1F2AFC0 Offset: 0x1F295C0 VA: 0x181F2AFC0
	public void ResetToPool() { }

	// RVA: 0x1F2AE50 Offset: 0x1F29450 VA: 0x181F2AE50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F2A290 Offset: 0x1F28890 VA: 0x181F2A290
	public void CopyTo(MapData instance) { }

	// RVA: 0x1F2A340 Offset: 0x1F28940 VA: 0x181F2A340
	public MapData Copy() { }

	// RVA: 0x1F2AB20 Offset: 0x1F29120 VA: 0x181F2AB20
	public static MapData Deserialize(Stream stream) { }

	// RVA: 0x1F2A6C0 Offset: 0x1F28CC0 VA: 0x181F2A6C0
	public static MapData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2A740 Offset: 0x1F28D40 VA: 0x181F2A740
	public static MapData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2AD30 Offset: 0x1F29330 VA: 0x181F2AD30
	public static MapData Deserialize(byte[] buffer) { }

	// RVA: 0x1F2AF80 Offset: 0x1F29580 VA: 0x181F2AF80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2B6B0 Offset: 0x1F29CB0 VA: 0x181F2B6B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2B6D0 Offset: 0x1F29CD0 VA: 0x181F2B6D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapData previous) { }

	// RVA: 0x1F2AFA0 Offset: 0x1F295A0 VA: 0x181F2AFA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2AA20 Offset: 0x1F29020 VA: 0x181F2AA20
	public static MapData Deserialize(byte[] buffer, MapData instance, bool isDelta = False) { }

	// RVA: 0x1F2ABA0 Offset: 0x1F291A0 VA: 0x181F2ABA0
	public static MapData Deserialize(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F2A450 Offset: 0x1F28A50 VA: 0x181F2A450
	public static MapData DeserializeLengthDelimited(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F2A7D0 Offset: 0x1F28DD0 VA: 0x181F2A7D0
	public static MapData DeserializeLength(Stream stream, int length, MapData instance, bool isDelta) { }

	// RVA: 0x1F2B120 Offset: 0x1F29720 VA: 0x181F2B120
	public static void SerializeDelta(Stream stream, MapData instance, MapData previous) { }

	// RVA: 0x1F2B4D0 Offset: 0x1F29AD0 VA: 0x181F2B4D0
	public static void Serialize(Stream stream, MapData instance) { }

	// RVA: 0x1F2B6A0 Offset: 0x1F29CA0 VA: 0x181F2B6A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2B6B0 Offset: 0x1F29CB0 VA: 0x181F2B6B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2B3C0 Offset: 0x1F299C0 VA: 0x181F2B3C0
	public static byte[] SerializeToBytes(MapData instance) { }

	// RVA: 0x1F2B310 Offset: 0x1F29910 VA: 0x181F2B310
	public static void SerializeLengthDelimited(Stream stream, MapData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

