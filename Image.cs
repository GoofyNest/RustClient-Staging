public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 4938
{	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0xEC580 Offset: 0xEB980 VA: 0x1800EC580
	[SerializeField] // RVA: 0xEC580 Offset: 0xEB980 VA: 0x1800EC580
	private Sprite m_Sprite; // 0xC8
	private Sprite m_OverrideSprite; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image.Type m_Type; // 0xD8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_PreserveAspect; // 0xDC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_FillCenter; // 0xDD
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image.FillMethod m_FillMethod; // 0xE0
	[RangeAttribute] // RVA: 0x79E20 Offset: 0x79220 VA: 0x180079E20
	[SerializeField] // RVA: 0x79E20 Offset: 0x79220 VA: 0x180079E20
	private float m_FillAmount; // 0xE4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_FillClockwise; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_FillOrigin; // 0xEC
	private float m_AlphaHitTestMinimumThreshold; // 0xF0
	private bool m_Tracked; // 0xF4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_UseSpriteMesh; // 0xF5
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_PixelsPerUnitMultiplier; // 0xF8
	private float m_CachedReferencePixelsPerUnit; // 0xFC
	private static readonly Vector2[] s_VertScratch; // 0x8
	private static readonly Vector2[] s_UVScratch; // 0x10
	private static readonly Vector3[] s_Xy; // 0x18
	private static readonly Vector3[] s_Uv; // 0x20
	private static List<Image> m_TrackedTexturelessImages; // 0x28
	private static bool s_Initialized; // 0x30

	// Properties
	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	private Sprite activeSprite { get; }
	public Image.Type type { get; set; }
	public bool preserveAspect { get; set; }
	public bool fillCenter { get; set; }
	public Image.FillMethod fillMethod { get; set; }
	public float fillAmount { get; set; }
	public bool fillClockwise { get; set; }
	public int fillOrigin { get; set; }
	[ObsoleteAttribute] // RVA: 0xECAB0 Offset: 0xEBEB0 VA: 0x1800ECAB0
	public float eventAlphaThreshold { get; set; }
	public float alphaHitTestMinimumThreshold { get; set; }
	public bool useSpriteMesh { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnitMultiplier { get; set; }
	public float pixelsPerUnit { get; }
	protected float multipliedPixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0xDA0E50 Offset: 0xD9F450 VA: 0x180DA0E50
	public Sprite get_sprite() { }

	// RVA: 0x15E7420 Offset: 0x15E5A20 VA: 0x1815E7420
	public void set_sprite(Sprite value) { }

	// RVA: 0x15DFA80 Offset: 0x15DE080 VA: 0x1815DFA80
	public void DisableSpriteOptimizations() { }

	// RVA: 0x15E6D00 Offset: 0x15E5300 VA: 0x1815E6D00
	public Sprite get_overrideSprite() { }

	// RVA: 0x15E72D0 Offset: 0x15E58D0 VA: 0x1815E72D0
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x15E6670 Offset: 0x15E4C70 VA: 0x1815E6670
	private Sprite get_activeSprite() { }

	// RVA: 0x10511C0 Offset: 0x104F7C0 VA: 0x1810511C0
	public Image.Type get_type() { }

	// RVA: 0x15E7730 Offset: 0x15E5D30 VA: 0x1815E7730
	public void set_type(Image.Type value) { }

	// RVA: 0x15E7030 Offset: 0x15E5630 VA: 0x1815E7030
	public bool get_preserveAspect() { }

	// RVA: 0x15E73B0 Offset: 0x15E59B0 VA: 0x1815E73B0
	public void set_preserveAspect(bool value) { }

	// RVA: 0x15E6820 Offset: 0x15E4E20 VA: 0x1815E6820
	public bool get_fillCenter() { }

	// RVA: 0x15E7110 Offset: 0x15E5710 VA: 0x1815E7110
	public void set_fillCenter(bool value) { }

	// RVA: 0x88D960 Offset: 0x88BF60 VA: 0x18088D960
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x15E71F0 Offset: 0x15E57F0 VA: 0x1815E71F0
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x12E1210 Offset: 0x12DF810 VA: 0x1812E1210
	public float get_fillAmount() { }

	// RVA: 0x15E7070 Offset: 0x15E5670 VA: 0x1815E7070
	public void set_fillAmount(float value) { }

	// RVA: 0xB0E820 Offset: 0xB0CE20 VA: 0x180B0E820
	public bool get_fillClockwise() { }

	// RVA: 0x15E7180 Offset: 0x15E5780 VA: 0x1815E7180
	public void set_fillClockwise(bool value) { }

	// RVA: 0x107AB20 Offset: 0x1079120 VA: 0x18107AB20
	public int get_fillOrigin() { }

	// RVA: 0x15E7260 Offset: 0x15E5860 VA: 0x1815E7260
	public void set_fillOrigin(int value) { }

	// RVA: 0x15E6800 Offset: 0x15E4E00 VA: 0x1815E6800
	public float get_eventAlphaThreshold() { }

	// RVA: 0x15E7050 Offset: 0x15E5650 VA: 0x1815E7050
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x11D61B0 Offset: 0x11D47B0 VA: 0x1811D61B0
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x11D61D0 Offset: 0x11D47D0 VA: 0x1811D61D0
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x15E7040 Offset: 0x15E5640 VA: 0x1815E7040
	public bool get_useSpriteMesh() { }

	// RVA: 0x15E77A0 Offset: 0x15E5DA0 VA: 0x1815E77A0
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x15E6610 Offset: 0x15E4C10 VA: 0x1815E6610
	protected void .ctor() { }

	// RVA: 0x15E6700 Offset: 0x15E4D00 VA: 0x1815E6700
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x15E68F0 Offset: 0x15E4EF0 VA: 0x1815E68F0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x15E6830 Offset: 0x15E4E30 VA: 0x1815E6830
	public bool get_hasBorder() { }

	// RVA: 0x112CE10 Offset: 0x112B410 VA: 0x18112CE10
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x15E7340 Offset: 0x15E5940 VA: 0x1815E7340
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x15E6D10 Offset: 0x15E5310 VA: 0x1815E6D10
	public float get_pixelsPerUnit() { }

	// RVA: 0x15E6CE0 Offset: 0x15E52E0 VA: 0x1815E6CE0
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x15E6A90 Offset: 0x15E5090 VA: 0x1815E6A90 Slot: 32
	public override Material get_material() { }

	// RVA: 0x15DD720 Offset: 0x15DBD20 VA: 0x1815DD720 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x15E4B40 Offset: 0x15E3140 VA: 0x1815E4B40 Slot: 76
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x15E5040 Offset: 0x15E3640 VA: 0x1815E5040
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x15E3E00 Offset: 0x15E2400 VA: 0x1815E3E00
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x15E5D30 Offset: 0x15E4330 VA: 0x1815E5D30 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x15E4F60 Offset: 0x15E3560 VA: 0x1815E4F60 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15E5020 Offset: 0x15E3620 VA: 0x1815E5020 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15E4E10 Offset: 0x15E3410 VA: 0x1815E4E10 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x15E60F0 Offset: 0x15E46F0 VA: 0x1815E60F0
	private void TrackSprite() { }

	// RVA: 0x15E4DF0 Offset: 0x15E33F0 VA: 0x1815E4DF0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15E4D10 Offset: 0x15E3310 VA: 0x1815E4D10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15E6380 Offset: 0x15E4980 VA: 0x1815E6380 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x15E4BF0 Offset: 0x15E31F0 VA: 0x1815E4BF0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x15E1140 Offset: 0x15DF740 VA: 0x1815E1140
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x15E1EB0 Offset: 0x15E04B0 VA: 0x1815E1EB0
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x15E1470 Offset: 0x15DFA70 VA: 0x1815E1470
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x15E2490 Offset: 0x15E0A90 VA: 0x1815E2490
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x15DF8D0 Offset: 0x15DDED0 VA: 0x1815DF8D0
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x15DF6A0 Offset: 0x15DDCA0 VA: 0x1815DF6A0
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x15E3B80 Offset: 0x15E2180 VA: 0x1815E3B80
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x15DFA90 Offset: 0x15DE090 VA: 0x1815DFA90
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x15E5240 Offset: 0x15E3840 VA: 0x1815E5240
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x15E53D0 Offset: 0x15E39D0 VA: 0x1815E53D0
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 77
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 78
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 79
	public virtual float get_minWidth() { }

	// RVA: 0x15E6F10 Offset: 0x15E5510 VA: 0x1815E6F10 Slot: 80
	public virtual float get_preferredWidth() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 81
	public virtual float get_flexibleWidth() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 82
	public virtual float get_minHeight() { }

	// RVA: 0x15E6E20 Offset: 0x15E5420 VA: 0x1815E6E20 Slot: 83
	public virtual float get_preferredHeight() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 84
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 85
	public virtual int get_layoutPriority() { }

	// RVA: 0x15E4270 Offset: 0x15E2870 VA: 0x1815E4270 Slot: 86
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x15E4650 Offset: 0x15E2C50 VA: 0x1815E4650
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x15E5BC0 Offset: 0x15E41C0 VA: 0x1815E5BC0
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x15E5FB0 Offset: 0x15E45B0 VA: 0x1815E5FB0
	private static void TrackImage(Image g) { }

	// RVA: 0x15E6300 Offset: 0x15E4900 VA: 0x1815E6300
	private static void UnTrackImage(Image g) { }

	// RVA: 0x15E64D0 Offset: 0x15E4AD0 VA: 0x1815E64D0
	private static void .cctor() { }

}

public enum Image.Type // TypeDefIndex: 4939
{	// Fields
	public int value__; // 0x0
	public const Image.Type Simple = 0;
	public const Image.Type Sliced = 1;
	public const Image.Type Tiled = 2;
	public const Image.Type Filled = 3;

}

public enum Image.FillMethod // TypeDefIndex: 4940
{	// Fields
	public int value__; // 0x0
	public const Image.FillMethod Horizontal = 0;
	public const Image.FillMethod Vertical = 1;
	public const Image.FillMethod Radial90 = 2;
	public const Image.FillMethod Radial180 = 3;
	public const Image.FillMethod Radial360 = 4;

}

public enum Image.OriginHorizontal // TypeDefIndex: 4941
{	// Fields
	public int value__; // 0x0
	public const Image.OriginHorizontal Left = 0;
	public const Image.OriginHorizontal Right = 1;

}

public enum Image.OriginVertical // TypeDefIndex: 4942
{	// Fields
	public int value__; // 0x0
	public const Image.OriginVertical Bottom = 0;
	public const Image.OriginVertical Top = 1;

}

public enum Image.Origin90 // TypeDefIndex: 4943
{	// Fields
	public int value__; // 0x0
	public const Image.Origin90 BottomLeft = 0;
	public const Image.Origin90 TopLeft = 1;
	public const Image.Origin90 TopRight = 2;
	public const Image.Origin90 BottomRight = 3;

}

public enum Image.Origin180 // TypeDefIndex: 4944
{	// Fields
	public int value__; // 0x0
	public const Image.Origin180 Bottom = 0;
	public const Image.Origin180 Left = 1;
	public const Image.Origin180 Top = 2;
	public const Image.Origin180 Right = 3;

}

public enum Image.Origin360 // TypeDefIndex: 4945
{	// Fields
	public int value__; // 0x0
	public const Image.Origin360 Bottom = 0;
	public const Image.Origin360 Right = 1;
	public const Image.Origin360 Top = 2;
	public const Image.Origin360 Left = 3;

}

public struct Image // TypeDefIndex: 5551
{	// Fields
	public uint Width; // 0x0
	public uint Height; // 0x4
	public byte[] Data; // 0x8

	// Methods

	// RVA: 0x1EAD80 Offset: 0x1EA180 VA: 0x1801EAD80
	public Color GetPixel(int x, int y) { }

	// RVA: 0x1EAF10 Offset: 0x1EA310 VA: 0x1801EAF10 Slot: 3
	public override string ToString() { }

}

