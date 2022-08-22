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

	// RVA: 0x68F710 Offset: 0x68DD10 VA: 0x18068F710
	private void OnEnable() { }

	// RVA: 0x68F6A0 Offset: 0x68DCA0 VA: 0x18068F6A0
	private void OnDestroy() { }

	// RVA: 0x68F8B0 Offset: 0x68DEB0 VA: 0x18068F8B0
	private void Update() { }

	// RVA: 0x68EDD0 Offset: 0x68D3D0 VA: 0x18068EDD0
	private void AllocateShadowClone() { }

	// RVA: 0x68F4B0 Offset: 0x68DAB0 VA: 0x18068F4B0
	private void DestroyShadowClone() { }

	// RVA: 0x68F7C0 Offset: 0x68DDC0 VA: 0x18068F7C0
	private void UpdateShadowMask() { }

	// RVA: 0x68FA70 Offset: 0x68E070 VA: 0x18068FA70
	public void .ctor() { }

}

