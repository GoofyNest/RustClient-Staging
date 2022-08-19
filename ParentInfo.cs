public class ParentInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6302
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint bone; // 0x18

	// Methods

	// RVA: 0x1F948A0 Offset: 0x1F92EA0 VA: 0x181F948A0
	public static void ResetToPool(ParentInfo instance) { }

	// RVA: 0x1F94820 Offset: 0x1F92E20 VA: 0x181F94820
	public void ResetToPool() { }

	// RVA: 0x1F94580 Offset: 0x1F92B80 VA: 0x181F94580 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEAA0 Offset: 0x1DBD0A0 VA: 0x181DBEAA0
	public void CopyTo(ParentInfo instance) { }

	// RVA: 0x1F93780 Offset: 0x1F91D80 VA: 0x181F93780
	public ParentInfo Copy() { }

	// RVA: 0x1F93FD0 Offset: 0x1F925D0 VA: 0x181F93FD0
	public static ParentInfo Deserialize(Stream stream) { }

	// RVA: 0x1F937F0 Offset: 0x1F91DF0 VA: 0x181F937F0
	public static ParentInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F93AC0 Offset: 0x1F920C0 VA: 0x181F93AC0
	public static ParentInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F94190 Offset: 0x1F92790 VA: 0x181F94190
	public static ParentInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F94680 Offset: 0x1F92C80 VA: 0x181F94680
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F94D60 Offset: 0x1F93360 VA: 0x181F94D60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F94D80 Offset: 0x1F93380 VA: 0x181F94D80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ParentInfo previous) { }

	// RVA: 0x1F94800 Offset: 0x1F92E00 VA: 0x181F94800 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F93D80 Offset: 0x1F92380 VA: 0x181F93D80
	public static ParentInfo Deserialize(byte[] buffer, ParentInfo instance, bool isDelta = False) { }

	// RVA: 0x1F94400 Offset: 0x1F92A00 VA: 0x181F94400
	public static ParentInfo Deserialize(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F93870 Offset: 0x1F91E70 VA: 0x181F93870
	public static ParentInfo DeserializeLengthDelimited(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F93B50 Offset: 0x1F92150 VA: 0x181F93B50
	public static ParentInfo DeserializeLength(Stream stream, int length, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F94920 Offset: 0x1F92F20 VA: 0x181F94920
	public static void SerializeDelta(Stream stream, ParentInfo instance, ParentInfo previous) { }

	// RVA: 0x1F94C50 Offset: 0x1F93250 VA: 0x181F94C50
	public static void Serialize(Stream stream, ParentInfo instance) { }

	// RVA: 0x1F94D50 Offset: 0x1F93350 VA: 0x181F94D50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F94D60 Offset: 0x1F93360 VA: 0x181F94D60
	public void ToProto(Stream stream) { }

	// RVA: 0x1F94B40 Offset: 0x1F93140 VA: 0x181F94B40
	public static byte[] SerializeToBytes(ParentInfo instance) { }

	// RVA: 0x1F94A90 Offset: 0x1F93090 VA: 0x181F94A90
	public static void SerializeLengthDelimited(Stream stream, ParentInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

