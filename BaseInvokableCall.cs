internal abstract class BaseInvokableCall // TypeDefIndex: 3627
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x180CDD0 Offset: 0x180B3D0 VA: 0x18180CDD0
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args);

	// RVA: -1 Offset: -1
	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9C0 Offset: 0x5C8FC0 VA: 0x1805CA9C0
	|-BaseInvokableCall.ThrowOnInvalidArg<Option>
	|
	|-RVA: 0x5CA440 Offset: 0x5C8A40 VA: 0x1805CA440
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|
	|-RVA: 0x5CA860 Offset: 0x5C8E60 VA: 0x1805CA860
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|
	|-RVA: 0x5CA700 Offset: 0x5C8D00 VA: 0x1805CA700
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|
	|-RVA: 0x5CAB20 Offset: 0x5C9120 VA: 0x1805CAB20
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|
	|-RVA: 0x5CAC80 Offset: 0x5C9280 VA: 0x1805CAC80
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|
	|-RVA: 0x5CADE0 Offset: 0x5C93E0 VA: 0x1805CADE0
	|-BaseInvokableCall.ThrowOnInvalidArg<ulong>
	|
	|-RVA: 0x5CA5A0 Offset: 0x5C8BA0 VA: 0x1805CA5A0
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|
	|-RVA: 0x5CAF40 Offset: 0x5C9540 VA: 0x1805CAF40
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	*/

	// RVA: 0x180CD20 Offset: 0x180B320 VA: 0x18180CD20
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method);

}

