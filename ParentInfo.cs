public class ParentInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6302
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint bone; // 0x18

	// Methods

	// RVA: 0x1F946E0 Offset: 0x1F92CE0 VA: 0x181F946E0
	public static void ResetToPool(ParentInfo instance) { }

	// RVA: 0x1F94660 Offset: 0x1F92C60 VA: 0x181F94660
	public void ResetToPool() { }

	// RVA: 0x1F943C0 Offset: 0x1F929C0 VA: 0x181F943C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(ParentInfo instance) { }

	// RVA: 0x1F935C0 Offset: 0x1F91BC0 VA: 0x181F935C0
	public ParentInfo Copy() { }

	// RVA: 0x1F93E10 Offset: 0x1F92410 VA: 0x181F93E10
	public static ParentInfo Deserialize(Stream stream) { }

	// RVA: 0x1F93630 Offset: 0x1F91C30 VA: 0x181F93630
	public static ParentInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F93900 Offset: 0x1F91F00 VA: 0x181F93900
	public static ParentInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F93FD0 Offset: 0x1F925D0 VA: 0x181F93FD0
	public static ParentInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F944C0 Offset: 0x1F92AC0 VA: 0x181F944C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F94BA0 Offset: 0x1F931A0 VA: 0x181F94BA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F94BC0 Offset: 0x1F931C0 VA: 0x181F94BC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ParentInfo previous) { }

	// RVA: 0x1F94640 Offset: 0x1F92C40 VA: 0x181F94640 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F93BC0 Offset: 0x1F921C0 VA: 0x181F93BC0
	public static ParentInfo Deserialize(byte[] buffer, ParentInfo instance, bool isDelta = False) { }

	// RVA: 0x1F94240 Offset: 0x1F92840 VA: 0x181F94240
	public static ParentInfo Deserialize(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F936B0 Offset: 0x1F91CB0 VA: 0x181F936B0
	public static ParentInfo DeserializeLengthDelimited(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F93990 Offset: 0x1F91F90 VA: 0x181F93990
	public static ParentInfo DeserializeLength(Stream stream, int length, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F94760 Offset: 0x1F92D60 VA: 0x181F94760
	public static void SerializeDelta(Stream stream, ParentInfo instance, ParentInfo previous) { }

	// RVA: 0x1F94A90 Offset: 0x1F93090 VA: 0x181F94A90
	public static void Serialize(Stream stream, ParentInfo instance) { }

	// RVA: 0x1F94B90 Offset: 0x1F93190 VA: 0x181F94B90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F94BA0 Offset: 0x1F931A0 VA: 0x181F94BA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F94980 Offset: 0x1F92F80 VA: 0x181F94980
	public static byte[] SerializeToBytes(ParentInfo instance) { }

	// RVA: 0x1F948D0 Offset: 0x1F92ED0 VA: 0x181F948D0
	public static void SerializeLengthDelimited(Stream stream, ParentInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

