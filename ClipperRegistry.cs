public class ClipperRegistry // TypeDefIndex: 4912
{	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x10B9A60 Offset: 0x10B8060 VA: 0x1810B9A60
	protected void .ctor() { }

	// RVA: 0x10B9AD0 Offset: 0x10B80D0 VA: 0x1810B9AD0
	public static ClipperRegistry get_instance() { }

	// RVA: 0x10B9880 Offset: 0x10B7E80 VA: 0x1810B9880
	public void Cull() { }

	// RVA: 0x10B99A0 Offset: 0x10B7FA0 VA: 0x1810B99A0
	public static void Register(IClipper c) { }

	// RVA: 0x10B9A00 Offset: 0x10B8000 VA: 0x1810B9A00
	public static void Unregister(IClipper c) { }

}

