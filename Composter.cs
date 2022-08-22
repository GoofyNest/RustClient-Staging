public class Composter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6377
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fertilizerProductionProgress; // 0x14

	// Methods

	// RVA: 0x20B0CA0 Offset: 0x20AF2A0 VA: 0x1820B0CA0
	public static void ResetToPool(Composter instance) { }

	// RVA: 0x20B0D20 Offset: 0x20AF320 VA: 0x1820B0D20
	public void ResetToPool() { }

	// RVA: 0x20B0B70 Offset: 0x20AF170 VA: 0x1820B0B70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(Composter instance) { }

	// RVA: 0x20B01E0 Offset: 0x20AE7E0 VA: 0x1820B01E0
	public Composter Copy() { }

	// RVA: 0x20B0880 Offset: 0x20AEE80 VA: 0x1820B0880
	public static Composter Deserialize(Stream stream) { }

	// RVA: 0x20B0470 Offset: 0x20AEA70 VA: 0x1820B0470
	public static Composter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B04F0 Offset: 0x20AEAF0 VA: 0x1820B04F0
	public static Composter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B0A50 Offset: 0x20AF050 VA: 0x1820B0A50
	public static Composter Deserialize(byte[] buffer) { }

	// RVA: 0x20B0C60 Offset: 0x20AF260 VA: 0x1820B0C60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B1170 Offset: 0x20AF770 VA: 0x1820B1170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B1190 Offset: 0x20AF790 VA: 0x1820B1190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Composter previous) { }

	// RVA: 0x20B0C80 Offset: 0x20AF280 VA: 0x1820B0C80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B0780 Offset: 0x20AED80 VA: 0x1820B0780
	public static Composter Deserialize(byte[] buffer, Composter instance, bool isDelta = False) { }

	// RVA: 0x20B0900 Offset: 0x20AEF00 VA: 0x1820B0900
	public static Composter Deserialize(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20B0250 Offset: 0x20AE850 VA: 0x1820B0250
	public static Composter DeserializeLengthDelimited(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20B0580 Offset: 0x20AEB80 VA: 0x1820B0580
	public static Composter DeserializeLength(Stream stream, int length, Composter instance, bool isDelta) { }

	// RVA: 0x20B0DA0 Offset: 0x20AF3A0 VA: 0x1820B0DA0
	public static void SerializeDelta(Stream stream, Composter instance, Composter previous) { }

	// RVA: 0x20B1080 Offset: 0x20AF680 VA: 0x1820B1080
	public static void Serialize(Stream stream, Composter instance) { }

	// RVA: 0x20B1160 Offset: 0x20AF760 VA: 0x1820B1160
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B1170 Offset: 0x20AF770 VA: 0x1820B1170
	public void ToProto(Stream stream) { }

	// RVA: 0x20B0F70 Offset: 0x20AF570 VA: 0x1820B0F70
	public static byte[] SerializeToBytes(Composter instance) { }

	// RVA: 0x20B0EC0 Offset: 0x20AF4C0 VA: 0x1820B0EC0
	public static void SerializeLengthDelimited(Stream stream, Composter instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Composter : StorageContainer // TypeDefIndex: 8684
{	// Methods

	// RVA: 0x6D1D50 Offset: 0x6D0350 VA: 0x1806D1D50
	public void .ctor() { }

}

