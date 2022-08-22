public class ParentInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6302
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint bone; // 0x18

	// Methods

	// RVA: 0x1F951C0 Offset: 0x1F937C0 VA: 0x181F951C0
	public static void ResetToPool(ParentInfo instance) { }

	// RVA: 0x1F95140 Offset: 0x1F93740 VA: 0x181F95140
	public void ResetToPool() { }

	// RVA: 0x1F94EA0 Offset: 0x1F934A0 VA: 0x181F94EA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(ParentInfo instance) { }

	// RVA: 0x1F940A0 Offset: 0x1F926A0 VA: 0x181F940A0
	public ParentInfo Copy() { }

	// RVA: 0x1F948F0 Offset: 0x1F92EF0 VA: 0x181F948F0
	public static ParentInfo Deserialize(Stream stream) { }

	// RVA: 0x1F94110 Offset: 0x1F92710 VA: 0x181F94110
	public static ParentInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F943E0 Offset: 0x1F929E0 VA: 0x181F943E0
	public static ParentInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F94AB0 Offset: 0x1F930B0 VA: 0x181F94AB0
	public static ParentInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F94FA0 Offset: 0x1F935A0 VA: 0x181F94FA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F95680 Offset: 0x1F93C80 VA: 0x181F95680 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F956A0 Offset: 0x1F93CA0 VA: 0x181F956A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ParentInfo previous) { }

	// RVA: 0x1F95120 Offset: 0x1F93720 VA: 0x181F95120 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F946A0 Offset: 0x1F92CA0 VA: 0x181F946A0
	public static ParentInfo Deserialize(byte[] buffer, ParentInfo instance, bool isDelta = False) { }

	// RVA: 0x1F94D20 Offset: 0x1F93320 VA: 0x181F94D20
	public static ParentInfo Deserialize(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F94190 Offset: 0x1F92790 VA: 0x181F94190
	public static ParentInfo DeserializeLengthDelimited(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F94470 Offset: 0x1F92A70 VA: 0x181F94470
	public static ParentInfo DeserializeLength(Stream stream, int length, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F95240 Offset: 0x1F93840 VA: 0x181F95240
	public static void SerializeDelta(Stream stream, ParentInfo instance, ParentInfo previous) { }

	// RVA: 0x1F95570 Offset: 0x1F93B70 VA: 0x181F95570
	public static void Serialize(Stream stream, ParentInfo instance) { }

	// RVA: 0x1F95670 Offset: 0x1F93C70 VA: 0x181F95670
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F95680 Offset: 0x1F93C80 VA: 0x181F95680
	public void ToProto(Stream stream) { }

	// RVA: 0x1F95460 Offset: 0x1F93A60 VA: 0x181F95460
	public static byte[] SerializeToBytes(ParentInfo instance) { }

	// RVA: 0x1F953B0 Offset: 0x1F939B0 VA: 0x181F953B0
	public static void SerializeLengthDelimited(Stream stream, ParentInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

