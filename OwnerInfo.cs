public class OwnerInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6334
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamid; // 0x18

	// Methods

	// RVA: 0x1F90850 Offset: 0x1F8EE50 VA: 0x181F90850
	public static void ResetToPool(OwnerInfo instance) { }

	// RVA: 0x1F907D0 Offset: 0x1F8EDD0 VA: 0x181F907D0
	public void ResetToPool() { }

	// RVA: 0x1F906A0 Offset: 0x1F8ECA0 VA: 0x181F906A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1D4D0 Offset: 0x1F1BAD0 VA: 0x181F1D4D0
	public void CopyTo(OwnerInfo instance) { }

	// RVA: 0x1F8FD20 Offset: 0x1F8E320 VA: 0x181F8FD20
	public OwnerInfo Copy() { }

	// RVA: 0x1F90500 Offset: 0x1F8EB00 VA: 0x181F90500
	public static OwnerInfo Deserialize(Stream stream) { }

	// RVA: 0x1F8FFB0 Offset: 0x1F8E5B0 VA: 0x181F8FFB0
	public static OwnerInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F90030 Offset: 0x1F8E630 VA: 0x181F90030
	public static OwnerInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F90580 Offset: 0x1F8EB80 VA: 0x181F90580
	public static OwnerInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F90790 Offset: 0x1F8ED90 VA: 0x181F90790
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F90D20 Offset: 0x1F8F320 VA: 0x181F90D20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F90DF0 Offset: 0x1F8F3F0 VA: 0x181F90DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, OwnerInfo previous) { }

	// RVA: 0x1F907B0 Offset: 0x1F8EDB0 VA: 0x181F907B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F902C0 Offset: 0x1F8E8C0 VA: 0x181F902C0
	public static OwnerInfo Deserialize(byte[] buffer, OwnerInfo instance, bool isDelta = False) { }

	// RVA: 0x1F903C0 Offset: 0x1F8E9C0 VA: 0x181F903C0
	public static OwnerInfo Deserialize(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8FD90 Offset: 0x1F8E390 VA: 0x181F8FD90
	public static OwnerInfo DeserializeLengthDelimited(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F900C0 Offset: 0x1F8E6C0 VA: 0x181F900C0
	public static OwnerInfo DeserializeLength(Stream stream, int length, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F908D0 Offset: 0x1F8EED0 VA: 0x181F908D0
	public static void SerializeDelta(Stream stream, OwnerInfo instance, OwnerInfo previous) { }

	// RVA: 0x1F90C40 Offset: 0x1F8F240 VA: 0x181F90C40
	public static void Serialize(Stream stream, OwnerInfo instance) { }

	// RVA: 0x1F90D10 Offset: 0x1F8F310 VA: 0x181F90D10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F90D20 Offset: 0x1F8F320 VA: 0x181F90D20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F90A90 Offset: 0x1F8F090 VA: 0x181F90A90
	public static byte[] SerializeToBytes(OwnerInfo instance) { }

	// RVA: 0x1F909E0 Offset: 0x1F8EFE0 VA: 0x181F909E0
	public static void SerializeLengthDelimited(Stream stream, OwnerInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

