public sealed class MidiTimeCodeEvent : SystemCommonEvent // TypeDefIndex: 7562
{	// Fields
	private static readonly Dictionary<MidiTimeCodeComponent, byte> ComponentValueMasks; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MidiTimeCodeComponent <Component>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FourBitNumber <ComponentValue>k__BackingField; // 0x21

	// Properties
	public MidiTimeCodeComponent Component { get; set; }
	public FourBitNumber ComponentValue { get; set; }

	// Methods

	// RVA: 0x13A29E0 Offset: 0x13A0FE0 VA: 0x1813A29E0
	public void .ctor() { }

	// RVA: 0x13A2A00 Offset: 0x13A1000 VA: 0x1813A2A00
	public void .ctor(MidiTimeCodeComponent component, FourBitNumber componentValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public MidiTimeCodeComponent get_Component() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_Component(MidiTimeCodeComponent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10B90 Offset: 0xB0F190 VA: 0x180B10B90
	public FourBitNumber get_ComponentValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A2B40 Offset: 0x13A1140 VA: 0x1813A2B40
	public void set_ComponentValue(FourBitNumber value) { }

	// RVA: 0x13A2530 Offset: 0x13A0B30 VA: 0x1813A2530 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A23C0 Offset: 0x13A09C0 VA: 0x1813A23C0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A2840 Offset: 0x13A0E40 VA: 0x1813A2840 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A28C0 Offset: 0x13A0EC0 VA: 0x1813A28C0
	private static void .cctor() { }

}

