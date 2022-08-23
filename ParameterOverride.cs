public abstract class ParameterOverride // TypeDefIndex: 11824
{	public bool overrideState; // 0x10


	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	public abstract int GetHash();

	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9430 Offset: 0x15B7A30 VA: 0x1815B9430
	|-ParameterOverride.GetValue<bool>
	|
	|-RVA: 0x15B9580 Offset: 0x15B7B80 VA: 0x1815B9580
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-RVA: 0x15B9620 Offset: 0x15B7C20 VA: 0x1815B9620
	|-ParameterOverride.GetValue<object>
	|
	|-RVA: 0x15B96C0 Offset: 0x15B7CC0 VA: 0x1815B96C0
	|-ParameterOverride.GetValue<float>
	|
	|-RVA: 0x15B94D0 Offset: 0x15B7AD0 VA: 0x1815B94D0
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-RVA: 0x15B9760 Offset: 0x15B7D60 VA: 0x1815B9760
	|-ParameterOverride.GetValue<Vector2>
	|
	|-RVA: 0x15B9810 Offset: 0x15B7E10 VA: 0x1815B9810
	|-ParameterOverride.GetValue<Vector3>
	*/

	protected internal virtual void OnEnable() { }

	protected internal virtual void OnDisable() { }

	internal abstract void SetValue(ParameterOverride parameter);

	protected void .ctor() { }

}

