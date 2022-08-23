public class MaterialConfig : ScriptableObject // TypeDefIndex: 11314
{	[HorizontalAttribute] // RVA: 0xA4660 Offset: 0xA3A60 VA: 0x1800A4660
	public MaterialConfig.ShaderParametersFloat[] Floats; // 0x18
	[HorizontalAttribute] // RVA: 0xA4660 Offset: 0xA3A60 VA: 0x1800A4660
	public MaterialConfig.ShaderParametersColor[] Colors; // 0x20
	[HorizontalAttribute] // RVA: 0xA4660 Offset: 0xA3A60 VA: 0x1800A4660
	public MaterialConfig.ShaderParametersTexture[] Textures; // 0x28
	public string[] ScaleUV; // 0x30
	private MaterialPropertyBlock properties; // 0x38


	public MaterialPropertyBlock GetMaterialPropertyBlock(Material mat, Vector3 pos, Vector3 scale) { }

	public void .ctor() { }

}

public class MaterialConfig.ShaderParameters<T> // TypeDefIndex: 11315
{	public string Name; // 0x0
	public T Arid; // 0x0
	public T Temperate; // 0x0
	public T Tundra; // 0x0
	public T Arctic; // 0x0
	private T[] climates; // 0x0


	public float FindBlendParameters(Vector3 pos, out T src, out T dst) { }
	/* GenericInstMethod :
	|
	|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
	|
	|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
	|
	|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
	*/

	public T FindBlendParameters(Vector3 pos) { }
	/* GenericInstMethod :
	|
	|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
	|-MaterialConfig.ShaderParameters<Texture>.FindBlendParameters
	|
	|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
	|
	|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-MaterialConfig.ShaderParameters<object>..ctor
	|-MaterialConfig.ShaderParameters<float>..ctor
	|-MaterialConfig.ShaderParameters<Color>..ctor
	|-MaterialConfig.ShaderParameters<Texture>..ctor
	*/

}

public class MaterialConfig.ShaderParametersFloat : MaterialConfig.ShaderParameters<float> // TypeDefIndex: 11316
{
	public void .ctor() { }

}

public class MaterialConfig.ShaderParametersColor : MaterialConfig.ShaderParameters<Color> // TypeDefIndex: 11317
{
	public void .ctor() { }

}

public class MaterialConfig.ShaderParametersTexture : MaterialConfig.ShaderParameters<Texture> // TypeDefIndex: 11318
{
	public void .ctor() { }

}

