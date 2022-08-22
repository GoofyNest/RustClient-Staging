public class LightCloneShadow : MonoBehaviour // TypeDefIndex: 10684
{	// Fields
	public bool cloneShadowMap; // 0x18
	public string shaderPropNameMap; // 0x20
	[RangeAttribute] // RVA: 0x71350 Offset: 0x70750 VA: 0x180071350
	public int cloneShadowMapDownscale; // 0x28
	public RenderTexture map; // 0x30
	public bool cloneShadowMask; // 0x38
	public string shaderPropNameMask; // 0x40
	[RangeAttribute] // RVA: 0x71350 Offset: 0x70750 VA: 0x180071350
	public int cloneShadowMaskDownscale; // 0x48
	public RenderTexture mask; // 0x50
	private Light light; // 0x58
	private CommandBuffer mapCB; // 0x60
	private CommandBuffer maskCB; // 0x68
	private int screenWidth; // 0x70
	private int screenHeight; // 0x74

	// Methods

	// RVA: 0x68F7B0 Offset: 0x68DDB0 VA: 0x18068F7B0
	private void OnEnable() { }

	// RVA: 0x68F740 Offset: 0x68DD40 VA: 0x18068F740
	private void OnDestroy() { }

	// RVA: 0x68F950 Offset: 0x68DF50 VA: 0x18068F950
	private void Update() { }

	// RVA: 0x68EE70 Offset: 0x68D470 VA: 0x18068EE70
	private void AllocateShadowClone() { }

	// RVA: 0x68F550 Offset: 0x68DB50 VA: 0x18068F550
	private void DestroyShadowClone() { }

	// RVA: 0x68F860 Offset: 0x68DE60 VA: 0x18068F860
	private void UpdateShadowMask() { }

	// RVA: 0x68FB10 Offset: 0x68E110 VA: 0x18068FB10
	public void .ctor() { }

}

