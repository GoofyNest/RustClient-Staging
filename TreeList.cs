public class TreeList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6497
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Tree> trees; // 0x18

	// Methods

	// RVA: 0x1EF4240 Offset: 0x1EF2840 VA: 0x181EF4240
	public static void ResetToPool(TreeList instance) { }

	// RVA: 0x1EF4090 Offset: 0x1EF2690 VA: 0x181EF4090
	public void ResetToPool() { }

	// RVA: 0x1EF3E10 Offset: 0x1EF2410 VA: 0x181EF3E10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF2F60 Offset: 0x1EF1560 VA: 0x181EF2F60
	public void CopyTo(TreeList instance) { }

	// RVA: 0x1EF3100 Offset: 0x1EF1700 VA: 0x181EF3100
	public TreeList Copy() { }

	// RVA: 0x1EF3A80 Offset: 0x1EF2080 VA: 0x181EF3A80
	public static TreeList Deserialize(Stream stream) { }

	// RVA: 0x1EF35D0 Offset: 0x1EF1BD0 VA: 0x181EF35D0
	public static TreeList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF38F0 Offset: 0x1EF1EF0 VA: 0x181EF38F0
	public static TreeList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF3CF0 Offset: 0x1EF22F0 VA: 0x181EF3CF0
	public static TreeList Deserialize(byte[] buffer) { }

	// RVA: 0x1EF4050 Offset: 0x1EF2650 VA: 0x181EF4050
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF4980 Offset: 0x1EF2F80 VA: 0x181EF4980 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF49A0 Offset: 0x1EF2FA0 VA: 0x181EF49A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TreeList previous) { }

	// RVA: 0x1EF4070 Offset: 0x1EF2670 VA: 0x181EF4070 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF3980 Offset: 0x1EF1F80 VA: 0x181EF3980
	public static TreeList Deserialize(byte[] buffer, TreeList instance, bool isDelta = False) { }

	// RVA: 0x1EF3B00 Offset: 0x1EF2100 VA: 0x181EF3B00
	public static TreeList Deserialize(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF3300 Offset: 0x1EF1900 VA: 0x181EF3300
	public static TreeList DeserializeLengthDelimited(Stream stream, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF3650 Offset: 0x1EF1C50 VA: 0x181EF3650
	public static TreeList DeserializeLength(Stream stream, int length, TreeList instance, bool isDelta) { }

	// RVA: 0x1EF43F0 Offset: 0x1EF29F0 VA: 0x181EF43F0
	public static void SerializeDelta(Stream stream, TreeList instance, TreeList previous) { }

	// RVA: 0x1EF4790 Offset: 0x1EF2D90 VA: 0x181EF4790
	public static void Serialize(Stream stream, TreeList instance) { }

	// RVA: 0x1EF4970 Offset: 0x1EF2F70 VA: 0x181EF4970
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF4980 Offset: 0x1EF2F80 VA: 0x181EF4980
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF4680 Offset: 0x1EF2C80 VA: 0x181EF4680
	public static byte[] SerializeToBytes(TreeList instance) { }

	// RVA: 0x1EF45D0 Offset: 0x1EF2BD0 VA: 0x181EF45D0
	public static void SerializeLengthDelimited(Stream stream, TreeList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

