public class BaseResource : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6297
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int stage; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1F66D00 Offset: 0x1F65300 VA: 0x181F66D00
	public static void ResetToPool(BaseResource instance) { }

	// RVA: 0x1F66C80 Offset: 0x1F65280 VA: 0x181F66C80
	public void ResetToPool() { }

	// RVA: 0x1F669E0 Offset: 0x1F64FE0 VA: 0x181F669E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEAA0 Offset: 0x1DBD0A0 VA: 0x181DBEAA0
	public void CopyTo(BaseResource instance) { }

	// RVA: 0x1F65BE0 Offset: 0x1F641E0 VA: 0x181F65BE0
	public BaseResource Copy() { }

	// RVA: 0x1F66450 Offset: 0x1F64A50 VA: 0x181F66450
	public static BaseResource Deserialize(Stream stream) { }

	// RVA: 0x1F65EA0 Offset: 0x1F644A0 VA: 0x181F65EA0
	public static BaseResource DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F65F20 Offset: 0x1F64520 VA: 0x181F65F20
	public static BaseResource DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F661E0 Offset: 0x1F647E0 VA: 0x181F661E0
	public static BaseResource Deserialize(byte[] buffer) { }

	// RVA: 0x1F66AE0 Offset: 0x1F650E0 VA: 0x181F66AE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F671D0 Offset: 0x1F657D0 VA: 0x181F671D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F671F0 Offset: 0x1F657F0 VA: 0x181F671F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseResource previous) { }

	// RVA: 0x1F66C60 Offset: 0x1F65260 VA: 0x181F66C60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F66790 Offset: 0x1F64D90 VA: 0x181F66790
	public static BaseResource Deserialize(byte[] buffer, BaseResource instance, bool isDelta = False) { }

	// RVA: 0x1F66610 Offset: 0x1F64C10 VA: 0x181F66610
	public static BaseResource Deserialize(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F65C50 Offset: 0x1F64250 VA: 0x181F65C50
	public static BaseResource DeserializeLengthDelimited(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F65FB0 Offset: 0x1F645B0 VA: 0x181F65FB0
	public static BaseResource DeserializeLength(Stream stream, int length, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F66D80 Offset: 0x1F65380 VA: 0x181F66D80
	public static void SerializeDelta(Stream stream, BaseResource instance, BaseResource previous) { }

	// RVA: 0x1F670C0 Offset: 0x1F656C0 VA: 0x181F670C0
	public static void Serialize(Stream stream, BaseResource instance) { }

	// RVA: 0x1F671C0 Offset: 0x1F657C0 VA: 0x181F671C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F671D0 Offset: 0x1F657D0 VA: 0x181F671D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F66FB0 Offset: 0x1F655B0 VA: 0x181F66FB0
	public static byte[] SerializeToBytes(BaseResource instance) { }

	// RVA: 0x1F66F00 Offset: 0x1F65500 VA: 0x181F66F00
	public static void SerializeLengthDelimited(Stream stream, BaseResource instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

