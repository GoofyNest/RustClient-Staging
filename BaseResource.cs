public class BaseResource : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6297
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int stage; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1F67620 Offset: 0x1F65C20 VA: 0x181F67620
	public static void ResetToPool(BaseResource instance) { }

	// RVA: 0x1F675A0 Offset: 0x1F65BA0 VA: 0x181F675A0
	public void ResetToPool() { }

	// RVA: 0x1F67300 Offset: 0x1F65900 VA: 0x181F67300 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(BaseResource instance) { }

	// RVA: 0x1F66500 Offset: 0x1F64B00 VA: 0x181F66500
	public BaseResource Copy() { }

	// RVA: 0x1F66D70 Offset: 0x1F65370 VA: 0x181F66D70
	public static BaseResource Deserialize(Stream stream) { }

	// RVA: 0x1F667C0 Offset: 0x1F64DC0 VA: 0x181F667C0
	public static BaseResource DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F66840 Offset: 0x1F64E40 VA: 0x181F66840
	public static BaseResource DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F66B00 Offset: 0x1F65100 VA: 0x181F66B00
	public static BaseResource Deserialize(byte[] buffer) { }

	// RVA: 0x1F67400 Offset: 0x1F65A00 VA: 0x181F67400
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F67AF0 Offset: 0x1F660F0 VA: 0x181F67AF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F67B10 Offset: 0x1F66110 VA: 0x181F67B10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseResource previous) { }

	// RVA: 0x1F67580 Offset: 0x1F65B80 VA: 0x181F67580 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F670B0 Offset: 0x1F656B0 VA: 0x181F670B0
	public static BaseResource Deserialize(byte[] buffer, BaseResource instance, bool isDelta = False) { }

	// RVA: 0x1F66F30 Offset: 0x1F65530 VA: 0x181F66F30
	public static BaseResource Deserialize(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F66570 Offset: 0x1F64B70 VA: 0x181F66570
	public static BaseResource DeserializeLengthDelimited(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F668D0 Offset: 0x1F64ED0 VA: 0x181F668D0
	public static BaseResource DeserializeLength(Stream stream, int length, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F676A0 Offset: 0x1F65CA0 VA: 0x181F676A0
	public static void SerializeDelta(Stream stream, BaseResource instance, BaseResource previous) { }

	// RVA: 0x1F679E0 Offset: 0x1F65FE0 VA: 0x181F679E0
	public static void Serialize(Stream stream, BaseResource instance) { }

	// RVA: 0x1F67AE0 Offset: 0x1F660E0 VA: 0x181F67AE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F67AF0 Offset: 0x1F660F0 VA: 0x181F67AF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F678D0 Offset: 0x1F65ED0 VA: 0x181F678D0
	public static byte[] SerializeToBytes(BaseResource instance) { }

	// RVA: 0x1F67820 Offset: 0x1F65E20 VA: 0x181F67820
	public static void SerializeLengthDelimited(Stream stream, BaseResource instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

