public class PhoneDirectory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6502
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PhoneDirectory.DirectoryEntry> entries; // 0x18
	public bool atEnd; // 0x20

	// Methods

	// RVA: 0x1EA7C00 Offset: 0x1EA6200 VA: 0x181EA7C00
	public static void ResetToPool(PhoneDirectory instance) { }

	// RVA: 0x1EA7A40 Offset: 0x1EA6040 VA: 0x181EA7A40
	public void ResetToPool() { }

	// RVA: 0x1EA7980 Offset: 0x1EA5F80 VA: 0x181EA7980 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA6B80 Offset: 0x1EA5180 VA: 0x181EA6B80
	public void CopyTo(PhoneDirectory instance) { }

	// RVA: 0x1EA6D30 Offset: 0x1EA5330 VA: 0x181EA6D30
	public PhoneDirectory Copy() { }

	// RVA: 0x1EA7900 Offset: 0x1EA5F00 VA: 0x181EA7900
	public static PhoneDirectory Deserialize(Stream stream) { }

	// RVA: 0x1EA70C0 Offset: 0x1EA56C0 VA: 0x181EA70C0
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA7420 Offset: 0x1EA5A20 VA: 0x181EA7420
	public static PhoneDirectory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA74B0 Offset: 0x1EA5AB0 VA: 0x181EA74B0
	public static PhoneDirectory Deserialize(byte[] buffer) { }

	// RVA: 0x1EA7A00 Offset: 0x1EA6000 VA: 0x181EA7A00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA83F0 Offset: 0x1EA69F0 VA: 0x181EA83F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA8410 Offset: 0x1EA6A10 VA: 0x181EA8410 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory previous) { }

	// RVA: 0x1EA7A20 Offset: 0x1EA6020 VA: 0x181EA7A20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA7800 Offset: 0x1EA5E00 VA: 0x181EA7800
	public static PhoneDirectory Deserialize(byte[] buffer, PhoneDirectory instance, bool isDelta = False) { }

	// RVA: 0x1EA75D0 Offset: 0x1EA5BD0 VA: 0x181EA75D0
	public static PhoneDirectory Deserialize(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA6DB0 Offset: 0x1EA53B0 VA: 0x181EA6DB0
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA7140 Offset: 0x1EA5740 VA: 0x181EA7140
	public static PhoneDirectory DeserializeLength(Stream stream, int length, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA7DC0 Offset: 0x1EA63C0 VA: 0x181EA7DC0
	public static void SerializeDelta(Stream stream, PhoneDirectory instance, PhoneDirectory previous) { }

	// RVA: 0x1EA81B0 Offset: 0x1EA67B0 VA: 0x181EA81B0
	public static void Serialize(Stream stream, PhoneDirectory instance) { }

	// RVA: 0x1EA83E0 Offset: 0x1EA69E0 VA: 0x181EA83E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA83F0 Offset: 0x1EA69F0 VA: 0x181EA83F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA80A0 Offset: 0x1EA66A0 VA: 0x181EA80A0
	public static byte[] SerializeToBytes(PhoneDirectory instance) { }

	// RVA: 0x1EA7FF0 Offset: 0x1EA65F0 VA: 0x181EA7FF0
	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PhoneDirectory.DirectoryEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6503
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int phoneNumber; // 0x14
	public string phoneName; // 0x18

	// Methods

	// RVA: 0x1EA39A0 Offset: 0x1EA1FA0 VA: 0x181EA39A0
	public static void ResetToPool(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA3A40 Offset: 0x1EA2040 VA: 0x181EA3A40
	public void ResetToPool() { }

	// RVA: 0x1EA38E0 Offset: 0x1EA1EE0 VA: 0x181EA38E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA2BA0 Offset: 0x1EA11A0 VA: 0x181EA2BA0
	public void CopyTo(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA2BD0 Offset: 0x1EA11D0 VA: 0x181EA2BD0
	public PhoneDirectory.DirectoryEntry Copy() { }

	// RVA: 0x1EA3310 Offset: 0x1EA1910 VA: 0x181EA3310
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream) { }

	// RVA: 0x1EA2C60 Offset: 0x1EA1260 VA: 0x181EA2C60
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA3180 Offset: 0x1EA1780 VA: 0x181EA3180
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA34E0 Offset: 0x1EA1AE0 VA: 0x181EA34E0
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1EA3960 Offset: 0x1EA1F60 VA: 0x181EA3960
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA3FF0 Offset: 0x1EA25F0 VA: 0x181EA3FF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA4010 Offset: 0x1EA2610 VA: 0x181EA4010 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1EA3980 Offset: 0x1EA1F80 VA: 0x181EA3980 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA3210 Offset: 0x1EA1810 VA: 0x181EA3210
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer, PhoneDirectory.DirectoryEntry instance, bool isDelta = False) { }

	// RVA: 0x1EA3750 Offset: 0x1EA1D50 VA: 0x181EA3750
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA2CE0 Offset: 0x1EA12E0 VA: 0x181EA2CE0
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA2F40 Offset: 0x1EA1540 VA: 0x181EA2F40
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA3AE0 Offset: 0x1EA20E0 VA: 0x181EA3AE0
	public static void SerializeDelta(Stream stream, PhoneDirectory.DirectoryEntry instance, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1EA3E60 Offset: 0x1EA2460 VA: 0x181EA3E60
	public static void Serialize(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA3FE0 Offset: 0x1EA25E0 VA: 0x181EA3FE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA3FF0 Offset: 0x1EA25F0 VA: 0x181EA3FF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA3D50 Offset: 0x1EA2350 VA: 0x181EA3D50
	public static byte[] SerializeToBytes(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA3CA0 Offset: 0x1EA22A0 VA: 0x181EA3CA0
	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

