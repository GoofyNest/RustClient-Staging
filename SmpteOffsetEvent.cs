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

	// RVA: 0x13A6340 Offset: 0x13A4940 VA: 0x1813A6340
	public void .ctor() { }

	// RVA: 0x13A63B0 Offset: 0x13A49B0 VA: 0x1813A63B0
	public void .ctor(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) { }

	// RVA: 0x13A6500 Offset: 0x13A4B00 VA: 0x1813A6500
	public SmpteFormat get_Format() { }

	// RVA: 0x13A65C0 Offset: 0x13A4BC0 VA: 0x1813A65C0
	public void set_Format(SmpteFormat value) { }

	// RVA: 0x13A6540 Offset: 0x13A4B40 VA: 0x1813A6540
	public byte get_Hours() { }

	// RVA: 0x13A6640 Offset: 0x13A4C40 VA: 0x1813A6640
	public void set_Hours(byte value) { }

	// RVA: 0x13A6560 Offset: 0x13A4B60 VA: 0x1813A6560
	public byte get_Minutes() { }

	// RVA: 0x13A6660 Offset: 0x13A4C60 VA: 0x1813A6660
	public void set_Minutes(byte value) { }

	// RVA: 0x13A6580 Offset: 0x13A4B80 VA: 0x1813A6580
	public byte get_Seconds() { }

	// RVA: 0x13A6680 Offset: 0x13A4C80 VA: 0x1813A6680
	public void set_Seconds(byte value) { }

	// RVA: 0x13A6520 Offset: 0x13A4B20 VA: 0x1813A6520
	public byte get_Frames() { }

	// RVA: 0x13A6620 Offset: 0x13A4C20 VA: 0x1813A6620
	public void set_Frames(byte value) { }

	// RVA: 0x13A65A0 Offset: 0x13A4BA0 VA: 0x1813A65A0
	public byte get_SubFrames() { }

	// RVA: 0x13A66A0 Offset: 0x13A4CA0 VA: 0x1813A66A0
	public void set_SubFrames(byte value) { }

	// RVA: 0x13A5DD0 Offset: 0x13A43D0 VA: 0x1813A5DD0
	private byte ProcessValue(byte value, string property, byte max, InvalidMetaEventParameterValuePolicy policy) { }

	// RVA: 0x13A5EB0 Offset: 0x13A44B0 VA: 0x1813A5EB0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A5C10 Offset: 0x13A4210 VA: 0x1813A5C10 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A5FD0 Offset: 0x13A45D0 VA: 0x1813A5FD0 Slot: 3
	public override string ToString() { }

}

private sealed class SmpteOffsetEvent.<>c__DisplayClass22_0 // TypeDefIndex: 7548
{	// Fields
	public SmpteOffsetEvent <>4__this; // 0x10
	public ReadingSettings settings; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13A9B10 Offset: 0x13A8110 VA: 0x1813A9B10
	internal byte <ReadContent>b__0(byte value, string propertyName, byte max) { }

}

