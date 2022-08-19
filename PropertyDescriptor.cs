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

	// RVA: 0x15D3140 Offset: 0x15D1740 VA: 0x1815D3140
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x15D3130 Offset: 0x15D1730 VA: 0x1815D3130
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Type get_ComponentType();

	// RVA: 0x15D3150 Offset: 0x15D1750 VA: 0x1815D3150 Slot: 14
	public virtual TypeConverter get_Converter() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: 0x15D2990 Offset: 0x15D0F90 VA: 0x1815D2990 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15D2760 Offset: 0x15D0D60 VA: 0x1815D2760
	protected object CreateInstance(Type type) { }

	// RVA: 0x15D2B20 Offset: 0x15D1120 VA: 0x1815D2B20 Slot: 11
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x15D2C80 Offset: 0x15D1280 VA: 0x1815D2C80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15D2CE0 Offset: 0x15D12E0 VA: 0x1815D2CE0 Slot: 12
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x15D2E40 Offset: 0x15D1440 VA: 0x1815D2E40
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract object GetValue(object component);

	// RVA: 0x15D3090 Offset: 0x15D1690 VA: 0x1815D3090 Slot: 18
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SetValue(object component, object value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool ShouldSerializeValue(object component);

}

