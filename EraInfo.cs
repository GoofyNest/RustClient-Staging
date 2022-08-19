internal class EraInfo // TypeDefIndex: 703
{	// Fields
	internal int era; // 0x10
	internal long ticks; // 0x18
	internal int yearOffset; // 0x20
	internal int minEraYear; // 0x24
	internal int maxEraYear; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B700 Offset: 0x7AB00 VA: 0x18007B700
	internal string eraName; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B700 Offset: 0x7AB00 VA: 0x18007B700
	internal string abbrevEraName; // 0x38
	[OptionalFieldAttribute] // RVA: 0x7B700 Offset: 0x7AB00 VA: 0x18007B700
	internal string englishEraName; // 0x40

	// Methods

	// RVA: 0x16F1E50 Offset: 0x16F0450 VA: 0x1816F1E50
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	// RVA: 0x16F1D80 Offset: 0x16F0380 VA: 0x1816F1D80
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }

}

