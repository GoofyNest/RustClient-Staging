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

	// RVA: 0xDA03A0 Offset: 0xD9E9A0 VA: 0x180DA03A0
	public Sprite get_sprite() { }

	// RVA: 0x15FA100 Offset: 0x15F8700 VA: 0x1815FA100
	public void set_sprite(Sprite value) { }

	// RVA: 0x15F2760 Offset: 0x15F0D60 VA: 0x1815F2760
	public void DisableSpriteOptimizations() { }

	// RVA: 0x15F99E0 Offset: 0x15F7FE0 VA: 0x1815F99E0
	public Sprite get_overrideSprite() { }

	// RVA: 0x15F9FB0 Offset: 0x15F85B0 VA: 0x1815F9FB0
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x15F9350 Offset: 0x15F7950 VA: 0x1815F9350
	private Sprite get_activeSprite() { }

	// RVA: 0x1050730 Offset: 0x104ED30 VA: 0x181050730
	public Image.Type get_type() { }

	// RVA: 0x15FA410 Offset: 0x15F8A10 VA: 0x1815FA410
	public void set_type(Image.Type value) { }

	// RVA: 0x15F9D10 Offset: 0x15F8310 VA: 0x1815F9D10
	public bool get_preserveAspect() { }

	// RVA: 0x15FA090 Offset: 0x15F8690 VA: 0x1815FA090
	public void set_preserveAspect(bool value) { }

	// RVA: 0x15F9500 Offset: 0x15F7B00 VA: 0x1815F9500
	public bool get_fillCenter() { }

	// RVA: 0x15F9DF0 Offset: 0x15F83F0 VA: 0x1815F9DF0
	public void set_fillCenter(bool value) { }

	// RVA: 0x872240 Offset: 0x870840 VA: 0x180872240
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x15F9ED0 Offset: 0x15F84D0 VA: 0x1815F9ED0
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x12DAD60 Offset: 0x12D9360 VA: 0x1812DAD60
	public float get_fillAmount() { }

	// RVA: 0x15F9D50 Offset: 0x15F8350 VA: 0x1815F9D50
	public void set_fillAmount(float value) { }

	// RVA: 0xB0E350 Offset: 0xB0C950 VA: 0x180B0E350
	public bool get_fillClockwise() { }

	// RVA: 0x15F9E60 Offset: 0x15F8460 VA: 0x1815F9E60
	public void set_fillClockwise(bool value) { }

	// RVA: 0x107A0B0 Offset: 0x10786B0 VA: 0x18107A0B0
	public int get_fillOrigin() { }

	// RVA: 0x15F9F40 Offset: 0x15F8540 VA: 0x1815F9F40
	public void set_fillOrigin(int value) { }

	// RVA: 0x15F94E0 Offset: 0x15F7AE0 VA: 0x1815F94E0
	public float get_eventAlphaThreshold() { }

	// RVA: 0x15F9D30 Offset: 0x15F8330 VA: 0x1815F9D30
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x11D5B10 Offset: 0x11D4110 VA: 0x1811D5B10
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x11D5B30 Offset: 0x11D4130 VA: 0x1811D5B30
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x15F9D20 Offset: 0x15F8320 VA: 0x1815F9D20
	public bool get_useSpriteMesh() { }

	// RVA: 0x15FA480 Offset: 0x15F8A80 VA: 0x1815FA480
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x15F92F0 Offset: 0x15F78F0 VA: 0x1815F92F0
	protected void .ctor() { }

	// RVA: 0x15F93E0 Offset: 0x15F79E0 VA: 0x1815F93E0
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x15F95D0 Offset: 0x15F7BD0 VA: 0x1815F95D0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x15F9510 Offset: 0x15F7B10 VA: 0x1815F9510
	public bool get_hasBorder() { }

	// RVA: 0x112C3A0 Offset: 0x112A9A0 VA: 0x18112C3A0
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x15FA020 Offset: 0x15F8620 VA: 0x1815FA020
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x15F99F0 Offset: 0x15F7FF0 VA: 0x1815F99F0
	public float get_pixelsPerUnit() { }

	// RVA: 0x15F99C0 Offset: 0x15F7FC0 VA: 0x1815F99C0
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x15F9770 Offset: 0x15F7D70 VA: 0x1815F9770 Slot: 32
	public override Material get_material() { }

	// RVA: 0x15F0400 Offset: 0x15EEA00 VA: 0x1815F0400 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x15F7820 Offset: 0x15F5E20 VA: 0x1815F7820 Slot: 76
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x15F7D20 Offset: 0x15F6320 VA: 0x1815F7D20
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x15F6AE0 Offset: 0x15F50E0 VA: 0x1815F6AE0
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x15F8A10 Offset: 0x15F7010 VA: 0x1815F8A10 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x15F7C40 Offset: 0x15F6240 VA: 0x1815F7C40 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15F7D00 Offset: 0x15F6300 VA: 0x1815F7D00 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15F7AF0 Offset: 0x15F60F0 VA: 0x1815F7AF0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x15F8DD0 Offset: 0x15F73D0 VA: 0x1815F8DD0
	private void TrackSprite() { }

	// RVA: 0x15F7AD0 Offset: 0x15F60D0 VA: 0x1815F7AD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15F79F0 Offset: 0x15F5FF0 VA: 0x1815F79F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15F9060 Offset: 0x15F7660 VA: 0x1815F9060 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x15F78D0 Offset: 0x15F5ED0 VA: 0x1815F78D0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x15F3E20 Offset: 0x15F2420 VA: 0x1815F3E20
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x15F4B90 Offset: 0x15F3190 VA: 0x1815F4B90
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x15F4150 Offset: 0x15F2750 VA: 0x1815F4150
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x15F5170 Offset: 0x15F3770 VA: 0x1815F5170
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x15F25B0 Offset: 0x15F0BB0 VA: 0x1815F25B0
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x15F2380 Offset: 0x15F0980 VA: 0x1815F2380
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x15F6860 Offset: 0x15F4E60 VA: 0x1815F6860
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x15F2770 Offset: 0x15F0D70 VA: 0x1815F2770
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x15F7F20 Offset: 0x15F6520 VA: 0x1815F7F20
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x15F80B0 Offset: 0x15F66B0 VA: 0x1815F80B0
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 77
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 78
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 79
	public virtual float get_minWidth() { }

	// RVA: 0x15F9BF0 Offset: 0x15F81F0 VA: 0x1815F9BF0 Slot: 80
	public virtual float get_preferredWidth() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 81
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 82
	public virtual float get_minHeight() { }

	// RVA: 0x15F9B00 Offset: 0x15F8100 VA: 0x1815F9B00 Slot: 83
	public virtual float get_preferredHeight() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 84
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 85
	public virtual int get_layoutPriority() { }

	// RVA: 0x15F6F50 Offset: 0x15F5550 VA: 0x1815F6F50 Slot: 86
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x15F7330 Offset: 0x15F5930 VA: 0x1815F7330
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x15F88A0 Offset: 0x15F6EA0 VA: 0x1815F88A0
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x15F8C90 Offset: 0x15F7290 VA: 0x1815F8C90
	private static void TrackImage(Image g) { }

	// RVA: 0x15F8FE0 Offset: 0x15F75E0 VA: 0x1815F8FE0
	private static void UnTrackImage(Image g) { }

	// RVA: 0x15F91B0 Offset: 0x15F77B0 VA: 0x1815F91B0
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

	// RVA: 0x1EA960 Offset: 0x1E9D60 VA: 0x1801EA960
	public Color GetPixel(int x, int y) { }

	// RVA: 0x1EAAF0 Offset: 0x1E9EF0 VA: 0x1801EAAF0 Slot: 3
	public override string ToString() { }

}

