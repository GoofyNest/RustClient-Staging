public class Loot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6313
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1F24630 Offset: 0x1F22C30 VA: 0x181F24630
	public static void ResetToPool(Loot instance) { }

	// RVA: 0x1F24590 Offset: 0x1F22B90 VA: 0x181F24590
	public void ResetToPool() { }

	// RVA: 0x1F24430 Offset: 0x1F22A30 VA: 0x181F24430 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC0250 Offset: 0x1DBE850 VA: 0x181DC0250
	public void CopyTo(Loot instance) { }

	// RVA: 0x1F238F0 Offset: 0x1F21EF0 VA: 0x181F238F0
	public Loot Copy() { }

	// RVA: 0x1F24190 Offset: 0x1F22790 VA: 0x181F24190
	public static Loot Deserialize(Stream stream) { }

	// RVA: 0x1F239C0 Offset: 0x1F21FC0 VA: 0x181F239C0
	public static Loot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F23F30 Offset: 0x1F22530 VA: 0x181F23F30
	public static Loot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F24310 Offset: 0x1F22910 VA: 0x181F24310
	public static Loot Deserialize(byte[] buffer) { }

	// RVA: 0x1F24550 Offset: 0x1F22B50 VA: 0x181F24550
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F24BC0 Offset: 0x1F231C0 VA: 0x181F24BC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F24BE0 Offset: 0x1F231E0 VA: 0x181F24BE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Loot previous) { }

	// RVA: 0x1F24570 Offset: 0x1F22B70 VA: 0x181F24570 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F24210 Offset: 0x1F22810 VA: 0x181F24210
	public static Loot Deserialize(byte[] buffer, Loot instance, bool isDelta = False) { }

	// RVA: 0x1F23FC0 Offset: 0x1F225C0 VA: 0x181F23FC0
	public static Loot Deserialize(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F23A40 Offset: 0x1F22040 VA: 0x181F23A40
	public static Loot DeserializeLengthDelimited(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F23CD0 Offset: 0x1F222D0 VA: 0x181F23CD0
	public static Loot DeserializeLength(Stream stream, int length, Loot instance, bool isDelta) { }

	// RVA: 0x1F246D0 Offset: 0x1F22CD0 VA: 0x181F246D0
	public static void SerializeDelta(Stream stream, Loot instance, Loot previous) { }

	// RVA: 0x1F24A30 Offset: 0x1F23030 VA: 0x181F24A30
	public static void Serialize(Stream stream, Loot instance) { }

	// RVA: 0x1F24BB0 Offset: 0x1F231B0 VA: 0x181F24BB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F24BC0 Offset: 0x1F231C0 VA: 0x181F24BC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F24920 Offset: 0x1F22F20 VA: 0x181F24920
	public static byte[] SerializeToBytes(Loot instance) { }

	// RVA: 0x1F24870 Offset: 0x1F22E70 VA: 0x181F24870
	public static void SerializeLengthDelimited(Stream stream, Loot instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

