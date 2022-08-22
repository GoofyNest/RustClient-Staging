public class OwnerInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6334
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamid; // 0x18

	// Methods

	// RVA: 0x1F90030 Offset: 0x1F8E630 VA: 0x181F90030
	public static void ResetToPool(OwnerInfo instance) { }

	// RVA: 0x1F8FFB0 Offset: 0x1F8E5B0 VA: 0x181F8FFB0
	public void ResetToPool() { }

	// RVA: 0x1F8FE80 Offset: 0x1F8E480 VA: 0x181F8FE80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1CCB0 Offset: 0x1F1B2B0 VA: 0x181F1CCB0
	public void CopyTo(OwnerInfo instance) { }

	// RVA: 0x1F8F500 Offset: 0x1F8DB00 VA: 0x181F8F500
	public OwnerInfo Copy() { }

	// RVA: 0x1F8FCE0 Offset: 0x1F8E2E0 VA: 0x181F8FCE0
	public static OwnerInfo Deserialize(Stream stream) { }

	// RVA: 0x1F8F790 Offset: 0x1F8DD90 VA: 0x181F8F790
	public static OwnerInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8F810 Offset: 0x1F8DE10 VA: 0x181F8F810
	public static OwnerInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8FD60 Offset: 0x1F8E360 VA: 0x181F8FD60
	public static OwnerInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F8FF70 Offset: 0x1F8E570 VA: 0x181F8FF70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F90500 Offset: 0x1F8EB00 VA: 0x181F90500 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F905D0 Offset: 0x1F8EBD0 VA: 0x181F905D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, OwnerInfo previous) { }

	// RVA: 0x1F8FF90 Offset: 0x1F8E590 VA: 0x181F8FF90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8FAA0 Offset: 0x1F8E0A0 VA: 0x181F8FAA0
	public static OwnerInfo Deserialize(byte[] buffer, OwnerInfo instance, bool isDelta = False) { }

	// RVA: 0x1F8FBA0 Offset: 0x1F8E1A0 VA: 0x181F8FBA0
	public static OwnerInfo Deserialize(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8F570 Offset: 0x1F8DB70 VA: 0x181F8F570
	public static OwnerInfo DeserializeLengthDelimited(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8F8A0 Offset: 0x1F8DEA0 VA: 0x181F8F8A0
	public static OwnerInfo DeserializeLength(Stream stream, int length, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F900B0 Offset: 0x1F8E6B0 VA: 0x181F900B0
	public static void SerializeDelta(Stream stream, OwnerInfo instance, OwnerInfo previous) { }

	// RVA: 0x1F90420 Offset: 0x1F8EA20 VA: 0x181F90420
	public static void Serialize(Stream stream, OwnerInfo instance) { }

	// RVA: 0x1F904F0 Offset: 0x1F8EAF0 VA: 0x181F904F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F90500 Offset: 0x1F8EB00 VA: 0x181F90500
	public void ToProto(Stream stream) { }

	// RVA: 0x1F90270 Offset: 0x1F8E870 VA: 0x181F90270
	public static byte[] SerializeToBytes(OwnerInfo instance) { }

	// RVA: 0x1F901C0 Offset: 0x1F8E7C0 VA: 0x181F901C0
	public static void SerializeLengthDelimited(Stream stream, OwnerInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

