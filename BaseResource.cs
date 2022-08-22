public class BaseResource : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6297
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int stage; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1F66E00 Offset: 0x1F65400 VA: 0x181F66E00
	public static void ResetToPool(BaseResource instance) { }

	// RVA: 0x1F66D80 Offset: 0x1F65380 VA: 0x181F66D80
	public void ResetToPool() { }

	// RVA: 0x1F66AE0 Offset: 0x1F650E0 VA: 0x181F66AE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(BaseResource instance) { }

	// RVA: 0x1F65CE0 Offset: 0x1F642E0 VA: 0x181F65CE0
	public BaseResource Copy() { }

	// RVA: 0x1F66550 Offset: 0x1F64B50 VA: 0x181F66550
	public static BaseResource Deserialize(Stream stream) { }

	// RVA: 0x1F65FA0 Offset: 0x1F645A0 VA: 0x181F65FA0
	public static BaseResource DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F66020 Offset: 0x1F64620 VA: 0x181F66020
	public static BaseResource DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F662E0 Offset: 0x1F648E0 VA: 0x181F662E0
	public static BaseResource Deserialize(byte[] buffer) { }

	// RVA: 0x1F66BE0 Offset: 0x1F651E0 VA: 0x181F66BE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F672D0 Offset: 0x1F658D0 VA: 0x181F672D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F672F0 Offset: 0x1F658F0 VA: 0x181F672F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseResource previous) { }

	// RVA: 0x1F66D60 Offset: 0x1F65360 VA: 0x181F66D60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F66890 Offset: 0x1F64E90 VA: 0x181F66890
	public static BaseResource Deserialize(byte[] buffer, BaseResource instance, bool isDelta = False) { }

	// RVA: 0x1F66710 Offset: 0x1F64D10 VA: 0x181F66710
	public static BaseResource Deserialize(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F65D50 Offset: 0x1F64350 VA: 0x181F65D50
	public static BaseResource DeserializeLengthDelimited(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F660B0 Offset: 0x1F646B0 VA: 0x181F660B0
	public static BaseResource DeserializeLength(Stream stream, int length, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F66E80 Offset: 0x1F65480 VA: 0x181F66E80
	public static void SerializeDelta(Stream stream, BaseResource instance, BaseResource previous) { }

	// RVA: 0x1F671C0 Offset: 0x1F657C0 VA: 0x181F671C0
	public static void Serialize(Stream stream, BaseResource instance) { }

	// RVA: 0x1F672C0 Offset: 0x1F658C0 VA: 0x181F672C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F672D0 Offset: 0x1F658D0 VA: 0x181F672D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F670B0 Offset: 0x1F656B0 VA: 0x181F670B0
	public static byte[] SerializeToBytes(BaseResource instance) { }

	// RVA: 0x1F67000 Offset: 0x1F65600 VA: 0x181F67000
	public static void SerializeLengthDelimited(Stream stream, BaseResource instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

