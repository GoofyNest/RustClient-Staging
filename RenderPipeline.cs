public abstract class RenderPipeline // TypeDefIndex: 3849
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	// RVA: 0x19AF760 Offset: 0x19ADD60 VA: 0x1819AF760
	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	private void set_disposed(bool value) { }

	// RVA: 0x19AF6F0 Offset: 0x19ADCF0 VA: 0x1819AF6F0
	internal void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void Dispose(bool disposing) { }

}

