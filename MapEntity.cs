public class MapEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6320
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> fogImages; // 0x18
	public List<uint> paintImages; // 0x20

	// Methods

	// RVA: 0x1F3E6C0 Offset: 0x1F3CCC0 VA: 0x181F3E6C0
	public static void ResetToPool(MapEntity instance) { }

	// RVA: 0x1F3E570 Offset: 0x1F3CB70 VA: 0x181F3E570
	public void ResetToPool() { }

	// RVA: 0x1F3E370 Offset: 0x1F3C970 VA: 0x181F3E370 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3D570 Offset: 0x1F3BB70 VA: 0x181F3D570
	public void CopyTo(MapEntity instance) { }

	// RVA: 0x1F3D770 Offset: 0x1F3BD70 VA: 0x181F3D770
	public MapEntity Copy() { }

	// RVA: 0x1F3E2F0 Offset: 0x1F3C8F0 VA: 0x181F3E2F0
	public static MapEntity Deserialize(Stream stream) { }

	// RVA: 0x1F3D7F0 Offset: 0x1F3BDF0 VA: 0x181F3D7F0
	public static MapEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3DB60 Offset: 0x1F3C160 VA: 0x181F3DB60
	public static MapEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3DFC0 Offset: 0x1F3C5C0 VA: 0x181F3DFC0
	public static MapEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1F3E530 Offset: 0x1F3CB30 VA: 0x181F3E530
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F3EDA0 Offset: 0x1F3D3A0 VA: 0x181F3EDA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F3EDC0 Offset: 0x1F3D3C0 VA: 0x181F3EDC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapEntity previous) { }

	// RVA: 0x1F3E550 Offset: 0x1F3CB50 VA: 0x181F3E550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3DEC0 Offset: 0x1F3C4C0 VA: 0x181F3DEC0
	public static MapEntity Deserialize(byte[] buffer, MapEntity instance, bool isDelta = False) { }

	// RVA: 0x1F3E0E0 Offset: 0x1F3C6E0 VA: 0x181F3E0E0
	public static MapEntity Deserialize(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3D870 Offset: 0x1F3BE70 VA: 0x181F3D870
	public static MapEntity DeserializeLengthDelimited(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3DBF0 Offset: 0x1F3C1F0 VA: 0x181F3DBF0
	public static MapEntity DeserializeLength(Stream stream, int length, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3E810 Offset: 0x1F3CE10 VA: 0x181F3E810
	public static void SerializeDelta(Stream stream, MapEntity instance, MapEntity previous) { }

	// RVA: 0x1F3EBB0 Offset: 0x1F3D1B0 VA: 0x181F3EBB0
	public static void Serialize(Stream stream, MapEntity instance) { }

	// RVA: 0x1F3ED90 Offset: 0x1F3D390 VA: 0x181F3ED90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F3EDA0 Offset: 0x1F3D3A0 VA: 0x181F3EDA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F3EAA0 Offset: 0x1F3D0A0 VA: 0x181F3EAA0
	public static byte[] SerializeToBytes(MapEntity instance) { }

	// RVA: 0x1F3E9F0 Offset: 0x1F3CFF0 VA: 0x181F3E9F0
	public static void SerializeLengthDelimited(Stream stream, MapEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

