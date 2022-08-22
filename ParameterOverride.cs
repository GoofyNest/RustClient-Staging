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
	|-RVA: 0x15BA260 Offset: 0x15B8860 VA: 0x1815BA260
	|-ParameterOverride.GetValue<bool>
	|
	|-RVA: 0x15BA3B0 Offset: 0x15B89B0 VA: 0x1815BA3B0
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-RVA: 0x15BA450 Offset: 0x15B8A50 VA: 0x1815BA450
	|-ParameterOverride.GetValue<object>
	|
	|-RVA: 0x15BA4F0 Offset: 0x15B8AF0 VA: 0x1815BA4F0
	|-ParameterOverride.GetValue<float>
	|
	|-RVA: 0x15BA300 Offset: 0x15B8900 VA: 0x1815BA300
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-RVA: 0x15BA590 Offset: 0x15B8B90 VA: 0x1815BA590
	|-ParameterOverride.GetValue<Vector2>
	|
	|-RVA: 0x15BA640 Offset: 0x15B8C40 VA: 0x1815BA640
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

