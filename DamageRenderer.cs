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

	// RVA: 0x83DF00 Offset: 0x83C500 VA: 0x18083DF00 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x83EE80 Offset: 0x83D480 VA: 0x18083EE80
	public void UpdateDamage(BaseCombatEntity bce) { }

	// RVA: 0x83EDC0 Offset: 0x83D3C0 VA: 0x18083EDC0
	public void UpdateDamage(float curHealth, bool isDead, float healthFraction) { }

	// RVA: 0x83E700 Offset: 0x83CD00 VA: 0x18083E700
	private void RefreshDamageTex(float healthPercent, bool isDead) { }

	// RVA: 0x83EB00 Offset: 0x83D100 VA: 0x18083EB00
	private void SetDamageTex(DamageRenderer.DamageShowingRenderer dsr) { }

	// RVA: 0x83D700 Offset: 0x83BD00 VA: 0x18083D700
	public void DrawHighlight() { }

	// RVA: 0x83D920 Offset: 0x83BF20 VA: 0x18083D920
	private void Highlight(Renderer renderer) { }

	// RVA: 0x83EFC0 Offset: 0x83D5C0 VA: 0x18083EFC0
	public void .ctor() { }

	// RVA: 0x83EF70 Offset: 0x83D570 VA: 0x18083EF70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x83EC80 Offset: 0x83D280 VA: 0x18083EC80
	private int[] <PreProcess>g__GetValidMatIndices|12_0(Renderer renderer, ref DamageRenderer.<>c__DisplayClass12_0 ) { }

}

private struct DamageRenderer.DamageShowingRenderer // TypeDefIndex: 9709
{	// Fields
	public Renderer renderer; // 0x0
	public int[] indices; // 0x8

	// Methods

	// RVA: 0xF5DB0 Offset: 0xF51B0 VA: 0x1800F5DB0
	public void .ctor(Renderer renderer, int[] indices) { }

}

private struct DamageRenderer.<>c__DisplayClass12_0 // TypeDefIndex: 9710
{	// Fields
	public List<int> matList; // 0x0
	public DamageRenderer <>4__this; // 0x8

}

