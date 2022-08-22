public class ScreenOverlayEx : PostEffectsBase, IImageEffect // TypeDefIndex: 8066
{	// Fields
	public ScreenOverlayEx.OverlayBlendMode blendMode; // 0x28
	public float intensity; // 0x2C
	public Texture texture; // 0x30
	public Texture normals; // 0x38
	public Shader overlayShader; // 0x40
	private Material overlayMaterial; // 0x48

	// Methods

	// RVA: 0x10740E0 Offset: 0x10726E0 VA: 0x1810740E0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1074140 Offset: 0x1072740 VA: 0x181074140 Slot: 5
	public bool IsActive() { }

	// RVA: 0x1074180 Offset: 0x1072780 VA: 0x181074180 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1074570 Offset: 0x1072B70 VA: 0x181074570
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

