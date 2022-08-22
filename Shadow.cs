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

	// RVA: 0x1717280 Offset: 0x1715880 VA: 0x181717280
	protected void .ctor() { }

	// RVA: 0xD67340 Offset: 0xD65940 VA: 0x180D67340
	public Color get_effectColor() { }

	// RVA: 0x1724BB0 Offset: 0x17231B0 VA: 0x181724BB0
	public void set_effectColor(Color value) { }

	// RVA: 0xC14FF0 Offset: 0xC135F0 VA: 0x180C14FF0
	public Vector2 get_effectDistance() { }

	// RVA: 0x1724C60 Offset: 0x1723260 VA: 0x181724C60
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_useGraphicAlpha() { }

	// RVA: 0x1724DC0 Offset: 0x17233C0 VA: 0x181724DC0
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x17247F0 Offset: 0x1722DF0 VA: 0x1817247F0
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1724A80 Offset: 0x1723080 VA: 0x181724A80
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1724A90 Offset: 0x1723090 VA: 0x181724A90 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

}

