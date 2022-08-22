public class TextureSampler // TypeDefIndex: 5613
{	// Fields
	private Color[] _data; // 0x10
	private int _height; // 0x18
	private int _width; // 0x1C

	// Methods

	// RVA: 0x19A39D0 Offset: 0x19A1FD0 VA: 0x1819A39D0
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x19A3DF0 Offset: 0x19A23F0 VA: 0x1819A3DF0
	public Color GetPixel(float x, float y) { }

	// RVA: 0x19A3EB0 Offset: 0x19A24B0 VA: 0x1819A3EB0
	private float Mod(float x, float y) { }

	// RVA: 0x19A3F30 Offset: 0x19A2530 VA: 0x1819A3F30
	private float WrapBetween(float value, float min, float max) { }

	// RVA: 0x19A3FD0 Offset: 0x19A25D0 VA: 0x1819A3FD0
	public void .ctor(Texture2D source) { }

}

