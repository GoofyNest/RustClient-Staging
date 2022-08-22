public class DamageRenderer : MonoBehaviour, IClientComponent, IPrefabPreProcess // TypeDefIndex: 9708
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<Material> damageShowingMats; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxDamageOpacity; // 0x20
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private List<DamageRenderer.DamageShowingRenderer> damageShowingRenderers; // 0x28
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private List<GlassPane> damageShowingGlassRenderers; // 0x30
	private float prevHealth; // 0x38
	private bool prevIsDead; // 0x3C
	private Color damageColour; // 0x40
	private static MaterialPropertyBlock materialPB; // 0x0
	private static MaterialPropertyBlock glassMaterialPB; // 0x8
	public static int detailColorID; // 0x10
	private static Material highlightMaterial; // 0x18

	// Methods

	// RVA: 0x83D8A0 Offset: 0x83BEA0 VA: 0x18083D8A0 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x83E820 Offset: 0x83CE20 VA: 0x18083E820
	public void UpdateDamage(BaseCombatEntity bce) { }

	// RVA: 0x83E760 Offset: 0x83CD60 VA: 0x18083E760
	public void UpdateDamage(float curHealth, bool isDead, float healthFraction) { }

	// RVA: 0x83E0A0 Offset: 0x83C6A0 VA: 0x18083E0A0
	private void RefreshDamageTex(float healthPercent, bool isDead) { }

	// RVA: 0x83E4A0 Offset: 0x83CAA0 VA: 0x18083E4A0
	private void SetDamageTex(DamageRenderer.DamageShowingRenderer dsr) { }

	// RVA: 0x83D0A0 Offset: 0x83B6A0 VA: 0x18083D0A0
	public void DrawHighlight() { }

	// RVA: 0x83D2C0 Offset: 0x83B8C0 VA: 0x18083D2C0
	private void Highlight(Renderer renderer) { }

	// RVA: 0x83E960 Offset: 0x83CF60 VA: 0x18083E960
	public void .ctor() { }

	// RVA: 0x83E910 Offset: 0x83CF10 VA: 0x18083E910
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x83E620 Offset: 0x83CC20 VA: 0x18083E620
	private int[] <PreProcess>g__GetValidMatIndices|12_0(Renderer renderer, ref DamageRenderer.<>c__DisplayClass12_0 ) { }

}

private struct DamageRenderer.DamageShowingRenderer // TypeDefIndex: 9709
{	// Fields
	public Renderer renderer; // 0x0
	public int[] indices; // 0x8

	// Methods

	// RVA: 0xF5A50 Offset: 0xF4E50 VA: 0x1800F5A50
	public void .ctor(Renderer renderer, int[] indices) { }

}

private struct DamageRenderer.<>c__DisplayClass12_0 // TypeDefIndex: 9710
{	// Fields
	public List<int> matList; // 0x0
	public DamageRenderer <>4__this; // 0x8

}

