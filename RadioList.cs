public class RadioList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6505
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<string> stationUrls; // 0x18
	public List<string> stationNames; // 0x20

	// Methods

	// RVA: 0x20513D0 Offset: 0x204F9D0 VA: 0x1820513D0
	public static void ResetToPool(RadioList instance) { }

	// RVA: 0x2051520 Offset: 0x204FB20 VA: 0x182051520
	public void ResetToPool() { }

	// RVA: 0x20511D0 Offset: 0x204F7D0 VA: 0x1820511D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20503D0 Offset: 0x204E9D0 VA: 0x1820503D0
	public void CopyTo(RadioList instance) { }

	// RVA: 0x20505D0 Offset: 0x204EBD0 VA: 0x1820505D0
	public RadioList Copy() { }

	// RVA: 0x2050E20 Offset: 0x204F420 VA: 0x182050E20
	public static RadioList Deserialize(Stream stream) { }

	// RVA: 0x2050650 Offset: 0x204EC50 VA: 0x182050650
	public static RadioList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2050C90 Offset: 0x204F290 VA: 0x182050C90
	public static RadioList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2050EA0 Offset: 0x204F4A0 VA: 0x182050EA0
	public static RadioList Deserialize(byte[] buffer) { }

	// RVA: 0x2051390 Offset: 0x204F990 VA: 0x182051390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2051C20 Offset: 0x2050220 VA: 0x182051C20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2051C40 Offset: 0x2050240 VA: 0x182051C40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RadioList previous) { }

	// RVA: 0x20513B0 Offset: 0x204F9B0 VA: 0x1820513B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2050D20 Offset: 0x204F320 VA: 0x182050D20
	public static RadioList Deserialize(byte[] buffer, RadioList instance, bool isDelta = False) { }

	// RVA: 0x2050FC0 Offset: 0x204F5C0 VA: 0x182050FC0
	public static RadioList Deserialize(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x20506D0 Offset: 0x204ECD0 VA: 0x1820506D0
	public static RadioList DeserializeLengthDelimited(Stream stream, RadioList instance, bool isDelta) { }

	// RVA: 0x20509C0 Offset: 0x204EFC0 VA: 0x1820509C0
	public static RadioList DeserializeLength(Stream stream, int length, RadioList instance, bool isDelta) { }

	// RVA: 0x2051670 Offset: 0x204FC70 VA: 0x182051670
	public static void SerializeDelta(Stream stream, RadioList instance, RadioList previous) { }

	// RVA: 0x2051A20 Offset: 0x2050020 VA: 0x182051A20
	public static void Serialize(Stream stream, RadioList instance) { }

	// RVA: 0x2051C10 Offset: 0x2050210 VA: 0x182051C10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2051C20 Offset: 0x2050220 VA: 0x182051C20
	public void ToProto(Stream stream) { }

	// RVA: 0x2051910 Offset: 0x204FF10 VA: 0x182051910
	public static byte[] SerializeToBytes(RadioList instance) { }

	// RVA: 0x2051860 Offset: 0x204FE60 VA: 0x182051860
	public static void SerializeLengthDelimited(Stream stream, RadioList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

