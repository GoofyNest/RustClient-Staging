internal class EraInfo // TypeDefIndex: 703
{	// Fields
	internal int era; // 0x10
	internal long ticks; // 0x18
	internal int yearOffset; // 0x20
	internal int minEraYear; // 0x24
	internal int maxEraYear; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B710 Offset: 0x7AB10 VA: 0x18007B710
	internal string eraName; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B710 Offset: 0x7AB10 VA: 0x18007B710
	internal string abbrevEraName; // 0x38
	[OptionalFieldAttribute] // RVA: 0x7B710 Offset: 0x7AB10 VA: 0x18007B710
	internal string englishEraName; // 0x40

	// Methods

	// RVA: 0x16EFD00 Offset: 0x16EE300 VA: 0x1816EFD00
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	// RVA: 0x16EFC30 Offset: 0x16EE230 VA: 0x1816EFC30
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }

}

