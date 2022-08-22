public class ScreenOverlay : PostEffectsBase, IImageEffect // TypeDefIndex: 8199
{	// Fields
	public ScreenOverlay.OverlayBlendMode blendMode; // 0x28
	public float intensity; // 0x2C
	public Texture texture; // 0x30
	public Shader overlayShader; // 0x38
	private Material overlayMaterial; // 0x40

	// Methods

	// RVA: 0x21E5730 Offset: 0x21E3D30 VA: 0x1821E5730 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1073E80 Offset: 0x1072480 VA: 0x181073E80 Slot: 5
	public bool IsActive() { }

	// RVA: 0x21E57F0 Offset: 0x21E3DF0 VA: 0x1821E57F0 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E5980 Offset: 0x21E3F80 VA: 0x1821E5980
	public void .ctor() { }

}

public enum ScreenOverlay.OverlayBlendMode // TypeDefIndex: 8200
{	// Fields
	public int value__; // 0x0
	public const ScreenOverlay.OverlayBlendMode Additive = 0;
	public const ScreenOverlay.OverlayBlendMode ScreenBlend = 1;
	public const ScreenOverlay.OverlayBlendMode Multiply = 2;
	public const ScreenOverlay.OverlayBlendMode Overlay = 3;
	public const ScreenOverlay.OverlayBlendMode AlphaBlend = 4;

}

public class ScreenOverlay : PostProcessEffectSettings // TypeDefIndex: 10271
{	// Fields
	public OverlayBlendModeParameter blendMode; // 0x30
	public FloatParameter intensity; // 0x38
	public TextureParameter texture; // 0x40
	public TextureParameter normals; // 0x48

	// Methods

	// RVA: 0x4A49A0 Offset: 0x4A2FA0 VA: 0x1804A49A0
	public void .ctor() { }

}

