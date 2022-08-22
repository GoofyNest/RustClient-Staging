public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 5806
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TimeSpan> <Delta>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public Nullable<TimeSpan> Delta { get; set; }

	// Methods

	// RVA: 0x10979A0 Offset: 0x1095FA0 VA: 0x1810979A0
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x10978F0 Offset: 0x1095EF0 VA: 0x1810978F0
	public void .ctor(TimeSpan delta) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1095F30 Offset: 0x1094530 VA: 0x181095F30
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1095F50 Offset: 0x1094550 VA: 0x181095F50
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB119B0 Offset: 0xB0FFB0 VA: 0x180B119B0
	public Nullable<TimeSpan> get_Delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10872F0 Offset: 0x10858F0 VA: 0x1810872F0
	private void set_Delta(Nullable<TimeSpan> value) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10972F0 Offset: 0x10958F0 VA: 0x1810972F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1097470 Offset: 0x1095A70 VA: 0x181097470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1097620 Offset: 0x1095C20 VA: 0x181097620
	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

	// RVA: 0x10974F0 Offset: 0x1095AF0 VA: 0x1810974F0 Slot: 3
	public override string ToString() { }

}

