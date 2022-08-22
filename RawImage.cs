public class RawImage : MaskableGraphic // TypeDefIndex: 4992
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x76A30 Offset: 0x75E30 VA: 0x180076A30
	[SerializeField] // RVA: 0x76A30 Offset: 0x75E30 VA: 0x180076A30
	private Texture m_Texture; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Rect m_UVRect; // 0xD0

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x1711230 Offset: 0x170F830 VA: 0x181711230
	protected void .ctor() { }

	// RVA: 0x1711350 Offset: 0x170F950 VA: 0x181711350 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0xDA0E50 Offset: 0xD9F450 VA: 0x180DA0E50
	public Texture get_texture() { }

	// RVA: 0x17114F0 Offset: 0x170FAF0 VA: 0x1817114F0
	public void set_texture(Texture value) { }

	// RVA: 0x17114E0 Offset: 0x170FAE0 VA: 0x1817114E0
	public Rect get_uvRect() { }

	// RVA: 0x17115B0 Offset: 0x170FBB0 VA: 0x1817115B0
	public void set_uvRect(Rect value) { }

	// RVA: 0x1711060 Offset: 0x170F660 VA: 0x181711060 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x1710B70 Offset: 0x170F170 VA: 0x181710B70 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1710B30 Offset: 0x170F130 VA: 0x181710B30 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

}

