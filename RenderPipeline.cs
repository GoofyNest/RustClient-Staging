public abstract class RenderPipeline // TypeDefIndex: 3849
{	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private bool <disposed>k__BackingField; // 0x10

	public bool disposed { get; set; }


	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_disposed(bool value) { }

	internal void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

}

