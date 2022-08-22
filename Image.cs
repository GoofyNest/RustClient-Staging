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

	// RVA: 0xDA00E0 Offset: 0xD9E6E0 VA: 0x180DA00E0
	public Sprite get_sprite() { }

	// RVA: 0x15F9E40 Offset: 0x15F8440 VA: 0x1815F9E40
	public void set_sprite(Sprite value) { }

	// RVA: 0x15F24A0 Offset: 0x15F0AA0 VA: 0x1815F24A0
	public void DisableSpriteOptimizations() { }

	// RVA: 0x15F9720 Offset: 0x15F7D20 VA: 0x1815F9720
	public Sprite get_overrideSprite() { }

	// RVA: 0x15F9CF0 Offset: 0x15F82F0 VA: 0x1815F9CF0
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x15F9090 Offset: 0x15F7690 VA: 0x1815F9090
	private Sprite get_activeSprite() { }

	// RVA: 0x1050470 Offset: 0x104EA70 VA: 0x181050470
	public Image.Type get_type() { }

	// RVA: 0x15FA150 Offset: 0x15F8750 VA: 0x1815FA150
	public void set_type(Image.Type value) { }

	// RVA: 0x15F9A50 Offset: 0x15F8050 VA: 0x1815F9A50
	public bool get_preserveAspect() { }

	// RVA: 0x15F9DD0 Offset: 0x15F83D0 VA: 0x1815F9DD0
	public void set_preserveAspect(bool value) { }

	// RVA: 0x15F9240 Offset: 0x15F7840 VA: 0x1815F9240
	public bool get_fillCenter() { }

	// RVA: 0x15F9B30 Offset: 0x15F8130 VA: 0x1815F9B30
	public void set_fillCenter(bool value) { }

	// RVA: 0x872130 Offset: 0x870730 VA: 0x180872130
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x15F9C10 Offset: 0x15F8210 VA: 0x1815F9C10
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x12DAAA0 Offset: 0x12D90A0 VA: 0x1812DAAA0
	public float get_fillAmount() { }

	// RVA: 0x15F9A90 Offset: 0x15F8090 VA: 0x1815F9A90
	public void set_fillAmount(float value) { }

	// RVA: 0xB0E090 Offset: 0xB0C690 VA: 0x180B0E090
	public bool get_fillClockwise() { }

	// RVA: 0x15F9BA0 Offset: 0x15F81A0 VA: 0x1815F9BA0
	public void set_fillClockwise(bool value) { }

	// RVA: 0x1079DF0 Offset: 0x10783F0 VA: 0x181079DF0
	public int get_fillOrigin() { }

	// RVA: 0x15F9C80 Offset: 0x15F8280 VA: 0x1815F9C80
	public void set_fillOrigin(int value) { }

	// RVA: 0x15F9220 Offset: 0x15F7820 VA: 0x1815F9220
	public float get_eventAlphaThreshold() { }

	// RVA: 0x15F9A70 Offset: 0x15F8070 VA: 0x1815F9A70
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x11D5850 Offset: 0x11D3E50 VA: 0x1811D5850
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x11D5870 Offset: 0x11D3E70 VA: 0x1811D5870
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x15F9A60 Offset: 0x15F8060 VA: 0x1815F9A60
	public bool get_useSpriteMesh() { }

	// RVA: 0x15FA1C0 Offset: 0x15F87C0 VA: 0x1815FA1C0
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x15F9030 Offset: 0x15F7630 VA: 0x1815F9030
	protected void .ctor() { }

	// RVA: 0x15F9120 Offset: 0x15F7720 VA: 0x1815F9120
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x15F9310 Offset: 0x15F7910 VA: 0x1815F9310 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x15F9250 Offset: 0x15F7850 VA: 0x1815F9250
	public bool get_hasBorder() { }

	// RVA: 0x112C0E0 Offset: 0x112A6E0 VA: 0x18112C0E0
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x15F9D60 Offset: 0x15F8360 VA: 0x1815F9D60
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x15F9730 Offset: 0x15F7D30 VA: 0x1815F9730
	public float get_pixelsPerUnit() { }

	// RVA: 0x15F9700 Offset: 0x15F7D00 VA: 0x1815F9700
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x15F94B0 Offset: 0x15F7AB0 VA: 0x1815F94B0 Slot: 32
	public override Material get_material() { }

	// RVA: 0x15F0140 Offset: 0x15EE740 VA: 0x1815F0140 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x15F7560 Offset: 0x15F5B60 VA: 0x1815F7560 Slot: 76
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x15F7A60 Offset: 0x15F6060 VA: 0x1815F7A60
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x15F6820 Offset: 0x15F4E20 VA: 0x1815F6820
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x15F8750 Offset: 0x15F6D50 VA: 0x1815F8750 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x15F7980 Offset: 0x15F5F80 VA: 0x1815F7980 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15F7A40 Offset: 0x15F6040 VA: 0x1815F7A40 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15F7830 Offset: 0x15F5E30 VA: 0x1815F7830 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x15F8B10 Offset: 0x15F7110 VA: 0x1815F8B10
	private void TrackSprite() { }

	// RVA: 0x15F7810 Offset: 0x15F5E10 VA: 0x1815F7810 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15F7730 Offset: 0x15F5D30 VA: 0x1815F7730 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15F8DA0 Offset: 0x15F73A0 VA: 0x1815F8DA0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x15F7610 Offset: 0x15F5C10 VA: 0x1815F7610 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x15F3B60 Offset: 0x15F2160 VA: 0x1815F3B60
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x15F48D0 Offset: 0x15F2ED0 VA: 0x1815F48D0
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x15F3E90 Offset: 0x15F2490 VA: 0x1815F3E90
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x15F4EB0 Offset: 0x15F34B0 VA: 0x1815F4EB0
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x15F22F0 Offset: 0x15F08F0 VA: 0x1815F22F0
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x15F20C0 Offset: 0x15F06C0 VA: 0x1815F20C0
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x15F65A0 Offset: 0x15F4BA0 VA: 0x1815F65A0
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x15F24B0 Offset: 0x15F0AB0 VA: 0x1815F24B0
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x15F7C60 Offset: 0x15F6260 VA: 0x1815F7C60
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x15F7DF0 Offset: 0x15F63F0 VA: 0x1815F7DF0
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 77
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 78
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 79
	public virtual float get_minWidth() { }

	// RVA: 0x15F9930 Offset: 0x15F7F30 VA: 0x1815F9930 Slot: 80
	public virtual float get_preferredWidth() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 81
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 82
	public virtual float get_minHeight() { }

	// RVA: 0x15F9840 Offset: 0x15F7E40 VA: 0x1815F9840 Slot: 83
	public virtual float get_preferredHeight() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 84
	public virtual float get_flexibleHeight() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 85
	public virtual int get_layoutPriority() { }

	// RVA: 0x15F6C90 Offset: 0x15F5290 VA: 0x1815F6C90 Slot: 86
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x15F7070 Offset: 0x15F5670 VA: 0x1815F7070
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x15F85E0 Offset: 0x15F6BE0 VA: 0x1815F85E0
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x15F89D0 Offset: 0x15F6FD0 VA: 0x1815F89D0
	private static void TrackImage(Image g) { }

	// RVA: 0x15F8D20 Offset: 0x15F7320 VA: 0x1815F8D20
	private static void UnTrackImage(Image g) { }

	// RVA: 0x15F8EF0 Offset: 0x15F74F0 VA: 0x1815F8EF0
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

