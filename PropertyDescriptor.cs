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

	// RVA: 0x15D24D0 Offset: 0x15D0AD0 VA: 0x1815D24D0
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x15D24C0 Offset: 0x15D0AC0 VA: 0x1815D24C0
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Type get_ComponentType();

	// RVA: 0x15D24E0 Offset: 0x15D0AE0 VA: 0x1815D24E0 Slot: 14
	public virtual TypeConverter get_Converter() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: 0x15D1D20 Offset: 0x15D0320 VA: 0x1815D1D20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15D1AF0 Offset: 0x15D00F0 VA: 0x1815D1AF0
	protected object CreateInstance(Type type) { }

	// RVA: 0x15D1EB0 Offset: 0x15D04B0 VA: 0x1815D1EB0 Slot: 11
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x15D2010 Offset: 0x15D0610 VA: 0x1815D2010 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15D2070 Offset: 0x15D0670 VA: 0x1815D2070 Slot: 12
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x15D21D0 Offset: 0x15D07D0 VA: 0x1815D21D0
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract object GetValue(object component);

	// RVA: 0x15D2420 Offset: 0x15D0A20 VA: 0x1815D2420 Slot: 18
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SetValue(object component, object value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool ShouldSerializeValue(object component);

}

