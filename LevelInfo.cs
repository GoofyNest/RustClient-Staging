public class LevelInfo : SingletonComponent<LevelInfo> // TypeDefIndex: 9962
{	// Fields
	public string shortName; // 0x18
	public string displayName; // 0x20
	[TextAreaAttribute] // RVA: 0x72110 Offset: 0x71510 VA: 0x180072110
	public string description; // 0x28
	[TooltipAttribute] // RVA: 0xAA8D0 Offset: 0xA9CD0 VA: 0x1800AA8D0
	public Texture2D image; // 0x30
	[SpaceAttribute] // RVA: 0xAA960 Offset: 0xA9D60 VA: 0x1800AA960
	[TooltipAttribute] // RVA: 0xAA960 Offset: 0xA9D60 VA: 0x1800AA960
	public int version; // 0x38

	// Methods

	// RVA: 0x68BD70 Offset: 0x68A370 VA: 0x18068BD70
	public void .ctor() { }

}

