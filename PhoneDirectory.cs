public class PhoneDirectory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6502
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PhoneDirectory.DirectoryEntry> entries; // 0x18
	public bool atEnd; // 0x20

	// Methods

	// RVA: 0x1EA7DC0 Offset: 0x1EA63C0 VA: 0x181EA7DC0
	public static void ResetToPool(PhoneDirectory instance) { }

	// RVA: 0x1EA7C00 Offset: 0x1EA6200 VA: 0x181EA7C00
	public void ResetToPool() { }

	// RVA: 0x1EA7B40 Offset: 0x1EA6140 VA: 0x181EA7B40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA6D40 Offset: 0x1EA5340 VA: 0x181EA6D40
	public void CopyTo(PhoneDirectory instance) { }

	// RVA: 0x1EA6EF0 Offset: 0x1EA54F0 VA: 0x181EA6EF0
	public PhoneDirectory Copy() { }

	// RVA: 0x1EA7AC0 Offset: 0x1EA60C0 VA: 0x181EA7AC0
	public static PhoneDirectory Deserialize(Stream stream) { }

	// RVA: 0x1EA7280 Offset: 0x1EA5880 VA: 0x181EA7280
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA75E0 Offset: 0x1EA5BE0 VA: 0x181EA75E0
	public static PhoneDirectory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA7670 Offset: 0x1EA5C70 VA: 0x181EA7670
	public static PhoneDirectory Deserialize(byte[] buffer) { }

	// RVA: 0x1EA7BC0 Offset: 0x1EA61C0 VA: 0x181EA7BC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA85B0 Offset: 0x1EA6BB0 VA: 0x181EA85B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA85D0 Offset: 0x1EA6BD0 VA: 0x181EA85D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory previous) { }

	// RVA: 0x1EA7BE0 Offset: 0x1EA61E0 VA: 0x181EA7BE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA79C0 Offset: 0x1EA5FC0 VA: 0x181EA79C0
	public static PhoneDirectory Deserialize(byte[] buffer, PhoneDirectory instance, bool isDelta = False) { }

	// RVA: 0x1EA7790 Offset: 0x1EA5D90 VA: 0x181EA7790
	public static PhoneDirectory Deserialize(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA6F70 Offset: 0x1EA5570 VA: 0x181EA6F70
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA7300 Offset: 0x1EA5900 VA: 0x181EA7300
	public static PhoneDirectory DeserializeLength(Stream stream, int length, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA7F80 Offset: 0x1EA6580 VA: 0x181EA7F80
	public static void SerializeDelta(Stream stream, PhoneDirectory instance, PhoneDirectory previous) { }

	// RVA: 0x1EA8370 Offset: 0x1EA6970 VA: 0x181EA8370
	public static void Serialize(Stream stream, PhoneDirectory instance) { }

	// RVA: 0x1EA85A0 Offset: 0x1EA6BA0 VA: 0x181EA85A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA85B0 Offset: 0x1EA6BB0 VA: 0x181EA85B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA8260 Offset: 0x1EA6860 VA: 0x181EA8260
	public static byte[] SerializeToBytes(PhoneDirectory instance) { }

	// RVA: 0x1EA81B0 Offset: 0x1EA67B0 VA: 0x181EA81B0
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

	// RVA: 0x1EA3B60 Offset: 0x1EA2160 VA: 0x181EA3B60
	public static void ResetToPool(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA3C00 Offset: 0x1EA2200 VA: 0x181EA3C00
	public void ResetToPool() { }

	// RVA: 0x1EA3AA0 Offset: 0x1EA20A0 VA: 0x181EA3AA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA2D60 Offset: 0x1EA1360 VA: 0x181EA2D60
	public void CopyTo(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA2D90 Offset: 0x1EA1390 VA: 0x181EA2D90
	public PhoneDirectory.DirectoryEntry Copy() { }

	// RVA: 0x1EA34D0 Offset: 0x1EA1AD0 VA: 0x181EA34D0
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream) { }

	// RVA: 0x1EA2E20 Offset: 0x1EA1420 VA: 0x181EA2E20
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA3340 Offset: 0x1EA1940 VA: 0x181EA3340
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA36A0 Offset: 0x1EA1CA0 VA: 0x181EA36A0
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1EA3B20 Offset: 0x1EA2120 VA: 0x181EA3B20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA41B0 Offset: 0x1EA27B0 VA: 0x181EA41B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA41D0 Offset: 0x1EA27D0 VA: 0x181EA41D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1EA3B40 Offset: 0x1EA2140 VA: 0x181EA3B40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA33D0 Offset: 0x1EA19D0 VA: 0x181EA33D0
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer, PhoneDirectory.DirectoryEntry instance, bool isDelta = False) { }

	// RVA: 0x1EA3910 Offset: 0x1EA1F10 VA: 0x181EA3910
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA2EA0 Offset: 0x1EA14A0 VA: 0x181EA2EA0
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA3100 Offset: 0x1EA1700 VA: 0x181EA3100
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1EA3CA0 Offset: 0x1EA22A0 VA: 0x181EA3CA0
	public static void SerializeDelta(Stream stream, PhoneDirectory.DirectoryEntry instance, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1EA4020 Offset: 0x1EA2620 VA: 0x181EA4020
	public static void Serialize(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA41A0 Offset: 0x1EA27A0 VA: 0x181EA41A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA41B0 Offset: 0x1EA27B0 VA: 0x181EA41B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA3F10 Offset: 0x1EA2510 VA: 0x181EA3F10
	public static byte[] SerializeToBytes(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1EA3E60 Offset: 0x1EA2460 VA: 0x181EA3E60
	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

