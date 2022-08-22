public sealed class PortPrefixEvent : MetaEvent // TypeDefIndex: 7541
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte <Port>k__BackingField; // 0x20

	// Properties
	public byte Port { get; set; }

	// Methods

	// RVA: 0x13A4330 Offset: 0x13A2930 VA: 0x1813A4330
	public void .ctor() { }

	// RVA: 0x13A4300 Offset: 0x13A2900 VA: 0x1813A4300
	public void .ctor(byte port) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public byte get_Port() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_Port(byte value) { }

	// RVA: 0x13A4270 Offset: 0x13A2870 VA: 0x1813A4270 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A4210 Offset: 0x13A2810 VA: 0x1813A4210 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A42A0 Offset: 0x13A28A0 VA: 0x1813A42A0 Slot: 3
	public override string ToString() { }

}

