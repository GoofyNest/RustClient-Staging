public class WaterRuntime // TypeDefIndex: 10626
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private WaterCamera <WaterCamera>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Camera <Camera>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private PostOpaqueDepth <PostOpaqueDepth>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private CommandBufferManager <CommandBufferManager>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <SimulateNextFrame>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private WaterSimulation <Simulation>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private WaterRendering <Rendering>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int <VisibilityMask>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <IsInitialized>k__BackingField; // 0x4C

	public WaterCamera WaterCamera { get; set; }
	public Camera Camera { get; set; }
	public PostOpaqueDepth PostOpaqueDepth { get; set; }
	public CommandBufferManager CommandBufferManager { get; set; }
	public bool SimulateNextFrame { get; set; }
	public WaterSimulation Simulation { get; set; }
	public WaterRendering Rendering { get; set; }
	public int VisibilityMask { get; set; }
	public bool IsInitialized { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_WaterCamera(WaterCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public WaterCamera get_WaterCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Camera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Camera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_PostOpaqueDepth(PostOpaqueDepth value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public PostOpaqueDepth get_PostOpaqueDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_CommandBufferManager(CommandBufferManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public CommandBufferManager get_CommandBufferManager() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_SimulateNextFrame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_SimulateNextFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Simulation(WaterSimulation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public WaterSimulation get_Simulation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Rendering(WaterRendering value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public WaterRendering get_Rendering() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_VisibilityMask(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public int get_VisibilityMask() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_IsInitialized() { }

	public void .ctor(WaterCamera camera) { }

	public void Initialize(WaterSystem water) { }

	public void Shutdown() { }

	public void SetVisibilityMask(int mask) { }

	private void Simulate() { }

	private void PrepareRender() { }

	public void Update() { }

	public void IssueRender() { }

}

