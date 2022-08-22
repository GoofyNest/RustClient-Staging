public class ModuleMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6490
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemid; // 0x14
	public int moduleid; // 0x18
	public int type; // 0x1C
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F8A5C0 Offset: 0x1F88BC0 VA: 0x181F8A5C0
	public static void ResetToPool(ModuleMessage instance) { }

	// RVA: 0x1F8A510 Offset: 0x1F88B10 VA: 0x181F8A510
	public void ResetToPool() { }

	// RVA: 0x1F8A1A0 Offset: 0x1F887A0 VA: 0x181F8A1A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F88E70 Offset: 0x1F87470 VA: 0x181F88E70
	public void CopyTo(ModuleMessage instance) { }

	// RVA: 0x1F88F20 Offset: 0x1F87520 VA: 0x181F88F20
	public ModuleMessage Copy() { }

	// RVA: 0x1F89C20 Offset: 0x1F88220 VA: 0x181F89C20
	public static ModuleMessage Deserialize(Stream stream) { }

	// RVA: 0x1F89030 Offset: 0x1F87630 VA: 0x181F89030
	public static ModuleMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F893A0 Offset: 0x1F879A0 VA: 0x181F893A0
	public static ModuleMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F89E80 Offset: 0x1F88480 VA: 0x181F89E80
	public static ModuleMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1F8A2D0 Offset: 0x1F888D0 VA: 0x181F8A2D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8ABF0 Offset: 0x1F891F0 VA: 0x181F8ABF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8AC10 Offset: 0x1F89210 VA: 0x181F8AC10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModuleMessage previous) { }

	// RVA: 0x1F8A4F0 Offset: 0x1F88AF0 VA: 0x181F8A4F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F89920 Offset: 0x1F87F20 VA: 0x181F89920
	public static ModuleMessage Deserialize(byte[] buffer, ModuleMessage instance, bool isDelta = False) { }

	// RVA: 0x1F89700 Offset: 0x1F87D00 VA: 0x181F89700
	public static ModuleMessage Deserialize(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F890B0 Offset: 0x1F876B0 VA: 0x181F890B0
	public static ModuleMessage DeserializeLengthDelimited(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F89430 Offset: 0x1F87A30 VA: 0x181F89430
	public static ModuleMessage DeserializeLength(Stream stream, int length, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F8A670 Offset: 0x1F88C70 VA: 0x181F8A670
	public static void SerializeDelta(Stream stream, ModuleMessage instance, ModuleMessage previous) { }

	// RVA: 0x1F8AA50 Offset: 0x1F89050 VA: 0x181F8AA50
	public static void Serialize(Stream stream, ModuleMessage instance) { }

	// RVA: 0x1F8ABE0 Offset: 0x1F891E0 VA: 0x181F8ABE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8ABF0 Offset: 0x1F891F0 VA: 0x181F8ABF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8A940 Offset: 0x1F88F40 VA: 0x181F8A940
	public static byte[] SerializeToBytes(ModuleMessage instance) { }

	// RVA: 0x1F8A890 Offset: 0x1F88E90 VA: 0x181F8A890
	public static void SerializeLengthDelimited(Stream stream, ModuleMessage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

