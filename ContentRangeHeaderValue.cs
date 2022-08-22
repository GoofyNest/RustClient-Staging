public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 5764
{	// Fields
	private string unit; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<long> <From>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<long> <Length>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<long> <To>k__BackingField; // 0x38

	// Properties
	public Nullable<long> From { get; set; }
	public Nullable<long> Length { get; set; }
	public Nullable<long> To { get; set; }
	public string Unit { get; }

	// Methods

	// RVA: 0x1088850 Offset: 0x1086E50 VA: 0x181088850
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0
	public Nullable<long> get_From() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10888A0 Offset: 0x1086EA0 VA: 0x1810888A0
	private void set_From(Nullable<long> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB119B0 Offset: 0xB0FFB0 VA: 0x180B119B0
	public Nullable<long> get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10872F0 Offset: 0x10858F0 VA: 0x1810872F0
	private void set_Length(Nullable<long> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC210 Offset: 0x6FA810 VA: 0x1806FC210
	public Nullable<long> get_To() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10888B0 Offset: 0x1086EB0 VA: 0x1810888B0
	private void set_To(Nullable<long> value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Unit() { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1087D80 Offset: 0x1086380 VA: 0x181087D80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1087ED0 Offset: 0x10864D0 VA: 0x181087ED0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10881E0 Offset: 0x10867E0 VA: 0x1810881E0
	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) { }

	// RVA: 0x1087FD0 Offset: 0x10865D0 VA: 0x181087FD0 Slot: 3
	public override string ToString() { }

}

