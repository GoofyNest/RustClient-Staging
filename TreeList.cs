public class TreeList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6497
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Tree> trees; // 0x18

	// Methods

	// RVA: 0x1EF3920 Offset: 0x1EF1F20 VA: 0x181EF3920
	public static void ResetToPool(TreeList instance) { }

	// RVA: 0x1EF3770 Offset: 0x1EF1D70 VA: 0x181EF3770
	public void ResetToPool() { }

	// RVA: 0x1EF34F0 Offset: 0x1EF1AF0 VA: 0x181EF34F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF2640 Offset: 0x1EF0C40 VA: 0x181EF2640
	public void CopyTo(TreeList instance) { }

	// RVA: 0x1EF27E0 Offset: 0x1EF0DE0 VA: 0x181EF27E0
	public TreeList Copy() { }

	// RVA: 0x1EF3160 Offset: 0x1EF1760 VA: 0x181EF3160
	public static TreeList Deserialize(Stream stream) { }

	// RVA: 0x1EF2CB0 Offset: 0x1EF12B0 VA: 0x181EF2CB0
	public static TreeList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF2FD0 Offset: 0x1EF15D0 VA: 0x181EF2FD0
	public static TreeList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF33D0 Offset: 0x1EF19D0 VA: 0x181EF33D0
	public static TreeList Deserialize(byte[] buffer) { }

	// RVA: 0x1EF3730 Offset: 0x1EF1D30 VA: 0x181EF3730
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF4060 Offset: 0x1EF2660 VA: 0x181EF4060 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF4080 Offset: 0x1EF2680 VA: 0x181EF4080 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TreeList previous) { }

	// RVA: 0x1EF3750 Offset: 0x1EF1D50 VA: 0x181EF3750 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF3060 Offset: 0x1EF1660 VA: 0x181EF3060
	public static TreeList Deserialize(byte[] buffer, TreeList instance, bool isDelta = False) { }

	// RVA: 0x1EF31E0 Offset: 0x1EF17E0 VA: 0x181EF31E0
	public static TreeList Deserialize(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF29E0 Offset: 0x1EF0FE0 VA: 0x181EF29E0
	public static TreeList DeserializeLengthDelimited(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF2D30 Offset: 0x1EF1330 VA: 0x181EF2D30
	public static TreeList DeserializeLength(Stream stream, int length, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF3AD0 Offset: 0x1EF20D0 VA: 0x181EF3AD0
	public static void SerializeDelta(Stream stream, TreeList instance, TreeList previous) { }

	// RVA: 0x1EF3E70 Offset: 0x1EF2470 VA: 0x181EF3E70
	public static void Serialize(Stream stream, TreeList instance) { }

	// RVA: 0x1EF4050 Offset: 0x1EF2650 VA: 0x181EF4050
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF4060 Offset: 0x1EF2660 VA: 0x181EF4060
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF3D60 Offset: 0x1EF2360 VA: 0x181EF3D60
	public static byte[] SerializeToBytes(TreeList instance) { }

	// RVA: 0x1EF3CB0 Offset: 0x1EF22B0 VA: 0x181EF3CB0
	public static void SerializeLengthDelimited(Stream stream, TreeList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

