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

	// RVA: 0x13A3620 Offset: 0x13A1C20 VA: 0x1813A3620
	public void .ctor() { }

	// RVA: 0x13A3640 Offset: 0x13A1C40 VA: 0x1813A3640
	public void .ctor(MidiTimeCodeComponent component, FourBitNumber componentValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public MidiTimeCodeComponent get_Component() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void set_Component(MidiTimeCodeComponent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10400 Offset: 0xB0EA00 VA: 0x180B10400
	public FourBitNumber get_ComponentValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A3780 Offset: 0x13A1D80 VA: 0x1813A3780
	public void set_ComponentValue(FourBitNumber value) { }

	// RVA: 0x13A3170 Offset: 0x13A1770 VA: 0x1813A3170 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A3000 Offset: 0x13A1600 VA: 0x1813A3000 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A3480 Offset: 0x13A1A80 VA: 0x1813A3480 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A3500 Offset: 0x13A1B00 VA: 0x1813A3500
	private static void .cctor() { }

}

