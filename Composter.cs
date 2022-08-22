public class Composter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6377
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fertilizerProductionProgress; // 0x14

	// Methods

	// RVA: 0x20B01C0 Offset: 0x20AE7C0 VA: 0x1820B01C0
	public static void ResetToPool(Composter instance) { }

	// RVA: 0x20B0240 Offset: 0x20AE840 VA: 0x1820B0240
	public void ResetToPool() { }

	// RVA: 0x20B0090 Offset: 0x20AE690 VA: 0x1820B0090 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(Composter instance) { }

	// RVA: 0x20AF700 Offset: 0x20ADD00 VA: 0x1820AF700
	public Composter Copy() { }

	// RVA: 0x20AFDA0 Offset: 0x20AE3A0 VA: 0x1820AFDA0
	public static Composter Deserialize(Stream stream) { }

	// RVA: 0x20AF990 Offset: 0x20ADF90 VA: 0x1820AF990
	public static Composter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AFA10 Offset: 0x20AE010 VA: 0x1820AFA10
	public static Composter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AFF70 Offset: 0x20AE570 VA: 0x1820AFF70
	public static Composter Deserialize(byte[] buffer) { }

	// RVA: 0x20B0180 Offset: 0x20AE780 VA: 0x1820B0180
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B0690 Offset: 0x20AEC90 VA: 0x1820B0690 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B06B0 Offset: 0x20AECB0 VA: 0x1820B06B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Composter previous) { }

	// RVA: 0x20B01A0 Offset: 0x20AE7A0 VA: 0x1820B01A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AFCA0 Offset: 0x20AE2A0 VA: 0x1820AFCA0
	public static Composter Deserialize(byte[] buffer, Composter instance, bool isDelta = False) { }

	// RVA: 0x20AFE20 Offset: 0x20AE420 VA: 0x1820AFE20
	public static Composter Deserialize(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20AF770 Offset: 0x20ADD70 VA: 0x1820AF770
	public static Composter DeserializeLengthDelimited(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20AFAA0 Offset: 0x20AE0A0 VA: 0x1820AFAA0
	public static Composter DeserializeLength(Stream stream, int length, Composter instance, bool isDelta) { }

	// RVA: 0x20B02C0 Offset: 0x20AE8C0 VA: 0x1820B02C0
	public static void SerializeDelta(Stream stream, Composter instance, Composter previous) { }

	// RVA: 0x20B05A0 Offset: 0x20AEBA0 VA: 0x1820B05A0
	public static void Serialize(Stream stream, Composter instance) { }

	// RVA: 0x20B0680 Offset: 0x20AEC80 VA: 0x1820B0680
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B0690 Offset: 0x20AEC90 VA: 0x1820B0690
	public void ToProto(Stream stream) { }

	// RVA: 0x20B0490 Offset: 0x20AEA90 VA: 0x1820B0490
	public static byte[] SerializeToBytes(Composter instance) { }

	// RVA: 0x20B03E0 Offset: 0x20AE9E0 VA: 0x1820B03E0
	public static void SerializeLengthDelimited(Stream stream, Composter instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Composter : StorageContainer // TypeDefIndex: 8684
{	// Methods

	// RVA: 0x6D1CB0 Offset: 0x6D02B0 VA: 0x1806D1CB0
	public void .ctor() { }

}

