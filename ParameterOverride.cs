public abstract class ParameterOverride // TypeDefIndex: 11824
{	// Fields
	public bool overrideState; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetHash();

	// RVA: -1 Offset: -1
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

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	protected internal virtual void OnEnable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void SetValue(ParameterOverride parameter);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

