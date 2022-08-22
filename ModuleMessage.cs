public class ModuleMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6490
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemid; // 0x14
	public int moduleid; // 0x18
	public int type; // 0x1C
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F89DA0 Offset: 0x1F883A0 VA: 0x181F89DA0
	public static void ResetToPool(ModuleMessage instance) { }

	// RVA: 0x1F89CF0 Offset: 0x1F882F0 VA: 0x181F89CF0
	public void ResetToPool() { }

	// RVA: 0x1F89980 Offset: 0x1F87F80 VA: 0x181F89980 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F88650 Offset: 0x1F86C50 VA: 0x181F88650
	public void CopyTo(ModuleMessage instance) { }

	// RVA: 0x1F88700 Offset: 0x1F86D00 VA: 0x181F88700
	public ModuleMessage Copy() { }

	// RVA: 0x1F89400 Offset: 0x1F87A00 VA: 0x181F89400
	public static ModuleMessage Deserialize(Stream stream) { }

	// RVA: 0x1F88810 Offset: 0x1F86E10 VA: 0x181F88810
	public static ModuleMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F88B80 Offset: 0x1F87180 VA: 0x181F88B80
	public static ModuleMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F89660 Offset: 0x1F87C60 VA: 0x181F89660
	public static ModuleMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1F89AB0 Offset: 0x1F880B0 VA: 0x181F89AB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8A3D0 Offset: 0x1F889D0 VA: 0x181F8A3D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8A3F0 Offset: 0x1F889F0 VA: 0x181F8A3F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModuleMessage previous) { }

	// RVA: 0x1F89CD0 Offset: 0x1F882D0 VA: 0x181F89CD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F89100 Offset: 0x1F87700 VA: 0x181F89100
	public static ModuleMessage Deserialize(byte[] buffer, ModuleMessage instance, bool isDelta = False) { }

	// RVA: 0x1F88EE0 Offset: 0x1F874E0 VA: 0x181F88EE0
	public static ModuleMessage Deserialize(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F88890 Offset: 0x1F86E90 VA: 0x181F88890
	public static ModuleMessage DeserializeLengthDelimited(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F88C10 Offset: 0x1F87210 VA: 0x181F88C10
	public static ModuleMessage DeserializeLength(Stream stream, int length, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F89E50 Offset: 0x1F88450 VA: 0x181F89E50
	public static void SerializeDelta(Stream stream, ModuleMessage instance, ModuleMessage previous) { }

	// RVA: 0x1F8A230 Offset: 0x1F88830 VA: 0x181F8A230
	public static void Serialize(Stream stream, ModuleMessage instance) { }

	// RVA: 0x1F8A3C0 Offset: 0x1F889C0 VA: 0x181F8A3C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8A3D0 Offset: 0x1F889D0 VA: 0x181F8A3D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8A120 Offset: 0x1F88720 VA: 0x181F8A120
	public static byte[] SerializeToBytes(ModuleMessage instance) { }

	// RVA: 0x1F8A070 Offset: 0x1F88670 VA: 0x181F8A070
	public static void SerializeLengthDelimited(Stream stream, ModuleMessage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

