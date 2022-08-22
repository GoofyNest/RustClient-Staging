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

	// RVA: 0x1096C70 Offset: 0x1095270 VA: 0x181096C70
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x1096BC0 Offset: 0x10951C0 VA: 0x181096BC0
	public void .ctor(TimeSpan delta) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1095200 Offset: 0x1093800 VA: 0x181095200
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1095220 Offset: 0x1093820 VA: 0x181095220
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB11220 Offset: 0xB0F820 VA: 0x180B11220
	public Nullable<TimeSpan> get_Delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10865C0 Offset: 0x1084BC0 VA: 0x1810865C0
	private void set_Delta(Nullable<TimeSpan> value) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10965C0 Offset: 0x1094BC0 VA: 0x1810965C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1096740 Offset: 0x1094D40 VA: 0x181096740 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10968F0 Offset: 0x1094EF0 VA: 0x1810968F0
	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

	// RVA: 0x10967C0 Offset: 0x1094DC0 VA: 0x1810967C0 Slot: 3
	public override string ToString() { }

}

