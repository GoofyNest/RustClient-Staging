public class ImageEffectBase : MonoBehaviour // TypeDefIndex: 8191
{	// Fields
	public Shader shader; // 0x18
	private Material m_Material; // 0x20

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x21E0C00 Offset: 0x21DF200 VA: 0x1821E0C00 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x21E0CA0 Offset: 0x21DF2A0 VA: 0x1821E0CA0
	protected Material get_material() { }

	// RVA: 0x21E0B70 Offset: 0x21DF170 VA: 0x1821E0B70 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

