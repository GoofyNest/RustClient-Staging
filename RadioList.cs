public class RadioList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6505
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<string> stationUrls; // 0x18
	public List<string> stationNames; // 0x20

	// Methods

	// RVA: 0x2051110 Offset: 0x204F710 VA: 0x182051110
	public static void ResetToPool(RadioList instance) { }

	// RVA: 0x2051260 Offset: 0x204F860 VA: 0x182051260
	public void ResetToPool() { }

	// RVA: 0x2050F10 Offset: 0x204F510 VA: 0x182050F10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2050110 Offset: 0x204E710 VA: 0x182050110
	public void CopyTo(RadioList instance) { }

	// RVA: 0x2050310 Offset: 0x204E910 VA: 0x182050310
	public RadioList Copy() { }

	// RVA: 0x2050B60 Offset: 0x204F160 VA: 0x182050B60
	public static RadioList Deserialize(Stream stream) { }

	// RVA: 0x2050390 Offset: 0x204E990 VA: 0x182050390
	public static RadioList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20509D0 Offset: 0x204EFD0 VA: 0x1820509D0
	public static RadioList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2050BE0 Offset: 0x204F1E0 VA: 0x182050BE0
	public static RadioList Deserialize(byte[] buffer) { }

	// RVA: 0x20510D0 Offset: 0x204F6D0 VA: 0x1820510D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2051960 Offset: 0x204FF60 VA: 0x182051960 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2051980 Offset: 0x204FF80 VA: 0x182051980 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RadioList previous) { }

	// RVA: 0x20510F0 Offset: 0x204F6F0 VA: 0x1820510F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2050A60 Offset: 0x204F060 VA: 0x182050A60
	public static RadioList Deserialize(byte[] buffer, RadioList instance, bool isDelta = False) { }

	// RVA: 0x2050D00 Offset: 0x204F300 VA: 0x182050D00
	public static RadioList Deserialize(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x2050410 Offset: 0x204EA10 VA: 0x182050410
	public static RadioList DeserializeLengthDelimited(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x2050700 Offset: 0x204ED00 VA: 0x182050700
	public static RadioList DeserializeLength(Stream stream, int length, RadioList instance, bool isDelta) { }

	// RVA: 0x20513B0 Offset: 0x204F9B0 VA: 0x1820513B0
	public static void SerializeDelta(Stream stream, RadioList instance, RadioList previous) { }

	// RVA: 0x2051760 Offset: 0x204FD60 VA: 0x182051760
	public static void Serialize(Stream stream, RadioList instance) { }

	// RVA: 0x2051950 Offset: 0x204FF50 VA: 0x182051950
	public byte[] ToProtoBytes() { }

	// RVA: 0x2051960 Offset: 0x204FF60 VA: 0x182051960
	public void ToProto(Stream stream) { }

	// RVA: 0x2051650 Offset: 0x204FC50 VA: 0x182051650
	public static byte[] SerializeToBytes(RadioList instance) { }

	// RVA: 0x20515A0 Offset: 0x204FBA0 VA: 0x1820515A0
	public static void SerializeLengthDelimited(Stream stream, RadioList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

