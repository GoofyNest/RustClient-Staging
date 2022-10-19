public class LevelInfo : SingletonComponent<LevelInfo> // TypeDefIndex: 11685
{
	public string shortName; 
	public string displayName; 
	[TextAreaAttribute] 
	public string description; 
	[TooltipAttribute] 
	public Texture2D image; 
	[SpaceAttribute] 
	[TooltipAttribute] 
	public int version; 


	public void .ctor() { }

}

