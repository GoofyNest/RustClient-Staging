public class Shadow : BaseMeshEffect // TypeDefIndex: 5036
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_EffectColor; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 m_EffectDistance; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_UseGraphicAlpha; // 0x38
	private const float kMaxEffectDistance = 600;

	// Properties
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }

	// Methods

	// RVA: 0x1710990 Offset: 0x170EF90 VA: 0x181710990
	protected void .ctor() { }

	// RVA: 0xD680B0 Offset: 0xD666B0 VA: 0x180D680B0
	public Color get_effectColor() { }

	// RVA: 0x171E290 Offset: 0x171C890 VA: 0x18171E290
	public void set_effectColor(Color value) { }

	// RVA: 0xC15780 Offset: 0xC13D80 VA: 0x180C15780
	public Vector2 get_effectDistance() { }

	// RVA: 0x171E340 Offset: 0x171C940 VA: 0x18171E340
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_useGraphicAlpha() { }

	// RVA: 0x171E4A0 Offset: 0x171CAA0 VA: 0x18171E4A0
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x171DED0 Offset: 0x171C4D0 VA: 0x18171DED0
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x171E160 Offset: 0x171C760 VA: 0x18171E160
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x171E170 Offset: 0x171C770 VA: 0x18171E170 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

}

