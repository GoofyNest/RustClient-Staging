internal abstract class BaseInvokableCall // TypeDefIndex: 3627
{
	protected void .ctor() { }

	protected void .ctor(object target, MethodInfo function) { }

	public abstract void Invoke(object[] args);

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

	protected static bool AllowInvoke(Delegate delegate) { }

	public abstract bool Find(object targetObj, MethodInfo method);

}

