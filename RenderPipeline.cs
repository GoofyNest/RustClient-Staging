public abstract class RenderPipeline // TypeDefIndex: 3849
{	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private bool <disposed>k__BackingField; // 0x10

	public bool disposed { get; set; }


	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_disposed(bool value) { }

	internal void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

}

