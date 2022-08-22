public class TextureSampler // TypeDefIndex: 5613
{	// Fields
	private Color[] _data; // 0x10
	private int _height; // 0x18
	private int _width; // 0x1C

	// Methods

	// RVA: 0x19A3C90 Offset: 0x19A2290 VA: 0x1819A3C90
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x19A40B0 Offset: 0x19A26B0 VA: 0x1819A40B0
	public Color GetPixel(float x, float y) { }

	// RVA: 0x19A4170 Offset: 0x19A2770 VA: 0x1819A4170
	private float Mod(float x, float y) { }

	// RVA: 0x19A41F0 Offset: 0x19A27F0 VA: 0x1819A41F0
	private float WrapBetween(float value, float min, float max) { }

	// RVA: 0x19A4290 Offset: 0x19A2890 VA: 0x1819A4290
	public void .ctor(Texture2D source) { }

}

