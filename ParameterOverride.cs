public abstract class ParameterOverride // TypeDefIndex: 11824
{	public bool overrideState; // 0x10


	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	public abstract int GetHash();

	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9370 Offset: 0x15B7970 VA: 0x1815B9370
	|-ParameterOverride.GetValue<bool>
	|
	|-RVA: 0x15B94C0 Offset: 0x15B7AC0 VA: 0x1815B94C0
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-RVA: 0x15B9560 Offset: 0x15B7B60 VA: 0x1815B9560
	|-ParameterOverride.GetValue<object>
	|
	|-RVA: 0x15B9600 Offset: 0x15B7C00 VA: 0x1815B9600
	|-ParameterOverride.GetValue<float>
	|
	|-RVA: 0x15B9410 Offset: 0x15B7A10 VA: 0x1815B9410
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-RVA: 0x15B96A0 Offset: 0x15B7CA0 VA: 0x1815B96A0
	|-ParameterOverride.GetValue<Vector2>
	|
	|-RVA: 0x15B9750 Offset: 0x15B7D50 VA: 0x1815B9750
	|-ParameterOverride.GetValue<Vector3>
	*/

	protected internal virtual void OnEnable() { }

	protected internal virtual void OnDisable() { }

	internal abstract void SetValue(ParameterOverride parameter);

	protected void .ctor() { }

}

