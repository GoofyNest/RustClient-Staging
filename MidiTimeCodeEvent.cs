public sealed class MidiTimeCodeEvent : SystemCommonEvent // TypeDefIndex: 7562
{	private static readonly Dictionary<MidiTimeCodeComponent, byte> ComponentValueMasks; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MidiTimeCodeComponent <Component>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private FourBitNumber <ComponentValue>k__BackingField; // 0x21

	public MidiTimeCodeComponent Component { get; set; }
	public FourBitNumber ComponentValue { get; set; }


	public void .ctor() { }

	public void .ctor(MidiTimeCodeComponent component, FourBitNumber componentValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MidiTimeCodeComponent get_Component() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Component(MidiTimeCodeComponent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public FourBitNumber get_ComponentValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ComponentValue(FourBitNumber value) { }

	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

	private static void .cctor() { }

}

