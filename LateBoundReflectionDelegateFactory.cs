internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5922
{	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x2B103D0

	internal static ReflectionDelegateFactory Instance { get; }


	internal static ReflectionDelegateFactory get_Instance() { }

	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DDB0 Offset: 0x125C3B0 VA: 0x18125DDB0
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	*/

	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1ACA0 Offset: 0x1B192A0 VA: 0x181B1ACA0
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1AF10 Offset: 0x1B19510 VA: 0x181B1AF10
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1AE20 Offset: 0x1B19420 VA: 0x181B1AE20
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DF00 Offset: 0x125C500 VA: 0x18125DF00
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DFF0 Offset: 0x125C5F0 VA: 0x18125DFF0
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0 // TypeDefIndex: 5923
{	public ConstructorInfo c; // 0x10
	public MethodBase method; // 0x18


	public void .ctor() { }

	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	internal object <CreateParameterizedConstructor>b__1(object[] a) { }

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<T> // TypeDefIndex: 5924
{	public ConstructorInfo c; // 0x0
	public MethodBase method; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>..ctor
	*/

	internal object <CreateMethodCall>b__0(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66190 Offset: 0xD64790 VA: 0x180D66190
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__0
	*/

	internal object <CreateMethodCall>b__1(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD661C0 Offset: 0xD647C0 VA: 0x180D661C0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> // TypeDefIndex: 5925
{	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>..ctor
	*/

	internal T <CreateDefaultConstructor>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD661E0 Offset: 0xD647E0 VA: 0x180D661E0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__0
	*/

	internal T <CreateDefaultConstructor>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66250 Offset: 0xD64850 VA: 0x180D66250
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> // TypeDefIndex: 5926
{	public PropertyInfo propertyInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>..ctor
	*/

	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD662D0 Offset: 0xD648D0 VA: 0x180D662D0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> // TypeDefIndex: 5927
{	public FieldInfo fieldInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>..ctor
	*/

	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66300 Offset: 0xD64900 VA: 0x180D66300
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> // TypeDefIndex: 5928
{	public FieldInfo fieldInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>..ctor
	*/

	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66330 Offset: 0xD64930 VA: 0x180D66330
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>.<CreateSet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> // TypeDefIndex: 5929
{	public PropertyInfo propertyInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>..ctor
	*/

	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66350 Offset: 0xD64950 VA: 0x180D66350
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>.<CreateSet>b__0
	*/

}

