public class TreeList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6497
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Tree> trees; // 0x18

	// Methods

	// RVA: 0x1EF3A20 Offset: 0x1EF2020 VA: 0x181EF3A20
	public static void ResetToPool(TreeList instance) { }

	// RVA: 0x1EF3870 Offset: 0x1EF1E70 VA: 0x181EF3870
	public void ResetToPool() { }

	// RVA: 0x1EF35F0 Offset: 0x1EF1BF0 VA: 0x181EF35F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF2740 Offset: 0x1EF0D40 VA: 0x181EF2740
	public void CopyTo(TreeList instance) { }

	// RVA: 0x1EF28E0 Offset: 0x1EF0EE0 VA: 0x181EF28E0
	public TreeList Copy() { }

	// RVA: 0x1EF3260 Offset: 0x1EF1860 VA: 0x181EF3260
	public static TreeList Deserialize(Stream stream) { }

	// RVA: 0x1EF2DB0 Offset: 0x1EF13B0 VA: 0x181EF2DB0
	public static TreeList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF30D0 Offset: 0x1EF16D0 VA: 0x181EF30D0
	public static TreeList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF34D0 Offset: 0x1EF1AD0 VA: 0x181EF34D0
	public static TreeList Deserialize(byte[] buffer) { }

	// RVA: 0x1EF3830 Offset: 0x1EF1E30 VA: 0x181EF3830
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF4160 Offset: 0x1EF2760 VA: 0x181EF4160 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF4180 Offset: 0x1EF2780 VA: 0x181EF4180 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TreeList previous) { }

	// RVA: 0x1EF3850 Offset: 0x1EF1E50 VA: 0x181EF3850 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF3160 Offset: 0x1EF1760 VA: 0x181EF3160
	public static TreeList Deserialize(byte[] buffer, TreeList instance, bool isDelta = False) { }

	// RVA: 0x1EF32E0 Offset: 0x1EF18E0 VA: 0x181EF32E0
	public static TreeList Deserialize(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF2AE0 Offset: 0x1EF10E0 VA: 0x181EF2AE0
	public static TreeList DeserializeLengthDelimited(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF2E30 Offset: 0x1EF1430 VA: 0x181EF2E30
	public static TreeList DeserializeLength(Stream stream, int length, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF3BD0 Offset: 0x1EF21D0 VA: 0x181EF3BD0
	public static void SerializeDelta(Stream stream, TreeList instance, TreeList previous) { }

	// RVA: 0x1EF3F70 Offset: 0x1EF2570 VA: 0x181EF3F70
	public static void Serialize(Stream stream, TreeList instance) { }

	// RVA: 0x1EF4150 Offset: 0x1EF2750 VA: 0x181EF4150
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF4160 Offset: 0x1EF2760 VA: 0x181EF4160
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF3E60 Offset: 0x1EF2460 VA: 0x181EF3E60
	public static byte[] SerializeToBytes(TreeList instance) { }

	// RVA: 0x1EF3DB0 Offset: 0x1EF23B0 VA: 0x181EF3DB0
	public static void SerializeLengthDelimited(Stream stream, TreeList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

