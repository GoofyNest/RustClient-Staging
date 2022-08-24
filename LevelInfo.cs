public class LevelInfo : SingletonComponent<LevelInfo> // TypeDefIndex: 9962
{	public string shortName; // 0x18
	public string displayName; // 0x20
	[TextAreaAttribute] // RVA: 0x72390 Offset: 0x71790 VA: 0x180072390
	public string description; // 0x28
	[TooltipAttribute] // RVA: 0xAA4F0 Offset: 0xA98F0 VA: 0x1800AA4F0
	public Texture2D image; // 0x30
	[SpaceAttribute] // RVA: 0xAA5B0 Offset: 0xA99B0 VA: 0x1800AA5B0
	[TooltipAttribute] // RVA: 0xAA5B0 Offset: 0xA99B0 VA: 0x1800AA5B0
	public int version; // 0x38


	public void .ctor() { }

}

