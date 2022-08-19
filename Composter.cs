public class Composter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6377
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fertilizerProductionProgress; // 0x14

	// Methods

	// RVA: 0x20B0380 Offset: 0x20AE980 VA: 0x1820B0380
	public static void ResetToPool(Composter instance) { }

	// RVA: 0x20B0400 Offset: 0x20AEA00 VA: 0x1820B0400
	public void ResetToPool() { }

	// RVA: 0x20B0250 Offset: 0x20AE850 VA: 0x1820B0250 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(Composter instance) { }

	// RVA: 0x20AF8C0 Offset: 0x20ADEC0 VA: 0x1820AF8C0
	public Composter Copy() { }

	// RVA: 0x20AFF60 Offset: 0x20AE560 VA: 0x1820AFF60
	public static Composter Deserialize(Stream stream) { }

	// RVA: 0x20AFB50 Offset: 0x20AE150 VA: 0x1820AFB50
	public static Composter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AFBD0 Offset: 0x20AE1D0 VA: 0x1820AFBD0
	public static Composter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B0130 Offset: 0x20AE730 VA: 0x1820B0130
	public static Composter Deserialize(byte[] buffer) { }

	// RVA: 0x20B0340 Offset: 0x20AE940 VA: 0x1820B0340
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B0850 Offset: 0x20AEE50 VA: 0x1820B0850 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B0870 Offset: 0x20AEE70 VA: 0x1820B0870 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Composter previous) { }

	// RVA: 0x20B0360 Offset: 0x20AE960 VA: 0x1820B0360 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AFE60 Offset: 0x20AE460 VA: 0x1820AFE60
	public static Composter Deserialize(byte[] buffer, Composter instance, bool isDelta = False) { }

	// RVA: 0x20AFFE0 Offset: 0x20AE5E0 VA: 0x1820AFFE0
	public static Composter Deserialize(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20AF930 Offset: 0x20ADF30 VA: 0x1820AF930
	public static Composter DeserializeLengthDelimited(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20AFC60 Offset: 0x20AE260 VA: 0x1820AFC60
	public static Composter DeserializeLength(Stream stream, int length, Composter instance, bool isDelta) { }

	// RVA: 0x20B0480 Offset: 0x20AEA80 VA: 0x1820B0480
	public static void SerializeDelta(Stream stream, Composter instance, Composter previous) { }

	// RVA: 0x20B0760 Offset: 0x20AED60 VA: 0x1820B0760
	public static void Serialize(Stream stream, Composter instance) { }

	// RVA: 0x20B0840 Offset: 0x20AEE40 VA: 0x1820B0840
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B0850 Offset: 0x20AEE50 VA: 0x1820B0850
	public void ToProto(Stream stream) { }

	// RVA: 0x20B0650 Offset: 0x20AEC50 VA: 0x1820B0650
	public static byte[] SerializeToBytes(Composter instance) { }

	// RVA: 0x20B05A0 Offset: 0x20AEBA0 VA: 0x1820B05A0
	public static void SerializeLengthDelimited(Stream stream, Composter instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Composter : StorageContainer // TypeDefIndex: 8684
{	// Methods

	// RVA: 0x6D1CB0 Offset: 0x6D02B0 VA: 0x1806D1CB0
	public void .ctor() { }

}

