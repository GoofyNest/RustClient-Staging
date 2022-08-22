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

	// RVA: 0x1717DE0 Offset: 0x17163E0 VA: 0x181717DE0
	protected void .ctor() { }

	// RVA: 0x1717F00 Offset: 0x1716500 VA: 0x181717F00 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0xDA03A0 Offset: 0xD9E9A0 VA: 0x180DA03A0
	public Texture get_texture() { }

	// RVA: 0x17180A0 Offset: 0x17166A0 VA: 0x1817180A0
	public void set_texture(Texture value) { }

	// RVA: 0x1718090 Offset: 0x1716690 VA: 0x181718090
	public Rect get_uvRect() { }

	// RVA: 0x1718160 Offset: 0x1716760 VA: 0x181718160
	public void set_uvRect(Rect value) { }

	// RVA: 0x1717C10 Offset: 0x1716210 VA: 0x181717C10 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x1717720 Offset: 0x1715D20 VA: 0x181717720 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x17176E0 Offset: 0x1715CE0 VA: 0x1817176E0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

}

