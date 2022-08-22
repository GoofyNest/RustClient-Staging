internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5922
{	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x2B103D0

	internal static ReflectionDelegateFactory Instance { get; }


	internal static ReflectionDelegateFactory get_Instance() { }

	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DCB0 Offset: 0x125C2B0 VA: 0x18125DCB0
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	*/

	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1ABA0 Offset: 0x1B191A0 VA: 0x181B1ABA0
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1AE10 Offset: 0x1B19410 VA: 0x181B1AE10
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1AD20 Offset: 0x1B19320 VA: 0x181B1AD20
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DE00 Offset: 0x125C400 VA: 0x18125DE00
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DEF0 Offset: 0x125C4F0 VA: 0x18125DEF0
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
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>..ctor
	*/

	internal object <CreateMethodCall>b__0(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66090 Offset: 0xD64690 VA: 0x180D66090
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__0
	*/

	internal object <CreateMethodCall>b__1(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD660C0 Offset: 0xD646C0 VA: 0x180D660C0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> // TypeDefIndex: 5925
{	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>..ctor
	*/

	internal T <CreateDefaultConstructor>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD660E0 Offset: 0xD646E0 VA: 0x180D660E0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__0
	*/

	internal T <CreateDefaultConstructor>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66150 Offset: 0xD64750 VA: 0x180D66150
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> // TypeDefIndex: 5926
{	public PropertyInfo propertyInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>..ctor
	*/

	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD661D0 Offset: 0xD647D0 VA: 0x180D661D0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> // TypeDefIndex: 5927
{	public FieldInfo fieldInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>..ctor
	*/

	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66200 Offset: 0xD64800 VA: 0x180D66200
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> // TypeDefIndex: 5928
{	public FieldInfo fieldInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>..ctor
	*/

	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66230 Offset: 0xD64830 VA: 0x180D66230
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>.<CreateSet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> // TypeDefIndex: 5929
{	public PropertyInfo propertyInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>..ctor
	*/

	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66250 Offset: 0xD64850 VA: 0x180D66250
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>.<CreateSet>b__0
	*/

}

