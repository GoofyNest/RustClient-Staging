public class PhoneDirectory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6502
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PhoneDirectory.DirectoryEntry> entries; // 0x18
	public bool atEnd; // 0x20

	// Methods

	// RVA: 0x1EA7EC0 Offset: 0x1EA64C0 VA: 0x181EA7EC0
	public static void ResetToPool(PhoneDirectory instance) { }

	// RVA: 0x1EA7D00 Offset: 0x1EA6300 VA: 0x181EA7D00
	public void ResetToPool() { }

	// RVA: 0x1EA7C40 Offset: 0x1EA6240 VA: 0x181EA7C40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA6E40 Offset: 0x1EA5440 VA: 0x181EA6E40
	public void CopyTo(PhoneDirectory instance) { }

	// RVA: 0x1EA6FF0 Offset: 0x1EA55F0 VA: 0x181EA6FF0
	public PhoneDirectory Copy() { }

	// RVA: 0x1EA7BC0 Offset: 0x1EA61C0 VA: 0x181EA7BC0
	public static PhoneDirectory Deserialize(Stream stream) { }

	// RVA: 0x1EA7380 Offset: 0x1EA5980 VA: 0x181EA7380
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA76E0 Offset: 0x1EA5CE0 VA: 0x181EA76E0
	public static PhoneDirectory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA7770 Offset: 0x1EA5D70 VA: 0x181EA7770
	public static PhoneDirectory Deserialize(byte[] buffer) { }

	// RVA: 0x1EA7CC0 Offset: 0x1EA62C0 VA: 0x181EA7CC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA86B0 Offset: 0x1EA6CB0 VA: 0x181EA86B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA86D0 Offset: 0x1EA6CD0 VA: 0x181EA86D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory previous) { }

	// RVA: 0x1EA7CE0 Offset: 0x1EA62E0 VA: 0x181EA7CE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA7AC0 Offset: 0x1EA60C0 VA: 0x181EA7AC0
	public static PhoneDirectory Deserialize(byte[] buffer, PhoneDirectory instance, bool isDelta = False) { }

	// RVA: 0x1EA7890 Offset: 0x1EA5E90 VA: 0x181EA7890
	public static PhoneDirectory Deserialize(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA7070 Offset: 0x1EA5670 VA: 0x181EA7070
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA7400 Offset: 0x1EA5A00 VA: 0x181EA7400
	public static PhoneDirectory DeserializeLength(Stream stream, int length, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA8080 Offset: 0x1EA6680 VA: 0x181EA8080
	public static void SerializeDelta(Stream stream, PhoneDirectory instance, PhoneDirectory previous) { }

	// RVA: 0x1EA8470 Offset: 0x1EA6A70 VA: 0x181EA8470
	public static void Serialize(Stream stream, PhoneDirectory instance) { }

	// RVA: 0x1EA86A0 Offset: 0x1EA6CA0 VA: 0x181EA86A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA86B0 Offset: 0x1EA6CB0 VA: 0x181EA86B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA8360 Offset: 0x1EA6960 VA: 0x181EA8360
	public static byte[] SerializeToBytes(PhoneDirectory instance) { }

	// RVA: 0x1EA82B0 Offset: 0x1EA68B0 VA: 0x181EA82B0
	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PhoneDirectory.DirectoryEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6503
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int phoneNumber; // 0x14
	public string phoneName; // 0x18

	// Methods

	// RVA: 0x1EA3C60 Offset: 0x1EA2260 VA: 0x181EA3C60
	public static void ResetToPool(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA3D00 Offset: 0x1EA2300 VA: 0x181EA3D00
	public void ResetToPool() { }

	// RVA: 0x1EA3BA0 Offset: 0x1EA21A0 VA: 0x181EA3BA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA2E60 Offset: 0x1EA1460 VA: 0x181EA2E60
	public void CopyTo(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA2E90 Offset: 0x1EA1490 VA: 0x181EA2E90
	public PhoneDirectory.DirectoryEntry Copy() { }

	// RVA: 0x1EA35D0 Offset: 0x1EA1BD0 VA: 0x181EA35D0
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream) { }

	// RVA: 0x1EA2F20 Offset: 0x1EA1520 VA: 0x181EA2F20
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA3440 Offset: 0x1EA1A40 VA: 0x181EA3440
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA37A0 Offset: 0x1EA1DA0 VA: 0x181EA37A0
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1EA3C20 Offset: 0x1EA2220 VA: 0x181EA3C20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA42B0 Offset: 0x1EA28B0 VA: 0x181EA42B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA42D0 Offset: 0x1EA28D0 VA: 0x181EA42D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1EA3C40 Offset: 0x1EA2240 VA: 0x181EA3C40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA34D0 Offset: 0x1EA1AD0 VA: 0x181EA34D0
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer, PhoneDirectory.DirectoryEntry instance, bool isDelta = False) { }

	// RVA: 0x1EA3A10 Offset: 0x1EA2010 VA: 0x181EA3A10
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA2FA0 Offset: 0x1EA15A0 VA: 0x181EA2FA0
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA3200 Offset: 0x1EA1800 VA: 0x181EA3200
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA3DA0 Offset: 0x1EA23A0 VA: 0x181EA3DA0
	public static void SerializeDelta(Stream stream, PhoneDirectory.DirectoryEntry instance, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1EA4120 Offset: 0x1EA2720 VA: 0x181EA4120
	public static void Serialize(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA42A0 Offset: 0x1EA28A0 VA: 0x181EA42A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA42B0 Offset: 0x1EA28B0 VA: 0x181EA42B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA4010 Offset: 0x1EA2610 VA: 0x181EA4010
	public static byte[] SerializeToBytes(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA3F60 Offset: 0x1EA2560 VA: 0x181EA3F60
	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

