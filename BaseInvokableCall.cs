internal abstract class BaseInvokableCall // TypeDefIndex: 3627
{
	protected void .ctor() { }

	protected void .ctor(object target, MethodInfo function) { }

	public abstract void Invoke(object[] args);

	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CAA90 Offset: 0x5C9090 VA: 0x1805CAA90
	|-BaseInvokableCall.ThrowOnInvalidArg<Option>
	|
	|-RVA: 0x5CA510 Offset: 0x5C8B10 VA: 0x1805CA510
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|
	|-RVA: 0x5CA930 Offset: 0x5C8F30 VA: 0x1805CA930
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|
	|-RVA: 0x5CA7D0 Offset: 0x5C8DD0 VA: 0x1805CA7D0
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|
	|-RVA: 0x5CABF0 Offset: 0x5C91F0 VA: 0x1805CABF0
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|
	|-RVA: 0x5CAD50 Offset: 0x5C9350 VA: 0x1805CAD50
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|
	|-RVA: 0x5CAEB0 Offset: 0x5C94B0 VA: 0x1805CAEB0
	|-BaseInvokableCall.ThrowOnInvalidArg<ulong>
	|
	|-RVA: 0x5CA670 Offset: 0x5C8C70 VA: 0x1805CA670
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|
	|-RVA: 0x5CB010 Offset: 0x5C9610 VA: 0x1805CB010
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	*/

	protected static bool AllowInvoke(Delegate delegate) { }

	public abstract bool Find(object targetObj, MethodInfo method);

}

