public class MaterialConfig : ScriptableObject // TypeDefIndex: 11314
{	// Fields
	[HorizontalAttribute] // RVA: 0xA45A0 Offset: 0xA39A0 VA: 0x1800A45A0
	public MaterialConfig.ShaderParametersFloat[] Floats; // 0x18
	[HorizontalAttribute] // RVA: 0xA45A0 Offset: 0xA39A0 VA: 0x1800A45A0
	public MaterialConfig.ShaderParametersColor[] Colors; // 0x20
	[HorizontalAttribute] // RVA: 0xA45A0 Offset: 0xA39A0 VA: 0x1800A45A0
	public MaterialConfig.ShaderParametersTexture[] Textures; // 0x28
	public string[] ScaleUV; // 0x30
	private MaterialPropertyBlock properties; // 0x38

	// Methods

	// RVA: 0x95A7C0 Offset: 0x958DC0 VA: 0x18095A7C0
	public MaterialPropertyBlock GetMaterialPropertyBlock(Material mat, Vector3 pos, Vector3 scale) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class MaterialConfig.ShaderParameters<T> // TypeDefIndex: 11315
{	// Fields
	public string Name; // 0x0
	public T Arid; // 0x0
	public T Temperate; // 0x0
	public T Tundra; // 0x0
	public T Arctic; // 0x0
	private T[] climates; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public float FindBlendParameters(Vector3 pos, out T src, out T dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FB290 Offset: 0x17F9890 VA: 0x1817FB290
	|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
	|
	|-RVA: 0x17FAF10 Offset: 0x17F9510 VA: 0x1817FAF10
	|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
	|
	|-RVA: 0x17FA920 Offset: 0x17F8F20 VA: 0x1817FA920
	|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
	*/

	// RVA: -1 Offset: -1
	public T FindBlendParameters(Vector3 pos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FA6A0 Offset: 0x17F8CA0 VA: 0x1817FA6A0
	|-MaterialConfig.ShaderParameters<object>.FindBlendParameters
	|-MaterialConfig.ShaderParameters<Texture>.FindBlendParameters
	|
	|-RVA: 0x17FB650 Offset: 0x17F9C50 VA: 0x1817FB650
	|-MaterialConfig.ShaderParameters<float>.FindBlendParameters
	|
	|-RVA: 0x17FACA0 Offset: 0x17F92A0 VA: 0x1817FACA0
	|-MaterialConfig.ShaderParameters<Color>.FindBlendParameters
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-MaterialConfig.ShaderParameters<object>..ctor
	|-MaterialConfig.ShaderParameters<float>..ctor
	|-MaterialConfig.ShaderParameters<Color>..ctor
	|-MaterialConfig.ShaderParameters<Texture>..ctor
	*/

}

public class MaterialConfig.ShaderParametersFloat : MaterialConfig.ShaderParameters<float> // TypeDefIndex: 11316
{	// Methods

	// RVA: 0x970530 Offset: 0x96EB30 VA: 0x180970530
	public void .ctor() { }

}

public class MaterialConfig.ShaderParametersColor : MaterialConfig.ShaderParameters<Color> // TypeDefIndex: 11317
{	// Methods

	// RVA: 0x9704F0 Offset: 0x96EAF0 VA: 0x1809704F0
	public void .ctor() { }

}

public class MaterialConfig.ShaderParametersTexture : MaterialConfig.ShaderParameters<Texture> // TypeDefIndex: 11318
{	// Methods

	// RVA: 0x970570 Offset: 0x96EB70 VA: 0x180970570
	public void .ctor() { }

}

