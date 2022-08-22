public class RawImage : MaskableGraphic // TypeDefIndex: 4992
{	[FormerlySerializedAsAttribute] // RVA: 0x76A30 Offset: 0x75E30 VA: 0x180076A30
	[SerializeField] // RVA: 0x76A30 Offset: 0x75E30 VA: 0x180076A30
	private Texture m_Texture; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Rect m_UVRect; // 0xD0

	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }


	protected void .ctor() { }

	public override Texture get_mainTexture() { }

	public Texture get_texture() { }

	public void set_texture(Texture value) { }

	public Rect get_uvRect() { }

	public void set_uvRect(Rect value) { }

	public override void SetNativeSize() { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	protected override void OnDidApplyAnimationProperties() { }

}

