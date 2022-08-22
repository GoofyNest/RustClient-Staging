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

	// RVA: 0x68F820 Offset: 0x68DE20 VA: 0x18068F820
	private void OnEnable() { }

	// RVA: 0x68F7B0 Offset: 0x68DDB0 VA: 0x18068F7B0
	private void OnDestroy() { }

	// RVA: 0x68F9C0 Offset: 0x68DFC0 VA: 0x18068F9C0
	private void Update() { }

	// RVA: 0x68EEE0 Offset: 0x68D4E0 VA: 0x18068EEE0
	private void AllocateShadowClone() { }

	// RVA: 0x68F5C0 Offset: 0x68DBC0 VA: 0x18068F5C0
	private void DestroyShadowClone() { }

	// RVA: 0x68F8D0 Offset: 0x68DED0 VA: 0x18068F8D0
	private void UpdateShadowMask() { }

	// RVA: 0x68FB80 Offset: 0x68E180 VA: 0x18068FB80
	public void .ctor() { }

}

