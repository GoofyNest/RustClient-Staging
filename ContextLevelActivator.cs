internal class ContextLevelActivator : IActivator // TypeDefIndex: 1205
{	// Fields
	private IActivator m_NextActivator; // 0x10

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(IActivator next) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0xFE4790 Offset: 0xFE2D90 VA: 0x180FE4790 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

}

