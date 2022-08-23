public abstract class ParameterOverride // TypeDefIndex: 11824
{	public bool overrideState; // 0x10


	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	public abstract int GetHash();

	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9470 Offset: 0x15B7A70 VA: 0x1815B9470
	|-ParameterOverride.GetValue<bool>
	|
	|-RVA: 0x15B95C0 Offset: 0x15B7BC0 VA: 0x1815B95C0
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-RVA: 0x15B9660 Offset: 0x15B7C60 VA: 0x1815B9660
	|-ParameterOverride.GetValue<object>
	|
	|-RVA: 0x15B9700 Offset: 0x15B7D00 VA: 0x1815B9700
	|-ParameterOverride.GetValue<float>
	|
	|-RVA: 0x15B9510 Offset: 0x15B7B10 VA: 0x1815B9510
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-RVA: 0x15B97A0 Offset: 0x15B7DA0 VA: 0x1815B97A0
	|-ParameterOverride.GetValue<Vector2>
	|
	|-RVA: 0x15B9850 Offset: 0x15B7E50 VA: 0x1815B9850
	|-ParameterOverride.GetValue<Vector3>
	*/

	protected internal virtual void OnEnable() { }

	protected internal virtual void OnDisable() { }

	internal abstract void SetValue(ParameterOverride parameter);

	protected void .ctor() { }

}

