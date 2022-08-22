public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 5803
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EntityTagHeaderValue <EntityTag>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public EntityTagHeaderValue EntityTag { get; set; }

	// Methods

	// RVA: 0x10953A0 Offset: 0x10939A0 VA: 0x1810953A0
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x1095430 Offset: 0x1093A30 VA: 0x181095430
	public void .ctor(EntityTagHeaderValue entityTag) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10954C0 Offset: 0x1093AC0 VA: 0x1810954C0
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10954E0 Offset: 0x1093AE0 VA: 0x1810954E0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public EntityTagHeaderValue get_EntityTag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	private void set_EntityTag(EntityTagHeaderValue value) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1094DB0 Offset: 0x10933B0 VA: 0x181094DB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1094F00 Offset: 0x1093500 VA: 0x181094F00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1095030 Offset: 0x1093630 VA: 0x181095030
	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

	// RVA: 0x1094F70 Offset: 0x1093570 VA: 0x181094F70 Slot: 3
	public override string ToString() { }

}

