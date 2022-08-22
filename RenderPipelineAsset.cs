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

	// RVA: 0x19AE650 Offset: 0x19ACC50 VA: 0x1819AE650
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 4
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 9
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 12
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 13
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 14
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 15
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 16
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 18
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 19
	public virtual Shader get_defaultShader() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 20
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 21
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract RenderPipeline CreatePipeline();

	// RVA: 0x19AE840 Offset: 0x19ACE40 VA: 0x1819AE840 Slot: 23
	protected virtual void OnValidate() { }

	// RVA: 0x19AE7F0 Offset: 0x19ACDF0 VA: 0x1819AE7F0 Slot: 24
	protected virtual void OnDisable() { }

	// RVA: 0x19AE890 Offset: 0x19ACE90 VA: 0x1819AE890
	protected void .ctor() { }

}

