public sealed class PropertySheetFactory // TypeDefIndex: 11866
{	// Fields
	private readonly Dictionary<Shader, PropertySheet> m_Sheets; // 0x10

	// Methods

	// RVA: 0x11D6F60 Offset: 0x11D5560 VA: 0x1811D6F60
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0x7DD70 Offset: 0x7D170 VA: 0x18007DD70
	// RVA: 0x11D6C80 Offset: 0x11D5280 VA: 0x1811D6C80
	public PropertySheet Get(string shaderName) { }

	// RVA: 0x11D6AB0 Offset: 0x11D50B0 VA: 0x1811D6AB0
	public PropertySheet Get(Shader shader) { }

	// RVA: 0x11D6D50 Offset: 0x11D5350 VA: 0x1811D6D50
	public void Release() { }

}

