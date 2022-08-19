public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 5803
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private EntityTagHeaderValue <EntityTag>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public EntityTagHeaderValue EntityTag { get; set; }

	// Methods

	// RVA: 0x10950E0 Offset: 0x10936E0 VA: 0x1810950E0
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x1095170 Offset: 0x1093770 VA: 0x181095170
	public void .ctor(EntityTagHeaderValue entityTag) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1095200 Offset: 0x1093800 VA: 0x181095200
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1095220 Offset: 0x1093820 VA: 0x181095220
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public EntityTagHeaderValue get_EntityTag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	private void set_EntityTag(EntityTagHeaderValue value) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1094AF0 Offset: 0x10930F0 VA: 0x181094AF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1094C40 Offset: 0x1093240 VA: 0x181094C40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1094D70 Offset: 0x1093370 VA: 0x181094D70
	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

	// RVA: 0x1094CB0 Offset: 0x10932B0 VA: 0x181094CB0 Slot: 3
	public override string ToString() { }

}

