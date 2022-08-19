public enum Mouse.RZLED // TypeDefIndex: 7656
{
// Namespace: 
public enum Mouse.RZLED // TypeDefIndex: 7656
	// Fields
	public int value__; // 0x0
	public const Mouse.RZLED RZLED_NONE = 0;
	public const Mouse.RZLED RZLED_SCROLLWHEEL = 1;
	public const Mouse.RZLED RZLED_LOGO = 2;
	public const Mouse.RZLED RZLED_BACKLIGHT = 3;
	public const Mouse.RZLED RZLED_SIDE_STRIP1 = 4;
	public const Mouse.RZLED RZLED_SIDE_STRIP2 = 5;
	public const Mouse.RZLED RZLED_SIDE_STRIP3 = 6;
	public const Mouse.RZLED RZLED_SIDE_STRIP4 = 7;
	public const Mouse.RZLED RZLED_SIDE_STRIP5 = 8;
	public const Mouse.RZLED RZLED_SIDE_STRIP6 = 9;
	public const Mouse.RZLED RZLED_SIDE_STRIP7 = 10;
	public const Mouse.RZLED RZLED_SIDE_STRIP8 = 11;
	public const Mouse.RZLED RZLED_SIDE_STRIP9 = 12;
	public const Mouse.RZLED RZLED_SIDE_STRIP10 = 13;
	public const Mouse.RZLED RZLED_SIDE_STRIP11 = 14;
	public const Mouse.RZLED RZLED_SIDE_STRIP12 = 15;
	public const Mouse.RZLED RZLED_SIDE_STRIP13 = 16;
	public const Mouse.RZLED RZLED_SIDE_STRIP14 = 17;
	public const Mouse.RZLED RZLED_ALL = 65535;

}

public enum Mouse.EFFECT_TYPE // TypeDefIndex: 7657
{	// Fields
	public int value__; // 0x0
	public const Mouse.EFFECT_TYPE CHROMA_NONE = 0;
	public const Mouse.EFFECT_TYPE CHROMA_BLINKING = 1;
	public const Mouse.EFFECT_TYPE CHROMA_BREATHING = 2;
	public const Mouse.EFFECT_TYPE CHROMA_CUSTOM = 3;
	public const Mouse.EFFECT_TYPE CHROMA_REACTIVE = 4;
	public const Mouse.EFFECT_TYPE CHROMA_SPECTRUMCYCLING = 5;
	public const Mouse.EFFECT_TYPE CHROMA_STATIC = 6;
	public const Mouse.EFFECT_TYPE CHROMA_WAVE = 7;
	public const Mouse.EFFECT_TYPE CHROMA_CUSTOM2 = 8;
	public const Mouse.EFFECT_TYPE CHROMA_INVALID = 9;

}

public struct Mouse.STATIC_EFFECT_TYPE // TypeDefIndex: 7658
{	// Fields
	public Mouse.RZLED LEDId; // 0x0
	public int Color; // 0x4

}

