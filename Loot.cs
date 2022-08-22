public class Loot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6313
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1F24470 Offset: 0x1F22A70 VA: 0x181F24470
	public static void ResetToPool(Loot instance) { }

	// RVA: 0x1F243D0 Offset: 0x1F229D0 VA: 0x181F243D0
	public void ResetToPool() { }

	// RVA: 0x1F24270 Offset: 0x1F22870 VA: 0x181F24270 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC0090 Offset: 0x1DBE690 VA: 0x181DC0090
	public void CopyTo(Loot instance) { }

	// RVA: 0x1F23730 Offset: 0x1F21D30 VA: 0x181F23730
	public Loot Copy() { }

	// RVA: 0x1F23FD0 Offset: 0x1F225D0 VA: 0x181F23FD0
	public static Loot Deserialize(Stream stream) { }

	// RVA: 0x1F23800 Offset: 0x1F21E00 VA: 0x181F23800
	public static Loot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F23D70 Offset: 0x1F22370 VA: 0x181F23D70
	public static Loot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F24150 Offset: 0x1F22750 VA: 0x181F24150
	public static Loot Deserialize(byte[] buffer) { }

	// RVA: 0x1F24390 Offset: 0x1F22990 VA: 0x181F24390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F24A00 Offset: 0x1F23000 VA: 0x181F24A00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F24A20 Offset: 0x1F23020 VA: 0x181F24A20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Loot previous) { }

	// RVA: 0x1F243B0 Offset: 0x1F229B0 VA: 0x181F243B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F24050 Offset: 0x1F22650 VA: 0x181F24050
	public static Loot Deserialize(byte[] buffer, Loot instance, bool isDelta = False) { }

	// RVA: 0x1F23E00 Offset: 0x1F22400 VA: 0x181F23E00
	public static Loot Deserialize(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F23880 Offset: 0x1F21E80 VA: 0x181F23880
	public static Loot DeserializeLengthDelimited(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F23B10 Offset: 0x1F22110 VA: 0x181F23B10
	public static Loot DeserializeLength(Stream stream, int length, Loot instance, bool isDelta) { }

	// RVA: 0x1F24510 Offset: 0x1F22B10 VA: 0x181F24510
	public static void SerializeDelta(Stream stream, Loot instance, Loot previous) { }

	// RVA: 0x1F24870 Offset: 0x1F22E70 VA: 0x181F24870
	public static void Serialize(Stream stream, Loot instance) { }

	// RVA: 0x1F249F0 Offset: 0x1F22FF0 VA: 0x181F249F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F24A00 Offset: 0x1F23000 VA: 0x181F24A00
	public void ToProto(Stream stream) { }

	// RVA: 0x1F24760 Offset: 0x1F22D60 VA: 0x181F24760
	public static byte[] SerializeToBytes(Loot instance) { }

	// RVA: 0x1F246B0 Offset: 0x1F22CB0 VA: 0x181F246B0
	public static void SerializeLengthDelimited(Stream stream, Loot instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

