public static class MapImageRenderer // TypeDefIndex: 10745
{	// Fields
	private static readonly Vector3 StartColor; // 0x0
	private static readonly Vector4 WaterColor; // 0xC
	private static readonly Vector4 GravelColor; // 0x1C
	private static readonly Vector4 DirtColor; // 0x2C
	private static readonly Vector4 SandColor; // 0x3C
	private static readonly Vector4 GrassColor; // 0x4C
	private static readonly Vector4 ForestColor; // 0x5C
	private static readonly Vector4 RockColor; // 0x6C
	private static readonly Vector4 SnowColor; // 0x7C
	private static readonly Vector4 PebbleColor; // 0x8C
	private static readonly Vector4 OffShoreColor; // 0x9C
	private static readonly Vector3 SunDirection; // 0xAC
	private const float SunPower = 0,65;
	private const float Brightness = 1,05;
	private const float Contrast = 0,94;
	private const float OceanWaterLevel = 0;
	private static readonly Vector3 Half; // 0xB8

	// Methods

	// RVA: 0x563560 Offset: 0x561B60 VA: 0x180563560
	public static byte[] Render(out int imageWidth, out int imageHeight, out Color background, float scale = 0,5, bool lossy = True) { }

	// RVA: 0x5633D0 Offset: 0x5619D0 VA: 0x1805633D0
	private static byte[] EncodeToFile(int width, int height, Color[] pixels, bool lossy) { }

	// RVA: 0x5639F0 Offset: 0x561FF0 VA: 0x1805639F0
	private static Vector3 UnpackNormal(Vector4 value) { }

	// RVA: 0x563B30 Offset: 0x562130 VA: 0x180563B30
	private static void .cctor() { }

}

private struct MapImageRenderer.Array2D<T> // TypeDefIndex: 10746
{	// Fields
	private readonly T[] _items; // 0x0
	private readonly int _width; // 0x0
	private readonly int _height; // 0x0

	// Properties
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] items, int width, int height) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF9120 Offset: 0xF8520 VA: 0x1800F9120
	|-MapImageRenderer.Array2D<object>..ctor
	|-MapImageRenderer.Array2D<Color>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int x, int y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F6140 Offset: 0x1F5540 VA: 0x1801F6140
	|-MapImageRenderer.Array2D<object>.get_Item
	|
	|-RVA: 0x1F6070 Offset: 0x1F5470 VA: 0x1801F6070
	|-MapImageRenderer.Array2D<Color>.get_Item
	*/

}

private sealed class MapImageRenderer.<>c__DisplayClass17_0 // TypeDefIndex: 10747
{	// Fields
	public TerrainHeightMap terrainHeightMap; // 0x10
	public TerrainSplatMap terrainSplatMap; // 0x18
	public float invMapRes; // 0x20
	public int mapRes; // 0x24
	public MapImageRenderer.Array2D<Color> output; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x56F8C0 Offset: 0x56DEC0 VA: 0x18056F8C0
	internal float <Render>g__GetHeight|0(float x, float y) { }

	// RVA: 0x56F8E0 Offset: 0x56DEE0 VA: 0x18056F8E0
	internal Vector3 <Render>g__GetNormal|1(float x, float y) { }

	// RVA: 0x56F930 Offset: 0x56DF30 VA: 0x18056F930
	internal float <Render>g__GetSplat|2(float x, float y, int mask) { }

	// RVA: 0x56ECE0 Offset: 0x56D2E0 VA: 0x18056ECE0
	internal void <Render>b__3(int y) { }

}

