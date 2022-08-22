public class RadioList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6505
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<string> stationUrls; // 0x18
	public List<string> stationNames; // 0x20

	// Methods

	// RVA: 0x2051BF0 Offset: 0x20501F0 VA: 0x182051BF0
	public static void ResetToPool(RadioList instance) { }

	// RVA: 0x2051D40 Offset: 0x2050340 VA: 0x182051D40
	public void ResetToPool() { }

	// RVA: 0x20519F0 Offset: 0x204FFF0 VA: 0x1820519F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2050BF0 Offset: 0x204F1F0 VA: 0x182050BF0
	public void CopyTo(RadioList instance) { }

	// RVA: 0x2050DF0 Offset: 0x204F3F0 VA: 0x182050DF0
	public RadioList Copy() { }

	// RVA: 0x2051640 Offset: 0x204FC40 VA: 0x182051640
	public static RadioList Deserialize(Stream stream) { }

	// RVA: 0x2050E70 Offset: 0x204F470 VA: 0x182050E70
	public static RadioList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20514B0 Offset: 0x204FAB0 VA: 0x1820514B0
	public static RadioList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20516C0 Offset: 0x204FCC0 VA: 0x1820516C0
	public static RadioList Deserialize(byte[] buffer) { }

	// RVA: 0x2051BB0 Offset: 0x20501B0 VA: 0x182051BB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2052440 Offset: 0x2050A40 VA: 0x182052440 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2052460 Offset: 0x2050A60 VA: 0x182052460 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RadioList previous) { }

	// RVA: 0x2051BD0 Offset: 0x20501D0 VA: 0x182051BD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2051540 Offset: 0x204FB40 VA: 0x182051540
	public static RadioList Deserialize(byte[] buffer, RadioList instance, bool isDelta = False) { }

	// RVA: 0x20517E0 Offset: 0x204FDE0 VA: 0x1820517E0
	public static RadioList Deserialize(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x2050EF0 Offset: 0x204F4F0 VA: 0x182050EF0
	public static RadioList DeserializeLengthDelimited(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x20511E0 Offset: 0x204F7E0 VA: 0x1820511E0
	public static RadioList DeserializeLength(Stream stream, int length, RadioList instance, bool isDelta) { }

	// RVA: 0x2051E90 Offset: 0x2050490 VA: 0x182051E90
	public static void SerializeDelta(Stream stream, RadioList instance, RadioList previous) { }

	// RVA: 0x2052240 Offset: 0x2050840 VA: 0x182052240
	public static void Serialize(Stream stream, RadioList instance) { }

	// RVA: 0x2052430 Offset: 0x2050A30 VA: 0x182052430
	public byte[] ToProtoBytes() { }

	// RVA: 0x2052440 Offset: 0x2050A40 VA: 0x182052440
	public void ToProto(Stream stream) { }

	// RVA: 0x2052130 Offset: 0x2050730 VA: 0x182052130
	public static byte[] SerializeToBytes(RadioList instance) { }

	// RVA: 0x2052080 Offset: 0x2050680 VA: 0x182052080
	public static void SerializeLengthDelimited(Stream stream, RadioList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

