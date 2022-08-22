internal sealed class SmpteData // TypeDefIndex: 7618
{	// Fields
	private static readonly Dictionary<SmpteFormat, byte> MaxFrames; // 0x0
	private static readonly SmpteFormat[] Formats; // 0x8
	private SmpteFormat _format; // 0x10
	private byte _hours; // 0x11
	private byte _minutes; // 0x12
	private byte _seconds; // 0x13
	private byte _frames; // 0x14
	private byte _subFrames; // 0x15

	// Properties
	public SmpteFormat Format { get; set; }
	public byte Hours { get; set; }
	public byte Minutes { get; set; }
	public byte Seconds { get; set; }
	public byte Frames { get; set; }
	public byte SubFrames { get; set; }

	// Methods

	// RVA: 0x13A5880 Offset: 0x13A3E80 VA: 0x1813A5880
	public void .ctor() { }

	// RVA: 0x13A57B0 Offset: 0x13A3DB0 VA: 0x1813A57B0
	public void .ctor(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public SmpteFormat get_Format() { }

	// RVA: 0x13A58A0 Offset: 0x13A3EA0 VA: 0x1813A58A0
	public void set_Format(SmpteFormat value) { }

	// RVA: 0xF8C110 Offset: 0xF8A710 VA: 0x180F8C110
	public byte get_Hours() { }

	// RVA: 0x13A59D0 Offset: 0x13A3FD0 VA: 0x1813A59D0
	public void set_Hours(byte value) { }

	// RVA: 0xF9EEC0 Offset: 0xF9D4C0 VA: 0x180F9EEC0
	public byte get_Minutes() { }

	// RVA: 0x13A5A60 Offset: 0x13A4060 VA: 0x1813A5A60
	public void set_Minutes(byte value) { }

	// RVA: 0x13A5890 Offset: 0x13A3E90 VA: 0x1813A5890
	public byte get_Seconds() { }

	// RVA: 0x13A5AF0 Offset: 0x13A40F0 VA: 0x1813A5AF0
	public void set_Seconds(byte value) { }

	// RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	public byte get_Frames() { }

	// RVA: 0x13A58F0 Offset: 0x13A3EF0 VA: 0x1813A58F0
	public void set_Frames(byte value) { }

	// RVA: 0x13A4790 Offset: 0x13A2D90 VA: 0x1813A4790
	public byte get_SubFrames() { }

	// RVA: 0x13A5B80 Offset: 0x13A4180 VA: 0x1813A5B80
	public void set_SubFrames(byte value) { }

	// RVA: 0x13A53B0 Offset: 0x13A39B0 VA: 0x1813A53B0
	public static SmpteData Read(Func<byte> byteReader, Func<byte, string, byte, byte> valueProcessor) { }

	// RVA: 0x13A5310 Offset: 0x13A3910 VA: 0x1813A5310
	internal static SmpteFormat GetFormat(byte formatAndHours) { }

	// RVA: 0x13A53A0 Offset: 0x13A39A0 VA: 0x1813A53A0
	internal static byte GetHours(byte formatAndHours) { }

	// RVA: 0x13A56B0 Offset: 0x13A3CB0 VA: 0x1813A56B0
	private static void .cctor() { }

}

