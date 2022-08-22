public class Magazine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6317
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int capacity; // 0x14
	public int contents; // 0x18
	public int ammoType; // 0x1C

	// Methods

	// RVA: 0x1F2A530 Offset: 0x1F28B30 VA: 0x181F2A530
	public static void ResetToPool(Magazine instance) { }

	// RVA: 0x1F2A4A0 Offset: 0x1F28AA0 VA: 0x181F2A4A0
	public void ResetToPool() { }

	// RVA: 0x1F2A1C0 Offset: 0x1F287C0 VA: 0x181F2A1C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28F40 Offset: 0x1E27540 VA: 0x181E28F40
	public void CopyTo(Magazine instance) { }

	// RVA: 0x1F29290 Offset: 0x1F27890 VA: 0x181F29290
	public Magazine Copy() { }

	// RVA: 0x1F29D50 Offset: 0x1F28350 VA: 0x181F29D50
	public static Magazine Deserialize(Stream stream) { }

	// RVA: 0x1F29310 Offset: 0x1F27910 VA: 0x181F29310
	public static Magazine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F29870 Offset: 0x1F27E70 VA: 0x181F29870
	public static Magazine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F29900 Offset: 0x1F27F00 VA: 0x181F29900
	public static Magazine Deserialize(byte[] buffer) { }

	// RVA: 0x1F2A2D0 Offset: 0x1F288D0 VA: 0x181F2A2D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2AA70 Offset: 0x1F29070 VA: 0x181F2AA70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2AA90 Offset: 0x1F29090 VA: 0x181F2AA90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Magazine previous) { }

	// RVA: 0x1F2A480 Offset: 0x1F28A80 VA: 0x181F2A480 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F29F40 Offset: 0x1F28540 VA: 0x181F29F40
	public static Magazine Deserialize(byte[] buffer, Magazine instance, bool isDelta = False) { }

	// RVA: 0x1F29BA0 Offset: 0x1F281A0 VA: 0x181F29BA0
	public static Magazine Deserialize(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F29390 Offset: 0x1F27990 VA: 0x181F29390
	public static Magazine DeserializeLengthDelimited(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F29610 Offset: 0x1F27C10 VA: 0x181F29610
	public static Magazine DeserializeLength(Stream stream, int length, Magazine instance, bool isDelta) { }

	// RVA: 0x1F2A5C0 Offset: 0x1F28BC0 VA: 0x181F2A5C0
	public static void SerializeDelta(Stream stream, Magazine instance, Magazine previous) { }

	// RVA: 0x1F2A940 Offset: 0x1F28F40 VA: 0x181F2A940
	public static void Serialize(Stream stream, Magazine instance) { }

	// RVA: 0x1F2AA60 Offset: 0x1F29060 VA: 0x181F2AA60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2AA70 Offset: 0x1F29070 VA: 0x181F2AA70
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2A830 Offset: 0x1F28E30 VA: 0x181F2A830
	public static byte[] SerializeToBytes(Magazine instance) { }

	// RVA: 0x1F2A780 Offset: 0x1F28D80 VA: 0x181F2A780
	public static void SerializeLengthDelimited(Stream stream, Magazine instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

