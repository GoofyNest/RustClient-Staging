public sealed class UnknownMetaEvent : MetaEvent // TypeDefIndex: 7551
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly byte <StatusByte>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private byte[] <Data>k__BackingField; // 0x28

	// Properties
	public byte StatusByte { get; }
	public byte[] Data { get; set; }

	// Methods

	// RVA: 0x13AB7B0 Offset: 0x13A9DB0 VA: 0x1813AB7B0
	internal void .ctor(byte statusByte) { }

	// RVA: 0x13AB7F0 Offset: 0x13A9DF0 VA: 0x1813AB7F0
	internal void .ctor(byte statusByte, byte[] data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public byte get_StatusByte() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	private void set_Data(byte[] value) { }

	// RVA: 0x13AB670 Offset: 0x13A9C70 VA: 0x1813AB670 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13AB5D0 Offset: 0x13A9BD0 VA: 0x1813AB5D0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13AB750 Offset: 0x13A9D50 VA: 0x1813AB750 Slot: 3
	public override string ToString() { }

}

