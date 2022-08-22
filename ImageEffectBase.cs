public class ImageEffectBase : MonoBehaviour // TypeDefIndex: 8191
{	// Fields
	public Shader shader; // 0x18
	private Material m_Material; // 0x20

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x21E16E0 Offset: 0x21DFCE0 VA: 0x1821E16E0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x21E1780 Offset: 0x21DFD80 VA: 0x1821E1780
	protected Material get_material() { }

	// RVA: 0x21E1650 Offset: 0x21DFC50 VA: 0x1821E1650 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

