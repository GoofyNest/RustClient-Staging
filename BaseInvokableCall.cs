internal abstract class BaseInvokableCall // TypeDefIndex: 3627
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x181F990 Offset: 0x181DF90 VA: 0x18181F990
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args);

	// RVA: -1 Offset: -1
	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CAA30 Offset: 0x5C9030 VA: 0x1805CAA30
	|-BaseInvokableCall.ThrowOnInvalidArg<Option>
	|
	|-RVA: 0x5CA4B0 Offset: 0x5C8AB0 VA: 0x1805CA4B0
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|
	|-RVA: 0x5CA8D0 Offset: 0x5C8ED0 VA: 0x1805CA8D0
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|
	|-RVA: 0x5CA770 Offset: 0x5C8D70 VA: 0x1805CA770
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|
	|-RVA: 0x5CAB90 Offset: 0x5C9190 VA: 0x1805CAB90
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|
	|-RVA: 0x5CACF0 Offset: 0x5C92F0 VA: 0x1805CACF0
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|
	|-RVA: 0x5CAE50 Offset: 0x5C9450 VA: 0x1805CAE50
	|-BaseInvokableCall.ThrowOnInvalidArg<ulong>
	|
	|-RVA: 0x5CA610 Offset: 0x5C8C10 VA: 0x1805CA610
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|
	|-RVA: 0x5CAFB0 Offset: 0x5C95B0 VA: 0x1805CAFB0
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	*/

	// RVA: 0x181F8E0 Offset: 0x181DEE0 VA: 0x18181F8E0
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method);

}

