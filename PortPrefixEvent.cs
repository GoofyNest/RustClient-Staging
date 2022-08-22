public sealed class PortPrefixEvent : MetaEvent // TypeDefIndex: 7541
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte <Port>k__BackingField; // 0x20

	// Properties
	public byte Port { get; set; }

	// Methods

	// RVA: 0x13A5230 Offset: 0x13A3830 VA: 0x1813A5230
	public void .ctor() { }

	// RVA: 0x13A5200 Offset: 0x13A3800 VA: 0x1813A5200
	public void .ctor(byte port) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public byte get_Port() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_Port(byte value) { }

	// RVA: 0x13A5170 Offset: 0x13A3770 VA: 0x1813A5170 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A5110 Offset: 0x13A3710 VA: 0x1813A5110 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A51A0 Offset: 0x13A37A0 VA: 0x1813A51A0 Slot: 3
	public override string ToString() { }

}

