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
	|-RVA: 0x15B9FA0 Offset: 0x15B85A0 VA: 0x1815B9FA0
	|-ParameterOverride.GetValue<bool>
	|
	|-RVA: 0x15BA0F0 Offset: 0x15B86F0 VA: 0x1815BA0F0
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-RVA: 0x15BA190 Offset: 0x15B8790 VA: 0x1815BA190
	|-ParameterOverride.GetValue<object>
	|
	|-RVA: 0x15BA230 Offset: 0x15B8830 VA: 0x1815BA230
	|-ParameterOverride.GetValue<float>
	|
	|-RVA: 0x15BA040 Offset: 0x15B8640 VA: 0x1815BA040
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-RVA: 0x15BA2D0 Offset: 0x15B88D0 VA: 0x1815BA2D0
	|-ParameterOverride.GetValue<Vector2>
	|
	|-RVA: 0x15BA380 Offset: 0x15B8980 VA: 0x1815BA380
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

