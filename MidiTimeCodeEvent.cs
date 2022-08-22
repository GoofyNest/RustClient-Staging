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

	// RVA: 0x13A38E0 Offset: 0x13A1EE0 VA: 0x1813A38E0
	public void .ctor() { }

	// RVA: 0x13A3900 Offset: 0x13A1F00 VA: 0x1813A3900
	public void .ctor(MidiTimeCodeComponent component, FourBitNumber componentValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public MidiTimeCodeComponent get_Component() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_Component(MidiTimeCodeComponent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106C0 Offset: 0xB0ECC0 VA: 0x180B106C0
	public FourBitNumber get_ComponentValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A3A40 Offset: 0x13A2040 VA: 0x1813A3A40
	public void set_ComponentValue(FourBitNumber value) { }

	// RVA: 0x13A3430 Offset: 0x13A1A30 VA: 0x1813A3430 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A32C0 Offset: 0x13A18C0 VA: 0x1813A32C0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A3740 Offset: 0x13A1D40 VA: 0x1813A3740 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A37C0 Offset: 0x13A1DC0 VA: 0x1813A37C0
	private static void .cctor() { }

}

