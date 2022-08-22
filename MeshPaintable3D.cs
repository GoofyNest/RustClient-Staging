public class MeshPaintable3D : BaseMeshPaintable // TypeDefIndex: 9205
{	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
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

	public override Texture2D TargetTexture { get; set; }
	public override bool HasChanges { get; set; }


	public void OnDestroy() { }

	public override Texture2D get_TargetTexture() { }

	public override void set_TargetTexture(Texture2D value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override bool get_HasChanges() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override void set_HasChanges(bool value) { }

	public override void Init(MeshPaintableSource source, bool isSelected) { }

	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	public override void Clear() { }

	public override void Apply() { }

	public override bool ShouldHit(RaycastHit info) { }

	private void PrepareForDrawing() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct MeshPaintable3D.DrawTextureJob : IJobParallelFor // TypeDefIndex: 9206
{	public int textureWidth; // 0x0
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


	public void Execute(int index) { }

	private float2 SampleUv(float x, float y) { }

	private Color SampleTexture(float x, float y) { }

	private static Color ToColor(float4 color) { }

	private static float4 ToFloat4(Color color) { }

}

