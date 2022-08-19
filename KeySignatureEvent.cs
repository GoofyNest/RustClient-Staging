public sealed class KeySignatureEvent : MetaEvent // TypeDefIndex: 7538
{	// Fields
	private sbyte _key; // 0x20
	private byte _scale; // 0x21

	// Properties
	public sbyte Key { get; set; }
	public byte Scale { get; set; }

	// Methods

	// RVA: 0x1399AD0 Offset: 0x13980D0 VA: 0x181399AD0
	public void .ctor() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public sbyte get_Key() { }

	// RVA: 0x1399AF0 Offset: 0x13980F0 VA: 0x181399AF0
	public void set_Key(sbyte value) { }

	// RVA: 0xB10400 Offset: 0xB0EA00 VA: 0x180B10400
	public byte get_Scale() { }

	// RVA: 0x1399BA0 Offset: 0x13981A0 VA: 0x181399BA0
	public void set_Scale(byte value) { }

	// RVA: 0x1399750 Offset: 0x1397D50 VA: 0x181399750
	private int ProcessValue(int value, string property, int min, int max, InvalidMetaEventParameterValuePolicy policy) { }

	// RVA: 0x1399850 Offset: 0x1397E50 VA: 0x181399850 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13996E0 Offset: 0x1397CE0 VA: 0x1813996E0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1399A50 Offset: 0x1398050 VA: 0x181399A50 Slot: 3
	public override string ToString() { }

}

