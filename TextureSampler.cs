public class TextureSampler // TypeDefIndex: 5613
{	// Fields
	private Color[] _data; // 0x10
	private int _height; // 0x18
	private int _width; // 0x1C

	// Methods

	// RVA: 0x1991090 Offset: 0x198F690 VA: 0x181991090
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x19914B0 Offset: 0x198FAB0 VA: 0x1819914B0
	public Color GetPixel(float x, float y) { }

	// RVA: 0x1991570 Offset: 0x198FB70 VA: 0x181991570
	private float Mod(float x, float y) { }

	// RVA: 0x19915F0 Offset: 0x198FBF0 VA: 0x1819915F0
	private float WrapBetween(float value, float min, float max) { }

	// RVA: 0x1991690 Offset: 0x198FC90 VA: 0x181991690
	public void .ctor(Texture2D source) { }

}

