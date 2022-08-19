public class RadioList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6505
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<string> stationUrls; // 0x18
	public List<string> stationNames; // 0x20

	// Methods

	// RVA: 0x20512D0 Offset: 0x204F8D0 VA: 0x1820512D0
	public static void ResetToPool(RadioList instance) { }

	// RVA: 0x2051420 Offset: 0x204FA20 VA: 0x182051420
	public void ResetToPool() { }

	// RVA: 0x20510D0 Offset: 0x204F6D0 VA: 0x1820510D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20502D0 Offset: 0x204E8D0 VA: 0x1820502D0
	public void CopyTo(RadioList instance) { }

	// RVA: 0x20504D0 Offset: 0x204EAD0 VA: 0x1820504D0
	public RadioList Copy() { }

	// RVA: 0x2050D20 Offset: 0x204F320 VA: 0x182050D20
	public static RadioList Deserialize(Stream stream) { }

	// RVA: 0x2050550 Offset: 0x204EB50 VA: 0x182050550
	public static RadioList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2050B90 Offset: 0x204F190 VA: 0x182050B90
	public static RadioList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2050DA0 Offset: 0x204F3A0 VA: 0x182050DA0
	public static RadioList Deserialize(byte[] buffer) { }

	// RVA: 0x2051290 Offset: 0x204F890 VA: 0x182051290
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2051B20 Offset: 0x2050120 VA: 0x182051B20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2051B40 Offset: 0x2050140 VA: 0x182051B40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RadioList previous) { }

	// RVA: 0x20512B0 Offset: 0x204F8B0 VA: 0x1820512B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2050C20 Offset: 0x204F220 VA: 0x182050C20
	public static RadioList Deserialize(byte[] buffer, RadioList instance, bool isDelta = False) { }

	// RVA: 0x2050EC0 Offset: 0x204F4C0 VA: 0x182050EC0
	public static RadioList Deserialize(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x20505D0 Offset: 0x204EBD0 VA: 0x1820505D0
	public static RadioList DeserializeLengthDelimited(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x20508C0 Offset: 0x204EEC0 VA: 0x1820508C0
	public static RadioList DeserializeLength(Stream stream, int length, RadioList instance, bool isDelta) { }

	// RVA: 0x2051570 Offset: 0x204FB70 VA: 0x182051570
	public static void SerializeDelta(Stream stream, RadioList instance, RadioList previous) { }

	// RVA: 0x2051920 Offset: 0x204FF20 VA: 0x182051920
	public static void Serialize(Stream stream, RadioList instance) { }

	// RVA: 0x2051B10 Offset: 0x2050110 VA: 0x182051B10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2051B20 Offset: 0x2050120 VA: 0x182051B20
	public void ToProto(Stream stream) { }

	// RVA: 0x2051810 Offset: 0x204FE10 VA: 0x182051810
	public static byte[] SerializeToBytes(RadioList instance) { }

	// RVA: 0x2051760 Offset: 0x204FD60 VA: 0x182051760
	public static void SerializeLengthDelimited(Stream stream, RadioList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

