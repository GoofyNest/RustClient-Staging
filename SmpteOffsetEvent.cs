public sealed class SmpteOffsetEvent : MetaEvent // TypeDefIndex: 7547
{	// Fields
	private SmpteData _smpteData; // 0x20

	// Properties
	public SmpteFormat Format { get; set; }
	public byte Hours { get; set; }
	public byte Minutes { get; set; }
	public byte Seconds { get; set; }
	public byte Frames { get; set; }
	public byte SubFrames { get; set; }

	// Methods

	// RVA: 0x13A6F80 Offset: 0x13A5580 VA: 0x1813A6F80
	public void .ctor() { }

	// RVA: 0x13A6FF0 Offset: 0x13A55F0 VA: 0x1813A6FF0
	public void .ctor(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) { }

	// RVA: 0x13A7140 Offset: 0x13A5740 VA: 0x1813A7140
	public SmpteFormat get_Format() { }

	// RVA: 0x13A7200 Offset: 0x13A5800 VA: 0x1813A7200
	public void set_Format(SmpteFormat value) { }

	// RVA: 0x13A7180 Offset: 0x13A5780 VA: 0x1813A7180
	public byte get_Hours() { }

	// RVA: 0x13A7280 Offset: 0x13A5880 VA: 0x1813A7280
	public void set_Hours(byte value) { }

	// RVA: 0x13A71A0 Offset: 0x13A57A0 VA: 0x1813A71A0
	public byte get_Minutes() { }

	// RVA: 0x13A72A0 Offset: 0x13A58A0 VA: 0x1813A72A0
	public void set_Minutes(byte value) { }

	// RVA: 0x13A71C0 Offset: 0x13A57C0 VA: 0x1813A71C0
	public byte get_Seconds() { }

	// RVA: 0x13A72C0 Offset: 0x13A58C0 VA: 0x1813A72C0
	public void set_Seconds(byte value) { }

	// RVA: 0x13A7160 Offset: 0x13A5760 VA: 0x1813A7160
	public byte get_Frames() { }

	// RVA: 0x13A7260 Offset: 0x13A5860 VA: 0x1813A7260
	public void set_Frames(byte value) { }

	// RVA: 0x13A71E0 Offset: 0x13A57E0 VA: 0x1813A71E0
	public byte get_SubFrames() { }

	// RVA: 0x13A72E0 Offset: 0x13A58E0 VA: 0x1813A72E0
	public void set_SubFrames(byte value) { }

	// RVA: 0x13A6A10 Offset: 0x13A5010 VA: 0x1813A6A10
	private byte ProcessValue(byte value, string property, byte max, InvalidMetaEventParameterValuePolicy policy) { }

	// RVA: 0x13A6AF0 Offset: 0x13A50F0 VA: 0x1813A6AF0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A6850 Offset: 0x13A4E50 VA: 0x1813A6850 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A6C10 Offset: 0x13A5210 VA: 0x1813A6C10 Slot: 3
	public override string ToString() { }

}

private sealed class SmpteOffsetEvent.<>c__DisplayClass22_0 // TypeDefIndex: 7548
{	// Fields
	public SmpteOffsetEvent <>4__this; // 0x10
	public ReadingSettings settings; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AA750 Offset: 0x13A8D50 VA: 0x1813AA750
	internal byte <ReadContent>b__0(byte value, string propertyName, byte max) { }

}

