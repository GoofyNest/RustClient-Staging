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
	|-RVA: 0x164F3E0 Offset: 0x164D9E0 VA: 0x18164F3E0
	|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
	|
	|-RVA: 0x164F060 Offset: 0x164D660 VA: 0x18164F060
	|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
	|
	|-RVA: 0x164EA70 Offset: 0x164D070 VA: 0x18164EA70
	|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
	*/

	public T FindBlendParameters(Vector3 pos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164E7F0 Offset: 0x164CDF0 VA: 0x18164E7F0
	|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
	|-MaterialConfig.ShaderParameters<Texture>.FindBlendParameters
	|
	|-RVA: 0x164F7A0 Offset: 0x164DDA0 VA: 0x18164F7A0
	|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
	|
	|-RVA: 0x164EDF0 Offset: 0x164D3F0 VA: 0x18164EDF0
	|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
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

