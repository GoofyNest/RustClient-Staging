public abstract class ParameterOverride // TypeDefIndex: 11824
{	public bool overrideState; // 0x10


	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	public abstract int GetHash();

	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9330 Offset: 0x15B7930 VA: 0x1815B9330
	|-ParameterOverride.GetValue<bool>
	|
	|-RVA: 0x15B9480 Offset: 0x15B7A80 VA: 0x1815B9480
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-RVA: 0x15B9520 Offset: 0x15B7B20 VA: 0x1815B9520
	|-ParameterOverride.GetValue<object>
	|
	|-RVA: 0x15B95C0 Offset: 0x15B7BC0 VA: 0x1815B95C0
	|-ParameterOverride.GetValue<float>
	|
	|-RVA: 0x15B93D0 Offset: 0x15B79D0 VA: 0x1815B93D0
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-RVA: 0x15B9660 Offset: 0x15B7C60 VA: 0x1815B9660
	|-ParameterOverride.GetValue<Vector2>
	|
	|-RVA: 0x15B9710 Offset: 0x15B7D10 VA: 0x1815B9710
	|-ParameterOverride.GetValue<Vector3>
	*/

	protected internal virtual void OnEnable() { }

	protected internal virtual void OnDisable() { }

	internal abstract void SetValue(ParameterOverride parameter);

	protected void .ctor() { }

}

