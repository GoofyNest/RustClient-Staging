internal sealed class RegexFC // TypeDefIndex: 2614
{	// Fields
	internal RegexCharClass _cc; // 0x10
	internal bool _nullable; // 0x18
	internal bool _caseInsensitive; // 0x19

	// Methods

	// RVA: 0x14CBB60 Offset: 0x14CA160 VA: 0x1814CBB60
	internal void .ctor(bool nullable) { }

	// RVA: 0x14CBA60 Offset: 0x14CA060 VA: 0x1814CBA60
	internal void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x14CBBE0 Offset: 0x14CA1E0 VA: 0x1814CBBE0
	internal void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x14CB880 Offset: 0x14C9E80 VA: 0x1814CB880
	internal bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x14CB910 Offset: 0x14C9F10 VA: 0x1814CB910
	internal string GetFirstChars(CultureInfo culture) { }

	// RVA: 0xFA7460 Offset: 0xFA5A60 VA: 0x180FA7460
	internal bool IsCaseInsensitive() { }

}

