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

	// RVA: 0x13ABA70 Offset: 0x13AA070 VA: 0x1813ABA70
	internal void .ctor(byte statusByte) { }

	// RVA: 0x13ABAB0 Offset: 0x13AA0B0 VA: 0x1813ABAB0
	internal void .ctor(byte statusByte, byte[] data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public byte get_StatusByte() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	private void set_Data(byte[] value) { }

	// RVA: 0x13AB930 Offset: 0x13A9F30 VA: 0x1813AB930 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13AB890 Offset: 0x13A9E90 VA: 0x1813AB890 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13ABA10 Offset: 0x13AA010 VA: 0x1813ABA10 Slot: 3
	public override string ToString() { }

}

