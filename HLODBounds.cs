public class HLODBounds : MonoBehaviour, IEditorComponent // TypeDefIndex: 11660
{
	[TooltipAttribute] 
	public Bounds MeshBounds; 
	[TooltipAttribute] 
	public string MeshPrefix; 
	[TooltipAttribute] 
	public float CullDistance; 
	[TooltipAttribute] 
	public float OverrideLodDistance; 
	[TooltipAttribute] 
	public float CullBelowHeight; 
	[TooltipAttribute] 
	public bool ApplyMeshTrimming; 
	public MeshTrimSettings Settings; 
	public RendererLOD DebugComponent; 
	public bool ShowTrimSettings; 
	[TooltipAttribute] 
	public bool SkipGeneration; 


	public void .ctor() { }

}

