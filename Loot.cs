public class Loot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6313
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1F24F50 Offset: 0x1F23550 VA: 0x181F24F50
	public static void ResetToPool(Loot instance) { }

	// RVA: 0x1F24EB0 Offset: 0x1F234B0 VA: 0x181F24EB0
	public void ResetToPool() { }

	// RVA: 0x1F24D50 Offset: 0x1F23350 VA: 0x181F24D50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC0B40 Offset: 0x1DBF140 VA: 0x181DC0B40
	public void CopyTo(Loot instance) { }

	// RVA: 0x1F24210 Offset: 0x1F22810 VA: 0x181F24210
	public Loot Copy() { }

	// RVA: 0x1F24AB0 Offset: 0x1F230B0 VA: 0x181F24AB0
	public static Loot Deserialize(Stream stream) { }

	// RVA: 0x1F242E0 Offset: 0x1F228E0 VA: 0x181F242E0
	public static Loot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F24850 Offset: 0x1F22E50 VA: 0x181F24850
	public static Loot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F24C30 Offset: 0x1F23230 VA: 0x181F24C30
	public static Loot Deserialize(byte[] buffer) { }

	// RVA: 0x1F24E70 Offset: 0x1F23470 VA: 0x181F24E70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F254E0 Offset: 0x1F23AE0 VA: 0x181F254E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F25500 Offset: 0x1F23B00 VA: 0x181F25500 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Loot previous) { }

	// RVA: 0x1F24E90 Offset: 0x1F23490 VA: 0x181F24E90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F24B30 Offset: 0x1F23130 VA: 0x181F24B30
	public static Loot Deserialize(byte[] buffer, Loot instance, bool isDelta = False) { }

	// RVA: 0x1F248E0 Offset: 0x1F22EE0 VA: 0x181F248E0
	public static Loot Deserialize(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F24360 Offset: 0x1F22960 VA: 0x181F24360
	public static Loot DeserializeLengthDelimited(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F245F0 Offset: 0x1F22BF0 VA: 0x181F245F0
	public static Loot DeserializeLength(Stream stream, int length, Loot instance, bool isDelta) { }

	// RVA: 0x1F24FF0 Offset: 0x1F235F0 VA: 0x181F24FF0
	public static void SerializeDelta(Stream stream, Loot instance, Loot previous) { }

	// RVA: 0x1F25350 Offset: 0x1F23950 VA: 0x181F25350
	public static void Serialize(Stream stream, Loot instance) { }

	// RVA: 0x1F254D0 Offset: 0x1F23AD0 VA: 0x181F254D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F254E0 Offset: 0x1F23AE0 VA: 0x181F254E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F25240 Offset: 0x1F23840 VA: 0x181F25240
	public static byte[] SerializeToBytes(Loot instance) { }

	// RVA: 0x1F25190 Offset: 0x1F23790 VA: 0x181F25190
	public static void SerializeLengthDelimited(Stream stream, Loot instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

