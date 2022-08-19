internal sealed class RegexFC // TypeDefIndex: 2614
{	// Fields
	internal RegexCharClass _cc; // 0x10
	internal bool _nullable; // 0x18
	internal bool _caseInsensitive; // 0x19

	// Methods

	// RVA: 0x14CB8A0 Offset: 0x14C9EA0 VA: 0x1814CB8A0
	internal void .ctor(bool nullable) { }

	// RVA: 0x14CB7A0 Offset: 0x14C9DA0 VA: 0x1814CB7A0
	internal void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x14CB920 Offset: 0x14C9F20 VA: 0x1814CB920
	internal void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x14CB5C0 Offset: 0x14C9BC0 VA: 0x1814CB5C0
	internal bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x14CB650 Offset: 0x14C9C50 VA: 0x1814CB650
	internal string GetFirstChars(CultureInfo culture) { }

	// RVA: 0xFA71A0 Offset: 0xFA57A0 VA: 0x180FA71A0
	internal bool IsCaseInsensitive() { }

}

