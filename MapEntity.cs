public class MapEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6320
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> fogImages; // 0x18
	public List<uint> paintImages; // 0x20

	// Methods

	// RVA: 0x1F3E980 Offset: 0x1F3CF80 VA: 0x181F3E980
	public static void ResetToPool(MapEntity instance) { }

	// RVA: 0x1F3E830 Offset: 0x1F3CE30 VA: 0x181F3E830
	public void ResetToPool() { }

	// RVA: 0x1F3E630 Offset: 0x1F3CC30 VA: 0x181F3E630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3D830 Offset: 0x1F3BE30 VA: 0x181F3D830
	public void CopyTo(MapEntity instance) { }

	// RVA: 0x1F3DA30 Offset: 0x1F3C030 VA: 0x181F3DA30
	public MapEntity Copy() { }

	// RVA: 0x1F3E5B0 Offset: 0x1F3CBB0 VA: 0x181F3E5B0
	public static MapEntity Deserialize(Stream stream) { }

	// RVA: 0x1F3DAB0 Offset: 0x1F3C0B0 VA: 0x181F3DAB0
	public static MapEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3DE20 Offset: 0x1F3C420 VA: 0x181F3DE20
	public static MapEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3E280 Offset: 0x1F3C880 VA: 0x181F3E280
	public static MapEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1F3E7F0 Offset: 0x1F3CDF0 VA: 0x181F3E7F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F3F060 Offset: 0x1F3D660 VA: 0x181F3F060 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F3F080 Offset: 0x1F3D680 VA: 0x181F3F080 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapEntity previous) { }

	// RVA: 0x1F3E810 Offset: 0x1F3CE10 VA: 0x181F3E810 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3E180 Offset: 0x1F3C780 VA: 0x181F3E180
	public static MapEntity Deserialize(byte[] buffer, MapEntity instance, bool isDelta = False) { }

	// RVA: 0x1F3E3A0 Offset: 0x1F3C9A0 VA: 0x181F3E3A0
	public static MapEntity Deserialize(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3DB30 Offset: 0x1F3C130 VA: 0x181F3DB30
	public static MapEntity DeserializeLengthDelimited(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3DEB0 Offset: 0x1F3C4B0 VA: 0x181F3DEB0
	public static MapEntity DeserializeLength(Stream stream, int length, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3EAD0 Offset: 0x1F3D0D0 VA: 0x181F3EAD0
	public static void SerializeDelta(Stream stream, MapEntity instance, MapEntity previous) { }

	// RVA: 0x1F3EE70 Offset: 0x1F3D470 VA: 0x181F3EE70
	public static void Serialize(Stream stream, MapEntity instance) { }

	// RVA: 0x1F3F050 Offset: 0x1F3D650 VA: 0x181F3F050
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F3F060 Offset: 0x1F3D660 VA: 0x181F3F060
	public void ToProto(Stream stream) { }

	// RVA: 0x1F3ED60 Offset: 0x1F3D360 VA: 0x181F3ED60
	public static byte[] SerializeToBytes(MapEntity instance) { }

	// RVA: 0x1F3ECB0 Offset: 0x1F3D2B0 VA: 0x181F3ECB0
	public static void SerializeLengthDelimited(Stream stream, MapEntity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class MapEntity : HeldEntity // TypeDefIndex: 8601
{	// Fields
	public uint[] fogImages; // 0x1F8
	public uint[] paintImages; // 0x200

	// Methods

	// RVA: 0x5631F0 Offset: 0x5617F0 VA: 0x1805631F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5630D0 Offset: 0x5616D0 VA: 0x1805630D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5632E0 Offset: 0x5618E0 VA: 0x1805632E0
	public void PaintImageUpdate(int id, uint hash, byte[] data) { }

	// RVA: 0x5633A0 Offset: 0x5619A0 VA: 0x1805633A0
	public void .ctor() { }

}

