public class TextureSampler // TypeDefIndex: 5613
{	// Fields
	private Color[] _data; // 0x10
	private int _height; // 0x18
	private int _width; // 0x1C

	// Methods

	// RVA: 0x19A3A10 Offset: 0x19A2010 VA: 0x1819A3A10
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x19A3E30 Offset: 0x19A2430 VA: 0x1819A3E30
	public Color GetPixel(float x, float y) { }

	// RVA: 0x19A3EF0 Offset: 0x19A24F0 VA: 0x1819A3EF0
	private float Mod(float x, float y) { }

	// RVA: 0x19A3F70 Offset: 0x19A2570 VA: 0x1819A3F70
	private float WrapBetween(float value, float min, float max) { }

	// RVA: 0x19A4010 Offset: 0x19A2610 VA: 0x1819A4010
	public void .ctor(Texture2D source) { }

}

