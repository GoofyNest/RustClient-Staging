public class TreeList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6497
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Tree> trees; // 0x18

	// Methods

	// RVA: 0x1EF3760 Offset: 0x1EF1D60 VA: 0x181EF3760
	public static void ResetToPool(TreeList instance) { }

	// RVA: 0x1EF35B0 Offset: 0x1EF1BB0 VA: 0x181EF35B0
	public void ResetToPool() { }

	// RVA: 0x1EF3330 Offset: 0x1EF1930 VA: 0x181EF3330 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF2480 Offset: 0x1EF0A80 VA: 0x181EF2480
	public void CopyTo(TreeList instance) { }

	// RVA: 0x1EF2620 Offset: 0x1EF0C20 VA: 0x181EF2620
	public TreeList Copy() { }

	// RVA: 0x1EF2FA0 Offset: 0x1EF15A0 VA: 0x181EF2FA0
	public static TreeList Deserialize(Stream stream) { }

	// RVA: 0x1EF2AF0 Offset: 0x1EF10F0 VA: 0x181EF2AF0
	public static TreeList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF2E10 Offset: 0x1EF1410 VA: 0x181EF2E10
	public static TreeList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF3210 Offset: 0x1EF1810 VA: 0x181EF3210
	public static TreeList Deserialize(byte[] buffer) { }

	// RVA: 0x1EF3570 Offset: 0x1EF1B70 VA: 0x181EF3570
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF3EA0 Offset: 0x1EF24A0 VA: 0x181EF3EA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF3EC0 Offset: 0x1EF24C0 VA: 0x181EF3EC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TreeList previous) { }

	// RVA: 0x1EF3590 Offset: 0x1EF1B90 VA: 0x181EF3590 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF2EA0 Offset: 0x1EF14A0 VA: 0x181EF2EA0
	public static TreeList Deserialize(byte[] buffer, TreeList instance, bool isDelta = False) { }

	// RVA: 0x1EF3020 Offset: 0x1EF1620 VA: 0x181EF3020
	public static TreeList Deserialize(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF2820 Offset: 0x1EF0E20 VA: 0x181EF2820
	public static TreeList DeserializeLengthDelimited(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF2B70 Offset: 0x1EF1170 VA: 0x181EF2B70
	public static TreeList DeserializeLength(Stream stream, int length, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF3910 Offset: 0x1EF1F10 VA: 0x181EF3910
	public static void SerializeDelta(Stream stream, TreeList instance, TreeList previous) { }

	// RVA: 0x1EF3CB0 Offset: 0x1EF22B0 VA: 0x181EF3CB0
	public static void Serialize(Stream stream, TreeList instance) { }

	// RVA: 0x1EF3E90 Offset: 0x1EF2490 VA: 0x181EF3E90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF3EA0 Offset: 0x1EF24A0 VA: 0x181EF3EA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF3BA0 Offset: 0x1EF21A0 VA: 0x181EF3BA0
	public static byte[] SerializeToBytes(TreeList instance) { }

	// RVA: 0x1EF3AF0 Offset: 0x1EF20F0 VA: 0x181EF3AF0
	public static void SerializeLengthDelimited(Stream stream, TreeList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

