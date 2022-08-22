public sealed class UnknownMetaEvent : MetaEvent // TypeDefIndex: 7551
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly byte <StatusByte>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte[] <Data>k__BackingField; // 0x28

	// Properties
	public byte StatusByte { get; }
	public byte[] Data { get; set; }

	// Methods

	// RVA: 0x13AAB70 Offset: 0x13A9170 VA: 0x1813AAB70
	internal void .ctor(byte statusByte) { }

	// RVA: 0x13AABB0 Offset: 0x13A91B0 VA: 0x1813AABB0
	internal void .ctor(byte statusByte, byte[] data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public byte get_StatusByte() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	private void set_Data(byte[] value) { }

	// RVA: 0x13AAA30 Offset: 0x13A9030 VA: 0x1813AAA30 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13AA990 Offset: 0x13A8F90 VA: 0x1813AA990 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13AAB10 Offset: 0x13A9110 VA: 0x1813AAB10 Slot: 3
	public override string ToString() { }

}

