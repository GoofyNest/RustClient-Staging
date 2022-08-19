public class RawImage : MaskableGraphic // TypeDefIndex: 4992
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x76930 Offset: 0x75D30 VA: 0x180076930
	[SerializeField] // RVA: 0x76930 Offset: 0x75D30 VA: 0x180076930
	private Texture m_Texture; // 0xC8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Rect m_UVRect; // 0xD0

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x1717B20 Offset: 0x1716120 VA: 0x181717B20
	protected void .ctor() { }

	// RVA: 0x1717C40 Offset: 0x1716240 VA: 0x181717C40 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0xDA00E0 Offset: 0xD9E6E0 VA: 0x180DA00E0
	public Texture get_texture() { }

	// RVA: 0x1717DE0 Offset: 0x17163E0 VA: 0x181717DE0
	public void set_texture(Texture value) { }

	// RVA: 0x1717DD0 Offset: 0x17163D0 VA: 0x181717DD0
	public Rect get_uvRect() { }

	// RVA: 0x1717EA0 Offset: 0x17164A0 VA: 0x181717EA0
	public void set_uvRect(Rect value) { }

	// RVA: 0x1717950 Offset: 0x1715F50 VA: 0x181717950 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x1717460 Offset: 0x1715A60 VA: 0x181717460 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1717420 Offset: 0x1715A20 VA: 0x181717420 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

}

