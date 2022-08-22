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

	// RVA: 0x83D9B0 Offset: 0x83BFB0 VA: 0x18083D9B0 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x83E930 Offset: 0x83CF30 VA: 0x18083E930
	public void UpdateDamage(BaseCombatEntity bce) { }

	// RVA: 0x83E870 Offset: 0x83CE70 VA: 0x18083E870
	public void UpdateDamage(float curHealth, bool isDead, float healthFraction) { }

	// RVA: 0x83E1B0 Offset: 0x83C7B0 VA: 0x18083E1B0
	private void RefreshDamageTex(float healthPercent, bool isDead) { }

	// RVA: 0x83E5B0 Offset: 0x83CBB0 VA: 0x18083E5B0
	private void SetDamageTex(DamageRenderer.DamageShowingRenderer dsr) { }

	// RVA: 0x83D1B0 Offset: 0x83B7B0 VA: 0x18083D1B0
	public void DrawHighlight() { }

	// RVA: 0x83D3D0 Offset: 0x83B9D0 VA: 0x18083D3D0
	private void Highlight(Renderer renderer) { }

	// RVA: 0x83EA70 Offset: 0x83D070 VA: 0x18083EA70
	public void .ctor() { }

	// RVA: 0x83EA20 Offset: 0x83D020 VA: 0x18083EA20
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x83E730 Offset: 0x83CD30 VA: 0x18083E730
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

