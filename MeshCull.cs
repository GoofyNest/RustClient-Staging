public class MeshCull : LODComponent, IBatchingHandler // TypeDefIndex: 9940
{	// Fields
	public float Distance; // 0x80
	private RendererBatch meshBatch; // 0x88
	private Renderer meshRenderer; // 0x90
	private MeshFilter meshFilter; // 0x98
	private int curlod; // 0xA0
	private bool force; // 0xA4

	// Methods

	// RVA: 0x9613F0 Offset: 0x95F9F0 VA: 0x1809613F0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x7D45D0 Offset: 0x7D2BD0 VA: 0x1807D45D0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x961480 Offset: 0x95FA80 VA: 0x180961480 Slot: 13
	protected override void Show() { }

	// RVA: 0x961320 Offset: 0x95F920 VA: 0x180961320 Slot: 14
	protected override void Hide() { }

	// RVA: 0x7D4A80 Offset: 0x7D3080 VA: 0x1807D4A80 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x961290 Offset: 0x95F890 VA: 0x180961290 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x961610 Offset: 0x95FC10 VA: 0x180961610
	public void .ctor() { }

}

