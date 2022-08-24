public class LevelInfo : SingletonComponent<LevelInfo> // TypeDefIndex: 9962
{	public string shortName; // 0x18
	public string displayName; // 0x20
	[TextAreaAttribute] // RVA: 0x72220 Offset: 0x71620 VA: 0x180072220
	public string description; // 0x28
	[TooltipAttribute] // RVA: 0xAAA30 Offset: 0xA9E30 VA: 0x1800AAA30
	public Texture2D image; // 0x30
	[SpaceAttribute] // RVA: 0xAAB30 Offset: 0xA9F30 VA: 0x1800AAB30
	[TooltipAttribute] // RVA: 0xAAB30 Offset: 0xA9F30 VA: 0x1800AAB30
	public int version; // 0x38


	public void .ctor() { }

}

