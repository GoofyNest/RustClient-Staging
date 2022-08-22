public class BaseResource : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6297
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int stage; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1F66B40 Offset: 0x1F65140 VA: 0x181F66B40
	public static void ResetToPool(BaseResource instance) { }

	// RVA: 0x1F66AC0 Offset: 0x1F650C0 VA: 0x181F66AC0
	public void ResetToPool() { }

	// RVA: 0x1F66820 Offset: 0x1F64E20 VA: 0x181F66820 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(BaseResource instance) { }

	// RVA: 0x1F65A20 Offset: 0x1F64020 VA: 0x181F65A20
	public BaseResource Copy() { }

	// RVA: 0x1F66290 Offset: 0x1F64890 VA: 0x181F66290
	public static BaseResource Deserialize(Stream stream) { }

	// RVA: 0x1F65CE0 Offset: 0x1F642E0 VA: 0x181F65CE0
	public static BaseResource DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F65D60 Offset: 0x1F64360 VA: 0x181F65D60
	public static BaseResource DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F66020 Offset: 0x1F64620 VA: 0x181F66020
	public static BaseResource Deserialize(byte[] buffer) { }

	// RVA: 0x1F66920 Offset: 0x1F64F20 VA: 0x181F66920
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F67010 Offset: 0x1F65610 VA: 0x181F67010 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F67030 Offset: 0x1F65630 VA: 0x181F67030 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseResource previous) { }

	// RVA: 0x1F66AA0 Offset: 0x1F650A0 VA: 0x181F66AA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F665D0 Offset: 0x1F64BD0 VA: 0x181F665D0
	public static BaseResource Deserialize(byte[] buffer, BaseResource instance, bool isDelta = False) { }

	// RVA: 0x1F66450 Offset: 0x1F64A50 VA: 0x181F66450
	public static BaseResource Deserialize(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F65A90 Offset: 0x1F64090 VA: 0x181F65A90
	public static BaseResource DeserializeLengthDelimited(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F65DF0 Offset: 0x1F643F0 VA: 0x181F65DF0
	public static BaseResource DeserializeLength(Stream stream, int length, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F66BC0 Offset: 0x1F651C0 VA: 0x181F66BC0
	public static void SerializeDelta(Stream stream, BaseResource instance, BaseResource previous) { }

	// RVA: 0x1F66F00 Offset: 0x1F65500 VA: 0x181F66F00
	public static void Serialize(Stream stream, BaseResource instance) { }

	// RVA: 0x1F67000 Offset: 0x1F65600 VA: 0x181F67000
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F67010 Offset: 0x1F65610 VA: 0x181F67010
	public void ToProto(Stream stream) { }

	// RVA: 0x1F66DF0 Offset: 0x1F653F0 VA: 0x181F66DF0
	public static byte[] SerializeToBytes(BaseResource instance) { }

	// RVA: 0x1F66D40 Offset: 0x1F65340 VA: 0x181F66D40
	public static void SerializeLengthDelimited(Stream stream, BaseResource instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

