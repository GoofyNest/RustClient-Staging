public class MeshPaintable3D : BaseMeshPaintable // TypeDefIndex: 9205
{	// Fields
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static float brushScale; // 0x0
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <HasChanges>k__BackingField; // 0x7C

	// Properties
	public override Texture2D TargetTexture { get; set; }
	public override bool HasChanges { get; set; }

	// Methods

	// RVA: 0x965810 Offset: 0x963E10 VA: 0x180965810
	public void OnDestroy() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 4
	public override Texture2D get_TargetTexture() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330 Slot: 5
	public override void set_TargetTexture(Texture2D value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x9660F0 Offset: 0x9646F0 VA: 0x1809660F0 Slot: 6
	public override bool get_HasChanges() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x966100 Offset: 0x964700 VA: 0x180966100 Slot: 7
	public override void set_HasChanges(bool value) { }

	// RVA: 0x965190 Offset: 0x963790 VA: 0x180965190 Slot: 8
	public override void Init(MeshPaintableSource source, bool isSelected) { }

	// RVA: 0x964B50 Offset: 0x963150 VA: 0x180964B50 Slot: 11
	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	// RVA: 0x964A70 Offset: 0x963070 VA: 0x180964A70 Slot: 9
	public override void Clear() { }

	// RVA: 0x9649D0 Offset: 0x962FD0 VA: 0x1809649D0 Slot: 10
	public override void Apply() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool ShouldHit(RaycastHit info) { }

	// RVA: 0x965A30 Offset: 0x964030 VA: 0x180965A30
	private void PrepareForDrawing() { }

	// RVA: 0x966070 Offset: 0x964670 VA: 0x180966070
	public void .ctor() { }

	// RVA: 0x966020 Offset: 0x964620 VA: 0x180966020
	private static void .cctor() { }

}

private struct MeshPaintable3D.DrawTextureJob : IJobParallelFor // TypeDefIndex: 9206
{	// Fields
	public int textureWidth; // 0x0
	public int2 textureMaxPos; // 0x4
	[ReadOnlyAttribute] // RVA: 0xD9BC0 Offset: 0xD8FC0 VA: 0x1800D9BC0
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0xD9BC0 Offset: 0xD8FC0 VA: 0x1800D9BC0
	public NativeArray<Color32> textureData; // 0x10
	public Color textureColor; // 0x20
	public float textureScaleX; // 0x30
	public float textureScaleY; // 0x34
	public int uvWidth; // 0x38
	public int2 uvMaxPos; // 0x3C
	[ReadOnlyAttribute] // RVA: 0xD9BC0 Offset: 0xD8FC0 VA: 0x1800D9BC0
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0xD9BC0 Offset: 0xD8FC0 VA: 0x1800D9BC0
	public NativeArray<half2> uvData; // 0x48
	public int paintWidth; // 0x58
	public int paintHeight; // 0x5C
	[ReadOnlyAttribute] // RVA: 0xD9E30 Offset: 0xD9230 VA: 0x1800D9E30
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0xD9E30 Offset: 0xD9230 VA: 0x1800D9E30
	[DeallocateOnJobCompletionAttribute] // RVA: 0xD9E30 Offset: 0xD9230 VA: 0x1800D9E30
	public NativeArray<Color32> paintDataCurrent; // 0x60
	[WriteOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	public NativeArray<Color32> paintDataNew; // 0x70
	public int startX; // 0x80
	public int startY; // 0x84
	public int endX; // 0x88
	public RectInt areaClamp; // 0x8C
	public bool isPaintBrush; // 0x9C

	// Methods

	// RVA: 0xFA7C0 Offset: 0xF9BC0 VA: 0x1800FA7C0 Slot: 4
	public void Execute(int index) { }

	// RVA: 0xFA800 Offset: 0xF9C00 VA: 0x1800FA800
	private float2 SampleUv(float x, float y) { }

	// RVA: 0xFA7D0 Offset: 0xF9BD0 VA: 0x1800FA7D0
	private Color SampleTexture(float x, float y) { }

	// RVA: 0x957A70 Offset: 0x956070 VA: 0x180957A70
	private static Color ToColor(float4 color) { }

	// RVA: 0x957AB0 Offset: 0x9560B0 VA: 0x180957AB0
	private static float4 ToFloat4(Color color) { }

}

