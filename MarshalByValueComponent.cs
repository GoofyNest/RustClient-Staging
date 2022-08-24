public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider // TypeDefIndex: 2728
{	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x10
	private EventHandlerList events; // 0x18

	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E980 Offset: 0x9DD80 VA: 0x18009E980
	[BrowsableAttribute] // RVA: 0x9E980 Offset: 0x9DD80 VA: 0x18009E980
	public virtual ISite Site { get; }


	public void .ctor() { }

	protected override void Finalize() { }

	public virtual ISite get_Site() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual object GetService(Type service) { }

	public override string ToString() { }

	private static void .cctor() { }

}

