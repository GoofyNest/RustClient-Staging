public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 3850
{	// Properties
	public virtual string[] renderingLayerMaskNames { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }

	// Methods

	// RVA: 0x199BA50 Offset: 0x199A050 VA: 0x18199BA50
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 4
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 7
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 8
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 9
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 11
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 12
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 13
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 14
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 15
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 16
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 17
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 18
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 19
	public virtual Shader get_defaultShader() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 20
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 21
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract RenderPipeline CreatePipeline();

	// RVA: 0x199BC40 Offset: 0x199A240 VA: 0x18199BC40 Slot: 23
	protected virtual void OnValidate() { }

	// RVA: 0x199BBF0 Offset: 0x199A1F0 VA: 0x18199BBF0 Slot: 24
	protected virtual void OnDisable() { }

	// RVA: 0x199BC90 Offset: 0x199A290 VA: 0x18199BC90
	protected void .ctor() { }

}

