internal abstract class ReflectionDelegateFactory // TypeDefIndex: 5921
{
	public Func<T, object> CreateGet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B1AF40 Offset: 0x1B19540 VA: 0x181B1AF40
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	public Action<T, object> CreateSet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F5E0 Offset: 0x125DBE0 VA: 0x18125F5E0
	|-ReflectionDelegateFactory.CreateSet<object>
	*/

	public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateMethodCall<object>
	*/

	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	public abstract Func<T> CreateDefaultConstructor<T>(Type type);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<object>
	*/

	public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<object>
	*/

	protected void .ctor() { }

}

