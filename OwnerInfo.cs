public class OwnerInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6334
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamid; // 0x18

	// Methods

	// RVA: 0x1F8FF30 Offset: 0x1F8E530 VA: 0x181F8FF30
	public static void ResetToPool(OwnerInfo instance) { }

	// RVA: 0x1F8FEB0 Offset: 0x1F8E4B0 VA: 0x181F8FEB0
	public void ResetToPool() { }

	// RVA: 0x1F8FD80 Offset: 0x1F8E380 VA: 0x181F8FD80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1CBB0 Offset: 0x1F1B1B0 VA: 0x181F1CBB0
	public void CopyTo(OwnerInfo instance) { }

	// RVA: 0x1F8F400 Offset: 0x1F8DA00 VA: 0x181F8F400
	public OwnerInfo Copy() { }

	// RVA: 0x1F8FBE0 Offset: 0x1F8E1E0 VA: 0x181F8FBE0
	public static OwnerInfo Deserialize(Stream stream) { }

	// RVA: 0x1F8F690 Offset: 0x1F8DC90 VA: 0x181F8F690
	public static OwnerInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8F710 Offset: 0x1F8DD10 VA: 0x181F8F710
	public static OwnerInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8FC60 Offset: 0x1F8E260 VA: 0x181F8FC60
	public static OwnerInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F8FE70 Offset: 0x1F8E470 VA: 0x181F8FE70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F90400 Offset: 0x1F8EA00 VA: 0x181F90400 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F904D0 Offset: 0x1F8EAD0 VA: 0x181F904D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, OwnerInfo previous) { }

	// RVA: 0x1F8FE90 Offset: 0x1F8E490 VA: 0x181F8FE90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8F9A0 Offset: 0x1F8DFA0 VA: 0x181F8F9A0
	public static OwnerInfo Deserialize(byte[] buffer, OwnerInfo instance, bool isDelta = False) { }

	// RVA: 0x1F8FAA0 Offset: 0x1F8E0A0 VA: 0x181F8FAA0
	public static OwnerInfo Deserialize(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8F470 Offset: 0x1F8DA70 VA: 0x181F8F470
	public static OwnerInfo DeserializeLengthDelimited(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8F7A0 Offset: 0x1F8DDA0 VA: 0x181F8F7A0
	public static OwnerInfo DeserializeLength(Stream stream, int length, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8FFB0 Offset: 0x1F8E5B0 VA: 0x181F8FFB0
	public static void SerializeDelta(Stream stream, OwnerInfo instance, OwnerInfo previous) { }

	// RVA: 0x1F90320 Offset: 0x1F8E920 VA: 0x181F90320
	public static void Serialize(Stream stream, OwnerInfo instance) { }

	// RVA: 0x1F903F0 Offset: 0x1F8E9F0 VA: 0x181F903F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F90400 Offset: 0x1F8EA00 VA: 0x181F90400
	public void ToProto(Stream stream) { }

	// RVA: 0x1F90170 Offset: 0x1F8E770 VA: 0x181F90170
	public static byte[] SerializeToBytes(OwnerInfo instance) { }

	// RVA: 0x1F900C0 Offset: 0x1F8E6C0 VA: 0x181F900C0
	public static void SerializeLengthDelimited(Stream stream, OwnerInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

