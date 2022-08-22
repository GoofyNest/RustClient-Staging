public class ModuleMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6490
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemid; // 0x14
	public int moduleid; // 0x18
	public int type; // 0x1C
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F89AE0 Offset: 0x1F880E0 VA: 0x181F89AE0
	public static void ResetToPool(ModuleMessage instance) { }

	// RVA: 0x1F89A30 Offset: 0x1F88030 VA: 0x181F89A30
	public void ResetToPool() { }

	// RVA: 0x1F896C0 Offset: 0x1F87CC0 VA: 0x181F896C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F88390 Offset: 0x1F86990 VA: 0x181F88390
	public void CopyTo(ModuleMessage instance) { }

	// RVA: 0x1F88440 Offset: 0x1F86A40 VA: 0x181F88440
	public ModuleMessage Copy() { }

	// RVA: 0x1F89140 Offset: 0x1F87740 VA: 0x181F89140
	public static ModuleMessage Deserialize(Stream stream) { }

	// RVA: 0x1F88550 Offset: 0x1F86B50 VA: 0x181F88550
	public static ModuleMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F888C0 Offset: 0x1F86EC0 VA: 0x181F888C0
	public static ModuleMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F893A0 Offset: 0x1F879A0 VA: 0x181F893A0
	public static ModuleMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1F897F0 Offset: 0x1F87DF0 VA: 0x181F897F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8A110 Offset: 0x1F88710 VA: 0x181F8A110 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8A130 Offset: 0x1F88730 VA: 0x181F8A130 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModuleMessage previous) { }

	// RVA: 0x1F89A10 Offset: 0x1F88010 VA: 0x181F89A10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F88E40 Offset: 0x1F87440 VA: 0x181F88E40
	public static ModuleMessage Deserialize(byte[] buffer, ModuleMessage instance, bool isDelta = False) { }

	// RVA: 0x1F88C20 Offset: 0x1F87220 VA: 0x181F88C20
	public static ModuleMessage Deserialize(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F885D0 Offset: 0x1F86BD0 VA: 0x181F885D0
	public static ModuleMessage DeserializeLengthDelimited(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F88950 Offset: 0x1F86F50 VA: 0x181F88950
	public static ModuleMessage DeserializeLength(Stream stream, int length, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F89B90 Offset: 0x1F88190 VA: 0x181F89B90
	public static void SerializeDelta(Stream stream, ModuleMessage instance, ModuleMessage previous) { }

	// RVA: 0x1F89F70 Offset: 0x1F88570 VA: 0x181F89F70
	public static void Serialize(Stream stream, ModuleMessage instance) { }

	// RVA: 0x1F8A100 Offset: 0x1F88700 VA: 0x181F8A100
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8A110 Offset: 0x1F88710 VA: 0x181F8A110
	public void ToProto(Stream stream) { }

	// RVA: 0x1F89E60 Offset: 0x1F88460 VA: 0x181F89E60
	public static byte[] SerializeToBytes(ModuleMessage instance) { }

	// RVA: 0x1F89DB0 Offset: 0x1F883B0 VA: 0x181F89DB0
	public static void SerializeLengthDelimited(Stream stream, ModuleMessage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

