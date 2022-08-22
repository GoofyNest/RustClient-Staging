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

	// RVA: 0x1717540 Offset: 0x1715B40 VA: 0x181717540
	protected void .ctor() { }

	// RVA: 0xD67600 Offset: 0xD65C00 VA: 0x180D67600
	public Color get_effectColor() { }

	// RVA: 0x1724E70 Offset: 0x1723470 VA: 0x181724E70
	public void set_effectColor(Color value) { }

	// RVA: 0xC152B0 Offset: 0xC138B0 VA: 0x180C152B0
	public Vector2 get_effectDistance() { }

	// RVA: 0x1724F20 Offset: 0x1723520 VA: 0x181724F20
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_useGraphicAlpha() { }

	// RVA: 0x1725080 Offset: 0x1723680 VA: 0x181725080
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x1724AB0 Offset: 0x17230B0 VA: 0x181724AB0
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1724D40 Offset: 0x1723340 VA: 0x181724D40
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1724D50 Offset: 0x1723350 VA: 0x181724D50 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

}

