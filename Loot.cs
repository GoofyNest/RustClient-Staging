public class Loot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6313
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1F24730 Offset: 0x1F22D30 VA: 0x181F24730
	public static void ResetToPool(Loot instance) { }

	// RVA: 0x1F24690 Offset: 0x1F22C90 VA: 0x181F24690
	public void ResetToPool() { }

	// RVA: 0x1F24530 Offset: 0x1F22B30 VA: 0x181F24530 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC0350 Offset: 0x1DBE950 VA: 0x181DC0350
	public void CopyTo(Loot instance) { }

	// RVA: 0x1F239F0 Offset: 0x1F21FF0 VA: 0x181F239F0
	public Loot Copy() { }

	// RVA: 0x1F24290 Offset: 0x1F22890 VA: 0x181F24290
	public static Loot Deserialize(Stream stream) { }

	// RVA: 0x1F23AC0 Offset: 0x1F220C0 VA: 0x181F23AC0
	public static Loot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F24030 Offset: 0x1F22630 VA: 0x181F24030
	public static Loot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F24410 Offset: 0x1F22A10 VA: 0x181F24410
	public static Loot Deserialize(byte[] buffer) { }

	// RVA: 0x1F24650 Offset: 0x1F22C50 VA: 0x181F24650
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F24CC0 Offset: 0x1F232C0 VA: 0x181F24CC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F24CE0 Offset: 0x1F232E0 VA: 0x181F24CE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Loot previous) { }

	// RVA: 0x1F24670 Offset: 0x1F22C70 VA: 0x181F24670 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F24310 Offset: 0x1F22910 VA: 0x181F24310
	public static Loot Deserialize(byte[] buffer, Loot instance, bool isDelta = False) { }

	// RVA: 0x1F240C0 Offset: 0x1F226C0 VA: 0x181F240C0
	public static Loot Deserialize(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F23B40 Offset: 0x1F22140 VA: 0x181F23B40
	public static Loot DeserializeLengthDelimited(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F23DD0 Offset: 0x1F223D0 VA: 0x181F23DD0
	public static Loot DeserializeLength(Stream stream, int length, Loot instance, bool isDelta) { }

	// RVA: 0x1F247D0 Offset: 0x1F22DD0 VA: 0x181F247D0
	public static void SerializeDelta(Stream stream, Loot instance, Loot previous) { }

	// RVA: 0x1F24B30 Offset: 0x1F23130 VA: 0x181F24B30
	public static void Serialize(Stream stream, Loot instance) { }

	// RVA: 0x1F24CB0 Offset: 0x1F232B0 VA: 0x181F24CB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F24CC0 Offset: 0x1F232C0 VA: 0x181F24CC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F24A20 Offset: 0x1F23020 VA: 0x181F24A20
	public static byte[] SerializeToBytes(Loot instance) { }

	// RVA: 0x1F24970 Offset: 0x1F22F70 VA: 0x181F24970
	public static void SerializeLengthDelimited(Stream stream, Loot instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

