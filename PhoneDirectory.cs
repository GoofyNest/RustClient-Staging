public class PhoneDirectory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6502
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PhoneDirectory.DirectoryEntry> entries; // 0x18
	public bool atEnd; // 0x20

	// Methods

	// RVA: 0x1EA86E0 Offset: 0x1EA6CE0 VA: 0x181EA86E0
	public static void ResetToPool(PhoneDirectory instance) { }

	// RVA: 0x1EA8520 Offset: 0x1EA6B20 VA: 0x181EA8520
	public void ResetToPool() { }

	// RVA: 0x1EA8460 Offset: 0x1EA6A60 VA: 0x181EA8460 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA7660 Offset: 0x1EA5C60 VA: 0x181EA7660
	public void CopyTo(PhoneDirectory instance) { }

	// RVA: 0x1EA7810 Offset: 0x1EA5E10 VA: 0x181EA7810
	public PhoneDirectory Copy() { }

	// RVA: 0x1EA83E0 Offset: 0x1EA69E0 VA: 0x181EA83E0
	public static PhoneDirectory Deserialize(Stream stream) { }

	// RVA: 0x1EA7BA0 Offset: 0x1EA61A0 VA: 0x181EA7BA0
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA7F00 Offset: 0x1EA6500 VA: 0x181EA7F00
	public static PhoneDirectory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA7F90 Offset: 0x1EA6590 VA: 0x181EA7F90
	public static PhoneDirectory Deserialize(byte[] buffer) { }

	// RVA: 0x1EA84E0 Offset: 0x1EA6AE0 VA: 0x181EA84E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA8ED0 Offset: 0x1EA74D0 VA: 0x181EA8ED0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA8EF0 Offset: 0x1EA74F0 VA: 0x181EA8EF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory previous) { }

	// RVA: 0x1EA8500 Offset: 0x1EA6B00 VA: 0x181EA8500 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA82E0 Offset: 0x1EA68E0 VA: 0x181EA82E0
	public static PhoneDirectory Deserialize(byte[] buffer, PhoneDirectory instance, bool isDelta = False) { }

	// RVA: 0x1EA80B0 Offset: 0x1EA66B0 VA: 0x181EA80B0
	public static PhoneDirectory Deserialize(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA7890 Offset: 0x1EA5E90 VA: 0x181EA7890
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA7C20 Offset: 0x1EA6220 VA: 0x181EA7C20
	public static PhoneDirectory DeserializeLength(Stream stream, int length, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA88A0 Offset: 0x1EA6EA0 VA: 0x181EA88A0
	public static void SerializeDelta(Stream stream, PhoneDirectory instance, PhoneDirectory previous) { }

	// RVA: 0x1EA8C90 Offset: 0x1EA7290 VA: 0x181EA8C90
	public static void Serialize(Stream stream, PhoneDirectory instance) { }

	// RVA: 0x1EA8EC0 Offset: 0x1EA74C0 VA: 0x181EA8EC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA8ED0 Offset: 0x1EA74D0 VA: 0x181EA8ED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA8B80 Offset: 0x1EA7180 VA: 0x181EA8B80
	public static byte[] SerializeToBytes(PhoneDirectory instance) { }

	// RVA: 0x1EA8AD0 Offset: 0x1EA70D0 VA: 0x181EA8AD0
	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PhoneDirectory.DirectoryEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6503
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int phoneNumber; // 0x14
	public string phoneName; // 0x18

	// Methods

	// RVA: 0x1EA4480 Offset: 0x1EA2A80 VA: 0x181EA4480
	public static void ResetToPool(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA4520 Offset: 0x1EA2B20 VA: 0x181EA4520
	public void ResetToPool() { }

	// RVA: 0x1EA43C0 Offset: 0x1EA29C0 VA: 0x181EA43C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA3680 Offset: 0x1EA1C80 VA: 0x181EA3680
	public void CopyTo(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA36B0 Offset: 0x1EA1CB0 VA: 0x181EA36B0
	public PhoneDirectory.DirectoryEntry Copy() { }

	// RVA: 0x1EA3DF0 Offset: 0x1EA23F0 VA: 0x181EA3DF0
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream) { }

	// RVA: 0x1EA3740 Offset: 0x1EA1D40 VA: 0x181EA3740
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA3C60 Offset: 0x1EA2260 VA: 0x181EA3C60
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA3FC0 Offset: 0x1EA25C0 VA: 0x181EA3FC0
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1EA4440 Offset: 0x1EA2A40 VA: 0x181EA4440
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA4AD0 Offset: 0x1EA30D0 VA: 0x181EA4AD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA4AF0 Offset: 0x1EA30F0 VA: 0x181EA4AF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1EA4460 Offset: 0x1EA2A60 VA: 0x181EA4460 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA3CF0 Offset: 0x1EA22F0 VA: 0x181EA3CF0
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer, PhoneDirectory.DirectoryEntry instance, bool isDelta = False) { }

	// RVA: 0x1EA4230 Offset: 0x1EA2830 VA: 0x181EA4230
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA37C0 Offset: 0x1EA1DC0 VA: 0x181EA37C0
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA3A20 Offset: 0x1EA2020 VA: 0x181EA3A20
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA45C0 Offset: 0x1EA2BC0 VA: 0x181EA45C0
	public static void SerializeDelta(Stream stream, PhoneDirectory.DirectoryEntry instance, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1EA4940 Offset: 0x1EA2F40 VA: 0x181EA4940
	public static void Serialize(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA4AC0 Offset: 0x1EA30C0 VA: 0x181EA4AC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA4AD0 Offset: 0x1EA30D0 VA: 0x181EA4AD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA4830 Offset: 0x1EA2E30 VA: 0x181EA4830
	public static byte[] SerializeToBytes(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA4780 Offset: 0x1EA2D80 VA: 0x181EA4780
	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

