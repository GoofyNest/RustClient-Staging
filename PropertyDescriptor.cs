public abstract class PropertyDescriptor : MemberDescriptor // TypeDefIndex: 2734
{	// Fields
	private TypeConverter converter; // 0x60
	private Hashtable valueChangedHandlers; // 0x68
	private object[] editors; // 0x70
	private Type[] editorTypes; // 0x78
	private int editorCount; // 0x80

	// Properties
	public abstract Type ComponentType { get; }
	public virtual TypeConverter Converter { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: 0x15D3400 Offset: 0x15D1A00 VA: 0x1815D3400
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x15D33F0 Offset: 0x15D19F0 VA: 0x1815D33F0
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Type get_ComponentType();

	// RVA: 0x15D3410 Offset: 0x15D1A10 VA: 0x1815D3410 Slot: 14
	public virtual TypeConverter get_Converter() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: 0x15D2C50 Offset: 0x15D1250 VA: 0x1815D2C50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15D2A20 Offset: 0x15D1020 VA: 0x1815D2A20
	protected object CreateInstance(Type type) { }

	// RVA: 0x15D2DE0 Offset: 0x15D13E0 VA: 0x1815D2DE0 Slot: 11
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x15D2F40 Offset: 0x15D1540 VA: 0x1815D2F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15D2FA0 Offset: 0x15D15A0 VA: 0x1815D2FA0 Slot: 12
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x15D3100 Offset: 0x15D1700 VA: 0x1815D3100
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract object GetValue(object component);

	// RVA: 0x15D3350 Offset: 0x15D1950 VA: 0x1815D3350 Slot: 18
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SetValue(object component, object value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool ShouldSerializeValue(object component);

}

