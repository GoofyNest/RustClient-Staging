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

	// RVA: 0x1096F30 Offset: 0x1095530 VA: 0x181096F30
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x1096E80 Offset: 0x1095480 VA: 0x181096E80
	public void .ctor(TimeSpan delta) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10954C0 Offset: 0x1093AC0 VA: 0x1810954C0
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10954E0 Offset: 0x1093AE0 VA: 0x1810954E0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB114E0 Offset: 0xB0FAE0 VA: 0x180B114E0
	public Nullable<TimeSpan> get_Delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1086880 Offset: 0x1084E80 VA: 0x181086880
	private void set_Delta(Nullable<TimeSpan> value) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1096880 Offset: 0x1094E80 VA: 0x181096880 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1096A00 Offset: 0x1095000 VA: 0x181096A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1096BB0 Offset: 0x10951B0 VA: 0x181096BB0
	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

	// RVA: 0x1096A80 Offset: 0x1095080 VA: 0x181096A80 Slot: 3
	public override string ToString() { }

}

