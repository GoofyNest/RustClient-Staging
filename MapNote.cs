public class MapNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6460
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int noteType; // 0x14
	public Vector3 worldPosition; // 0x18

	// Methods

	// RVA: 0x1F41EA0 Offset: 0x1F404A0 VA: 0x181F41EA0
	public static void ResetToPool(MapNote instance) { }

	// RVA: 0x1F41E10 Offset: 0x1F40410 VA: 0x181F41E10
	public void ResetToPool() { }

	// RVA: 0x1F41D50 Offset: 0x1F40350 VA: 0x181F41D50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFDC30 Offset: 0x1BFC230 VA: 0x181BFDC30
	public void CopyTo(MapNote instance) { }

	// RVA: 0x1F41300 Offset: 0x1F3F900 VA: 0x181F41300
	public MapNote Copy() { }

	// RVA: 0x1F41AB0 Offset: 0x1F400B0 VA: 0x181F41AB0
	public static MapNote Deserialize(Stream stream) { }

	// RVA: 0x1F415E0 Offset: 0x1F3FBE0 VA: 0x181F415E0
	public static MapNote DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F41890 Offset: 0x1F3FE90 VA: 0x181F41890
	public static MapNote DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F41C30 Offset: 0x1F40230 VA: 0x181F41C30
	public static MapNote Deserialize(byte[] buffer) { }

	// RVA: 0x1F41DD0 Offset: 0x1F403D0 VA: 0x181F41DD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F42530 Offset: 0x1F40B30 VA: 0x181F42530 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F42550 Offset: 0x1F40B50 VA: 0x181F42550 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNote previous) { }

	// RVA: 0x1F41DF0 Offset: 0x1F403F0 VA: 0x181F41DF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F41B30 Offset: 0x1F40130 VA: 0x181F41B30
	public static MapNote Deserialize(byte[] buffer, MapNote instance, bool isDelta = False) { }

	// RVA: 0x1F41920 Offset: 0x1F3FF20 VA: 0x181F41920
	public static MapNote Deserialize(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F41380 Offset: 0x1F3F980 VA: 0x181F41380
	public static MapNote DeserializeLengthDelimited(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F41660 Offset: 0x1F3FC60 VA: 0x181F41660
	public static MapNote DeserializeLength(Stream stream, int length, MapNote instance, bool isDelta) { }

	// RVA: 0x1F41F30 Offset: 0x1F40530 VA: 0x181F41F30
	public static void SerializeDelta(Stream stream, MapNote instance, MapNote previous) { }

	// RVA: 0x1F42380 Offset: 0x1F40980 VA: 0x181F42380
	public static void Serialize(Stream stream, MapNote instance) { }

	// RVA: 0x1F42520 Offset: 0x1F40B20 VA: 0x181F42520
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F42530 Offset: 0x1F40B30 VA: 0x181F42530
	public void ToProto(Stream stream) { }

	// RVA: 0x1F42270 Offset: 0x1F40870 VA: 0x181F42270
	public static byte[] SerializeToBytes(MapNote instance) { }

	// RVA: 0x1F421C0 Offset: 0x1F407C0 VA: 0x181F421C0
	public static void SerializeLengthDelimited(Stream stream, MapNote instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

