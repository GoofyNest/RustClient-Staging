public class MeshPaintable3D : BaseMeshPaintable // TypeDefIndex: 9205
{	// Fields
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float brushScale; // 0x0
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float uvBufferScale; // 0x4
	public string replacementTextureName; // 0x18
	public int textureWidth; // 0x20
	public int textureHeight; // 0x24
	public Camera cameraPreview; // 0x28
	public Camera camera3D; // 0x30
	private CommandBuffer _commandBuffer; // 0x38
	private Material _uvMaterial; // 0x40
	private RenderTexture _uvBuffer; // 0x48
	private float _uvFactor; // 0x50
	private Texture2D _uvTexture; // 0x58
	private Texture2D _paintTexture; // 0x60
	private int _lastDrawTime; // 0x68
	private RectInt _areaClamp; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <HasChanges>k__BackingField; // 0x7C

	// Properties
	public override Texture2D TargetTexture { get; set; }
	public override bool HasChanges { get; set; }

	// Methods

	// RVA: 0x965E20 Offset: 0x964420 VA: 0x180965E20
	public void OnDestroy() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0 Slot: 4
	public override Texture2D get_TargetTexture() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0 Slot: 5
	public override void set_TargetTexture(Texture2D value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x966700 Offset: 0x964D00 VA: 0x180966700 Slot: 6
	public override bool get_HasChanges() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x966710 Offset: 0x964D10 VA: 0x180966710 Slot: 7
	public override void set_HasChanges(bool value) { }

	// RVA: 0x9657A0 Offset: 0x963DA0 VA: 0x1809657A0 Slot: 8
	public override void Init(MeshPaintableSource source, bool isSelected) { }

	// RVA: 0x965160 Offset: 0x963760 VA: 0x180965160 Slot: 11
	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	// RVA: 0x965080 Offset: 0x963680 VA: 0x180965080 Slot: 9
	public override void Clear() { }

	// RVA: 0x964FE0 Offset: 0x9635E0 VA: 0x180964FE0 Slot: 10
	public override void Apply() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 12
	public override bool ShouldHit(RaycastHit info) { }

	// RVA: 0x966040 Offset: 0x964640 VA: 0x180966040
	private void PrepareForDrawing() { }

	// RVA: 0x966680 Offset: 0x964C80 VA: 0x180966680
	public void .ctor() { }

	// RVA: 0x966630 Offset: 0x964C30 VA: 0x180966630
	private static void .cctor() { }

}

private struct MeshPaintable3D.DrawTextureJob : IJobParallelFor // TypeDefIndex: 9206
{	// Fields
	public int textureWidth; // 0x0
	public int2 textureMaxPos; // 0x4
	[ReadOnlyAttribute] // RVA: 0xD9BD0 Offset: 0xD8FD0 VA: 0x1800D9BD0
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0xD9BD0 Offset: 0xD8FD0 VA: 0x1800D9BD0
	public NativeArray<Color32> textureData; // 0x10
	public Color textureColor; // 0x20
	public float textureScaleX; // 0x30
	public float textureScaleY; // 0x34
	public int uvWidth; // 0x38
	public int2 uvMaxPos; // 0x3C
	[ReadOnlyAttribute] // RVA: 0xD9BD0 Offset: 0xD8FD0 VA: 0x1800D9BD0
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0xD9BD0 Offset: 0xD8FD0 VA: 0x1800D9BD0
	public NativeArray<half2> uvData; // 0x48
	public int paintWidth; // 0x58
	public int paintHeight; // 0x5C
	[ReadOnlyAttribute] // RVA: 0xD9EF0 Offset: 0xD92F0 VA: 0x1800D9EF0
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0xD9EF0 Offset: 0xD92F0 VA: 0x1800D9EF0
	[DeallocateOnJobCompletionAttribute] // RVA: 0xD9EF0 Offset: 0xD92F0 VA: 0x1800D9EF0
	public NativeArray<Color32> paintDataCurrent; // 0x60
	[WriteOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	public NativeArray<Color32> paintDataNew; // 0x70
	public int startX; // 0x80
	public int startY; // 0x84
	public int endX; // 0x88
	public RectInt areaClamp; // 0x8C
	public bool isPaintBrush; // 0x9C

	// Methods

	// RVA: 0xFA740 Offset: 0xF9B40 VA: 0x1800FA740 Slot: 4
	public void Execute(int index) { }

	// RVA: 0xFA780 Offset: 0xF9B80 VA: 0x1800FA780
	private float2 SampleUv(float x, float y) { }

	// RVA: 0xFA750 Offset: 0xF9B50 VA: 0x1800FA750
	private Color SampleTexture(float x, float y) { }

	// RVA: 0x958080 Offset: 0x956680 VA: 0x180958080
	private static Color ToColor(float4 color) { }

	// RVA: 0x9580C0 Offset: 0x9566C0 VA: 0x1809580C0
	private static float4 ToFloat4(Color color) { }

}

