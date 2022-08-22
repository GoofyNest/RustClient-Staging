public class ParentInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6302
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint bone; // 0x18

	// Methods

	// RVA: 0x1F949A0 Offset: 0x1F92FA0 VA: 0x181F949A0
	public static void ResetToPool(ParentInfo instance) { }

	// RVA: 0x1F94920 Offset: 0x1F92F20 VA: 0x181F94920
	public void ResetToPool() { }

	// RVA: 0x1F94680 Offset: 0x1F92C80 VA: 0x181F94680 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(ParentInfo instance) { }

	// RVA: 0x1F93880 Offset: 0x1F91E80 VA: 0x181F93880
	public ParentInfo Copy() { }

	// RVA: 0x1F940D0 Offset: 0x1F926D0 VA: 0x181F940D0
	public static ParentInfo Deserialize(Stream stream) { }

	// RVA: 0x1F938F0 Offset: 0x1F91EF0 VA: 0x181F938F0
	public static ParentInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F93BC0 Offset: 0x1F921C0 VA: 0x181F93BC0
	public static ParentInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F94290 Offset: 0x1F92890 VA: 0x181F94290
	public static ParentInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F94780 Offset: 0x1F92D80 VA: 0x181F94780
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F94E60 Offset: 0x1F93460 VA: 0x181F94E60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F94E80 Offset: 0x1F93480 VA: 0x181F94E80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ParentInfo previous) { }

	// RVA: 0x1F94900 Offset: 0x1F92F00 VA: 0x181F94900 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F93E80 Offset: 0x1F92480 VA: 0x181F93E80
	public static ParentInfo Deserialize(byte[] buffer, ParentInfo instance, bool isDelta = False) { }

	// RVA: 0x1F94500 Offset: 0x1F92B00 VA: 0x181F94500
	public static ParentInfo Deserialize(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F93970 Offset: 0x1F91F70 VA: 0x181F93970
	public static ParentInfo DeserializeLengthDelimited(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F93C50 Offset: 0x1F92250 VA: 0x181F93C50
	public static ParentInfo DeserializeLength(Stream stream, int length, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F94A20 Offset: 0x1F93020 VA: 0x181F94A20
	public static void SerializeDelta(Stream stream, ParentInfo instance, ParentInfo previous) { }

	// RVA: 0x1F94D50 Offset: 0x1F93350 VA: 0x181F94D50
	public static void Serialize(Stream stream, ParentInfo instance) { }

	// RVA: 0x1F94E50 Offset: 0x1F93450 VA: 0x181F94E50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F94E60 Offset: 0x1F93460 VA: 0x181F94E60
	public void ToProto(Stream stream) { }

	// RVA: 0x1F94C40 Offset: 0x1F93240 VA: 0x181F94C40
	public static byte[] SerializeToBytes(ParentInfo instance) { }

	// RVA: 0x1F94B90 Offset: 0x1F93190 VA: 0x181F94B90
	public static void SerializeLengthDelimited(Stream stream, ParentInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

