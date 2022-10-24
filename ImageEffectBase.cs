public class ImageEffectBase : MonoBehaviour // TypeDefIndex: 8201
{
	public Shader shader; 
	private Material m_Material; 

	protected Material material { get; }


	protected virtual void Start() { }

	protected Material get_material() { }

	protected virtual void OnDisable() { }

	public void .ctor() { }

}

