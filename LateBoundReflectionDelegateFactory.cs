internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5922
{	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x2B103D0

	internal static ReflectionDelegateFactory Instance { get; }


	internal static ReflectionDelegateFactory get_Instance() { }

	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DDF0 Offset: 0x125C3F0 VA: 0x18125DDF0
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	*/

	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1ACE0 Offset: 0x1B192E0 VA: 0x181B1ACE0
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1AF50 Offset: 0x1B19550 VA: 0x181B1AF50
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1AE60 Offset: 0x1B19460 VA: 0x181B1AE60
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DF40 Offset: 0x125C540 VA: 0x18125DF40
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E030 Offset: 0x125C630 VA: 0x18125E030
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
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>..ctor
	*/

	internal object <CreateMethodCall>b__0(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD661D0 Offset: 0xD647D0 VA: 0x180D661D0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__0
	*/

	internal object <CreateMethodCall>b__1(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66200 Offset: 0xD64800 VA: 0x180D66200
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> // TypeDefIndex: 5925
{	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>..ctor
	*/

	internal T <CreateDefaultConstructor>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66220 Offset: 0xD64820 VA: 0x180D66220
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__0
	*/

	internal T <CreateDefaultConstructor>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66290 Offset: 0xD64890 VA: 0x180D66290
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> // TypeDefIndex: 5926
{	public PropertyInfo propertyInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>..ctor
	*/

	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66310 Offset: 0xD64910 VA: 0x180D66310
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> // TypeDefIndex: 5927
{	public FieldInfo fieldInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>..ctor
	*/

	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66340 Offset: 0xD64940 VA: 0x180D66340
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> // TypeDefIndex: 5928
{	public FieldInfo fieldInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>..ctor
	*/

	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66370 Offset: 0xD64970 VA: 0x180D66370
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>.<CreateSet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> // TypeDefIndex: 5929
{	public PropertyInfo propertyInfo; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>..ctor
	*/

	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD66390 Offset: 0xD64990 VA: 0x180D66390
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>.<CreateSet>b__0
	*/

}

