internal sealed class RegexFC // TypeDefIndex: 2614
{	// Fields
	internal RegexCharClass _cc; // 0x10
	internal bool _nullable; // 0x18
	internal bool _caseInsensitive; // 0x19

	// Methods

	// RVA: 0x14CAC30 Offset: 0x14C9230 VA: 0x1814CAC30
	internal void .ctor(bool nullable) { }

	// RVA: 0x14CAB30 Offset: 0x14C9130 VA: 0x1814CAB30
	internal void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x14CACB0 Offset: 0x14C92B0 VA: 0x1814CACB0
	internal void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x14CA950 Offset: 0x14C8F50 VA: 0x1814CA950
	internal bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x14CA9E0 Offset: 0x14C8FE0 VA: 0x1814CA9E0
	internal string GetFirstChars(CultureInfo culture) { }

	// RVA: 0xFA7F00 Offset: 0xFA6500 VA: 0x180FA7F00
	internal bool IsCaseInsensitive() { }

}

