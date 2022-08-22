public class Composter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6377
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fertilizerProductionProgress; // 0x14

	// Methods

	// RVA: 0x20B0480 Offset: 0x20AEA80 VA: 0x1820B0480
	public static void ResetToPool(Composter instance) { }

	// RVA: 0x20B0500 Offset: 0x20AEB00 VA: 0x1820B0500
	public void ResetToPool() { }

	// RVA: 0x20B0350 Offset: 0x20AE950 VA: 0x1820B0350 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(Composter instance) { }

	// RVA: 0x20AF9C0 Offset: 0x20ADFC0 VA: 0x1820AF9C0
	public Composter Copy() { }

	// RVA: 0x20B0060 Offset: 0x20AE660 VA: 0x1820B0060
	public static Composter Deserialize(Stream stream) { }

	// RVA: 0x20AFC50 Offset: 0x20AE250 VA: 0x1820AFC50
	public static Composter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AFCD0 Offset: 0x20AE2D0 VA: 0x1820AFCD0
	public static Composter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B0230 Offset: 0x20AE830 VA: 0x1820B0230
	public static Composter Deserialize(byte[] buffer) { }

	// RVA: 0x20B0440 Offset: 0x20AEA40 VA: 0x1820B0440
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B0950 Offset: 0x20AEF50 VA: 0x1820B0950 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B0970 Offset: 0x20AEF70 VA: 0x1820B0970 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Composter previous) { }

	// RVA: 0x20B0460 Offset: 0x20AEA60 VA: 0x1820B0460 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AFF60 Offset: 0x20AE560 VA: 0x1820AFF60
	public static Composter Deserialize(byte[] buffer, Composter instance, bool isDelta = False) { }

	// RVA: 0x20B00E0 Offset: 0x20AE6E0 VA: 0x1820B00E0
	public static Composter Deserialize(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20AFA30 Offset: 0x20AE030 VA: 0x1820AFA30
	public static Composter DeserializeLengthDelimited(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20AFD60 Offset: 0x20AE360 VA: 0x1820AFD60
	public static Composter DeserializeLength(Stream stream, int length, Composter instance, bool isDelta) { }

	// RVA: 0x20B0580 Offset: 0x20AEB80 VA: 0x1820B0580
	public static void SerializeDelta(Stream stream, Composter instance, Composter previous) { }

	// RVA: 0x20B0860 Offset: 0x20AEE60 VA: 0x1820B0860
	public static void Serialize(Stream stream, Composter instance) { }

	// RVA: 0x20B0940 Offset: 0x20AEF40 VA: 0x1820B0940
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B0950 Offset: 0x20AEF50 VA: 0x1820B0950
	public void ToProto(Stream stream) { }

	// RVA: 0x20B0750 Offset: 0x20AED50 VA: 0x1820B0750
	public static byte[] SerializeToBytes(Composter instance) { }

	// RVA: 0x20B06A0 Offset: 0x20AECA0 VA: 0x1820B06A0
	public static void SerializeLengthDelimited(Stream stream, Composter instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class Composter : StorageContainer // TypeDefIndex: 8684
{	// Methods

	// RVA: 0x6D1DC0 Offset: 0x6D03C0 VA: 0x1806D1DC0
	public void .ctor() { }

}

