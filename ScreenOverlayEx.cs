public class ScreenOverlayEx : PostEffectsBase, IImageEffect // TypeDefIndex: 8066
{	// Fields
	public ScreenOverlayEx.OverlayBlendMode blendMode; // 0x28
	public float intensity; // 0x2C
	public Texture texture; // 0x30
	public Texture normals; // 0x38
	public Shader overlayShader; // 0x40
	private Material overlayMaterial; // 0x48

	// Methods

	// RVA: 0x1074B50 Offset: 0x1073150 VA: 0x181074B50 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1074BB0 Offset: 0x10731B0 VA: 0x181074BB0 Slot: 5
	public bool IsActive() { }

	// RVA: 0x1074BF0 Offset: 0x10731F0 VA: 0x181074BF0 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1074FE0 Offset: 0x10735E0 VA: 0x181074FE0
	public void .ctor() { }

}

public enum ScreenOverlayEx.OverlayBlendMode // TypeDefIndex: 8067
{	// Fields
	public int value__; // 0x0
	public const ScreenOverlayEx.OverlayBlendMode Additive = 0;
	public const ScreenOverlayEx.OverlayBlendMode ScreenBlend = 1;
	public const ScreenOverlayEx.OverlayBlendMode Multiply = 2;
	public const ScreenOverlayEx.OverlayBlendMode Overlay = 3;
	public const ScreenOverlayEx.OverlayBlendMode AlphaBlend = 4;

}

