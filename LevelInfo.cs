public class LevelInfo : SingletonComponent<LevelInfo> // TypeDefIndex: 9962
{	public string shortName; // 0x18
	public string displayName; // 0x20
	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string description; // 0x28
	[TooltipAttribute] // RVA: 0xAA9A0 Offset: 0xA9DA0 VA: 0x1800AA9A0
	public Texture2D image; // 0x30
	[SpaceAttribute] // RVA: 0xAAA90 Offset: 0xA9E90 VA: 0x1800AAA90
	[TooltipAttribute] // RVA: 0xAAA90 Offset: 0xA9E90 VA: 0x1800AAA90
	public int version; // 0x38


	public void .ctor() { }

}

