public class MapEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6320
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> fogImages; // 0x18
	public List<uint> paintImages; // 0x20

	// Methods

	// RVA: 0x1F3F1A0 Offset: 0x1F3D7A0 VA: 0x181F3F1A0
	public static void ResetToPool(MapEntity instance) { }

	// RVA: 0x1F3F050 Offset: 0x1F3D650 VA: 0x181F3F050
	public void ResetToPool() { }

	// RVA: 0x1F3EE50 Offset: 0x1F3D450 VA: 0x181F3EE50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3E050 Offset: 0x1F3C650 VA: 0x181F3E050
	public void CopyTo(MapEntity instance) { }

	// RVA: 0x1F3E250 Offset: 0x1F3C850 VA: 0x181F3E250
	public MapEntity Copy() { }

	// RVA: 0x1F3EDD0 Offset: 0x1F3D3D0 VA: 0x181F3EDD0
	public static MapEntity Deserialize(Stream stream) { }

	// RVA: 0x1F3E2D0 Offset: 0x1F3C8D0 VA: 0x181F3E2D0
	public static MapEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3E640 Offset: 0x1F3CC40 VA: 0x181F3E640
	public static MapEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3EAA0 Offset: 0x1F3D0A0 VA: 0x181F3EAA0
	public static MapEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1F3F010 Offset: 0x1F3D610 VA: 0x181F3F010
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F3F880 Offset: 0x1F3DE80 VA: 0x181F3F880 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F3F8A0 Offset: 0x1F3DEA0 VA: 0x181F3F8A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapEntity previous) { }

	// RVA: 0x1F3F030 Offset: 0x1F3D630 VA: 0x181F3F030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3E9A0 Offset: 0x1F3CFA0 VA: 0x181F3E9A0
	public static MapEntity Deserialize(byte[] buffer, MapEntity instance, bool isDelta = False) { }

	// RVA: 0x1F3EBC0 Offset: 0x1F3D1C0 VA: 0x181F3EBC0
	public static MapEntity Deserialize(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3E350 Offset: 0x1F3C950 VA: 0x181F3E350
	public static MapEntity DeserializeLengthDelimited(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3E6D0 Offset: 0x1F3CCD0 VA: 0x181F3E6D0
	public static MapEntity DeserializeLength(Stream stream, int length, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3F2F0 Offset: 0x1F3D8F0 VA: 0x181F3F2F0
	public static void SerializeDelta(Stream stream, MapEntity instance, MapEntity previous) { }

	// RVA: 0x1F3F690 Offset: 0x1F3DC90 VA: 0x181F3F690
	public static void Serialize(Stream stream, MapEntity instance) { }

	// RVA: 0x1F3F870 Offset: 0x1F3DE70 VA: 0x181F3F870
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F3F880 Offset: 0x1F3DE80 VA: 0x181F3F880
	public void ToProto(Stream stream) { }

	// RVA: 0x1F3F580 Offset: 0x1F3DB80 VA: 0x181F3F580
	public static byte[] SerializeToBytes(MapEntity instance) { }

	// RVA: 0x1F3F4D0 Offset: 0x1F3DAD0 VA: 0x181F3F4D0
	public static void SerializeLengthDelimited(Stream stream, MapEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class MapEntity : HeldEntity // TypeDefIndex: 8601
{	// Fields
	public uint[] fogImages; // 0x1F8
	public uint[] paintImages; // 0x200

	// Methods

	// RVA: 0x563180 Offset: 0x561780 VA: 0x180563180 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x563060 Offset: 0x561660 VA: 0x180563060 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x563270 Offset: 0x561870 VA: 0x180563270
	public void PaintImageUpdate(int id, uint hash, byte[] data) { }

	// RVA: 0x563330 Offset: 0x561930 VA: 0x180563330
	public void .ctor() { }

}

