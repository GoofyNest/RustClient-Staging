public class MapEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6320
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> fogImages; // 0x18
	public List<uint> paintImages; // 0x20

	// Methods

	// RVA: 0x1F3E880 Offset: 0x1F3CE80 VA: 0x181F3E880
	public static void ResetToPool(MapEntity instance) { }

	// RVA: 0x1F3E730 Offset: 0x1F3CD30 VA: 0x181F3E730
	public void ResetToPool() { }

	// RVA: 0x1F3E530 Offset: 0x1F3CB30 VA: 0x181F3E530 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3D730 Offset: 0x1F3BD30 VA: 0x181F3D730
	public void CopyTo(MapEntity instance) { }

	// RVA: 0x1F3D930 Offset: 0x1F3BF30 VA: 0x181F3D930
	public MapEntity Copy() { }

	// RVA: 0x1F3E4B0 Offset: 0x1F3CAB0 VA: 0x181F3E4B0
	public static MapEntity Deserialize(Stream stream) { }

	// RVA: 0x1F3D9B0 Offset: 0x1F3BFB0 VA: 0x181F3D9B0
	public static MapEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3DD20 Offset: 0x1F3C320 VA: 0x181F3DD20
	public static MapEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3E180 Offset: 0x1F3C780 VA: 0x181F3E180
	public static MapEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1F3E6F0 Offset: 0x1F3CCF0 VA: 0x181F3E6F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F3EF60 Offset: 0x1F3D560 VA: 0x181F3EF60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F3EF80 Offset: 0x1F3D580 VA: 0x181F3EF80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapEntity previous) { }

	// RVA: 0x1F3E710 Offset: 0x1F3CD10 VA: 0x181F3E710 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3E080 Offset: 0x1F3C680 VA: 0x181F3E080
	public static MapEntity Deserialize(byte[] buffer, MapEntity instance, bool isDelta = False) { }

	// RVA: 0x1F3E2A0 Offset: 0x1F3C8A0 VA: 0x181F3E2A0
	public static MapEntity Deserialize(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3DA30 Offset: 0x1F3C030 VA: 0x181F3DA30
	public static MapEntity DeserializeLengthDelimited(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3DDB0 Offset: 0x1F3C3B0 VA: 0x181F3DDB0
	public static MapEntity DeserializeLength(Stream stream, int length, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F3E9D0 Offset: 0x1F3CFD0 VA: 0x181F3E9D0
	public static void SerializeDelta(Stream stream, MapEntity instance, MapEntity previous) { }

	// RVA: 0x1F3ED70 Offset: 0x1F3D370 VA: 0x181F3ED70
	public static void Serialize(Stream stream, MapEntity instance) { }

	// RVA: 0x1F3EF50 Offset: 0x1F3D550 VA: 0x181F3EF50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F3EF60 Offset: 0x1F3D560 VA: 0x181F3EF60
	public void ToProto(Stream stream) { }

	// RVA: 0x1F3EC60 Offset: 0x1F3D260 VA: 0x181F3EC60
	public static byte[] SerializeToBytes(MapEntity instance) { }

	// RVA: 0x1F3EBB0 Offset: 0x1F3D1B0 VA: 0x181F3EBB0
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

