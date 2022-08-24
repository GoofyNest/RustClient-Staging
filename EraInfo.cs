internal class EraInfo // TypeDefIndex: 703
{	internal int era; // 0x10
	internal long ticks; // 0x18
	internal int yearOffset; // 0x20
	internal int minEraYear; // 0x24
	internal int maxEraYear; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B780 Offset: 0x7AB80 VA: 0x18007B780
	internal string eraName; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B780 Offset: 0x7AB80 VA: 0x18007B780
	internal string abbrevEraName; // 0x38
	[OptionalFieldAttribute] // RVA: 0x7B780 Offset: 0x7AB80 VA: 0x18007B780
	internal string englishEraName; // 0x40


	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }

}

