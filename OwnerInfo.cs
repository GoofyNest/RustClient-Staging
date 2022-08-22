public class OwnerInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6334
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamid; // 0x18

	// Methods

	// RVA: 0x1F8FD70 Offset: 0x1F8E370 VA: 0x181F8FD70
	public static void ResetToPool(OwnerInfo instance) { }

	// RVA: 0x1F8FCF0 Offset: 0x1F8E2F0 VA: 0x181F8FCF0
	public void ResetToPool() { }

	// RVA: 0x1F8FBC0 Offset: 0x1F8E1C0 VA: 0x181F8FBC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1C9F0 Offset: 0x1F1AFF0 VA: 0x181F1C9F0
	public void CopyTo(OwnerInfo instance) { }

	// RVA: 0x1F8F240 Offset: 0x1F8D840 VA: 0x181F8F240
	public OwnerInfo Copy() { }

	// RVA: 0x1F8FA20 Offset: 0x1F8E020 VA: 0x181F8FA20
	public static OwnerInfo Deserialize(Stream stream) { }

	// RVA: 0x1F8F4D0 Offset: 0x1F8DAD0 VA: 0x181F8F4D0
	public static OwnerInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8F550 Offset: 0x1F8DB50 VA: 0x181F8F550
	public static OwnerInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8FAA0 Offset: 0x1F8E0A0 VA: 0x181F8FAA0
	public static OwnerInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F8FCB0 Offset: 0x1F8E2B0 VA: 0x181F8FCB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F90240 Offset: 0x1F8E840 VA: 0x181F90240 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F90310 Offset: 0x1F8E910 VA: 0x181F90310 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, OwnerInfo previous) { }

	// RVA: 0x1F8FCD0 Offset: 0x1F8E2D0 VA: 0x181F8FCD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8F7E0 Offset: 0x1F8DDE0 VA: 0x181F8F7E0
	public static OwnerInfo Deserialize(byte[] buffer, OwnerInfo instance, bool isDelta = False) { }

	// RVA: 0x1F8F8E0 Offset: 0x1F8DEE0 VA: 0x181F8F8E0
	public static OwnerInfo Deserialize(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8F2B0 Offset: 0x1F8D8B0 VA: 0x181F8F2B0
	public static OwnerInfo DeserializeLengthDelimited(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8F5E0 Offset: 0x1F8DBE0 VA: 0x181F8F5E0
	public static OwnerInfo DeserializeLength(Stream stream, int length, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8FDF0 Offset: 0x1F8E3F0 VA: 0x181F8FDF0
	public static void SerializeDelta(Stream stream, OwnerInfo instance, OwnerInfo previous) { }

	// RVA: 0x1F90160 Offset: 0x1F8E760 VA: 0x181F90160
	public static void Serialize(Stream stream, OwnerInfo instance) { }

	// RVA: 0x1F90230 Offset: 0x1F8E830 VA: 0x181F90230
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F90240 Offset: 0x1F8E840 VA: 0x181F90240
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8FFB0 Offset: 0x1F8E5B0 VA: 0x181F8FFB0
	public static byte[] SerializeToBytes(OwnerInfo instance) { }

	// RVA: 0x1F8FF00 Offset: 0x1F8E500 VA: 0x181F8FF00
	public static void SerializeLengthDelimited(Stream stream, OwnerInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

