public class ModuleMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6490
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemid; // 0x14
	public int moduleid; // 0x18
	public int type; // 0x1C
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F89CA0 Offset: 0x1F882A0 VA: 0x181F89CA0
	public static void ResetToPool(ModuleMessage instance) { }

	// RVA: 0x1F89BF0 Offset: 0x1F881F0 VA: 0x181F89BF0
	public void ResetToPool() { }

	// RVA: 0x1F89880 Offset: 0x1F87E80 VA: 0x181F89880 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F88550 Offset: 0x1F86B50 VA: 0x181F88550
	public void CopyTo(ModuleMessage instance) { }

	// RVA: 0x1F88600 Offset: 0x1F86C00 VA: 0x181F88600
	public ModuleMessage Copy() { }

	// RVA: 0x1F89300 Offset: 0x1F87900 VA: 0x181F89300
	public static ModuleMessage Deserialize(Stream stream) { }

	// RVA: 0x1F88710 Offset: 0x1F86D10 VA: 0x181F88710
	public static ModuleMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F88A80 Offset: 0x1F87080 VA: 0x181F88A80
	public static ModuleMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F89560 Offset: 0x1F87B60 VA: 0x181F89560
	public static ModuleMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1F899B0 Offset: 0x1F87FB0 VA: 0x181F899B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8A2D0 Offset: 0x1F888D0 VA: 0x181F8A2D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8A2F0 Offset: 0x1F888F0 VA: 0x181F8A2F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModuleMessage previous) { }

	// RVA: 0x1F89BD0 Offset: 0x1F881D0 VA: 0x181F89BD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F89000 Offset: 0x1F87600 VA: 0x181F89000
	public static ModuleMessage Deserialize(byte[] buffer, ModuleMessage instance, bool isDelta = False) { }

	// RVA: 0x1F88DE0 Offset: 0x1F873E0 VA: 0x181F88DE0
	public static ModuleMessage Deserialize(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F88790 Offset: 0x1F86D90 VA: 0x181F88790
	public static ModuleMessage DeserializeLengthDelimited(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F88B10 Offset: 0x1F87110 VA: 0x181F88B10
	public static ModuleMessage DeserializeLength(Stream stream, int length, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F89D50 Offset: 0x1F88350 VA: 0x181F89D50
	public static void SerializeDelta(Stream stream, ModuleMessage instance, ModuleMessage previous) { }

	// RVA: 0x1F8A130 Offset: 0x1F88730 VA: 0x181F8A130
	public static void Serialize(Stream stream, ModuleMessage instance) { }

	// RVA: 0x1F8A2C0 Offset: 0x1F888C0 VA: 0x181F8A2C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8A2D0 Offset: 0x1F888D0 VA: 0x181F8A2D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8A020 Offset: 0x1F88620 VA: 0x181F8A020
	public static byte[] SerializeToBytes(ModuleMessage instance) { }

	// RVA: 0x1F89F70 Offset: 0x1F88570 VA: 0x181F89F70
	public static void SerializeLengthDelimited(Stream stream, ModuleMessage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

