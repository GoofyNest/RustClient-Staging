public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1232
{	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x14738C0 Offset: 0x1471EC0 VA: 0x1814738C0
	internal void .ctor(Type type) { }

	// RVA: 0x1473930 Offset: 0x1471F30 VA: 0x181473930
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14734F0 Offset: 0x1471AF0 VA: 0x1814734F0 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x11888E0 Offset: 0x1186EE0 VA: 0x1811888E0
	internal bool get_IsContextOk() { }

	// RVA: 0x1188900 Offset: 0x1186F00 VA: 0x181188900
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x14739E0 Offset: 0x1471FE0 VA: 0x1814739E0 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x1473AB0 Offset: 0x14720B0 VA: 0x181473AB0 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x1473600 Offset: 0x1471C00 VA: 0x181473600 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x14733F0 Offset: 0x14719F0 VA: 0x1814733F0 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1473B20 Offset: 0x1472120 VA: 0x181473B20 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	internal void set_SourceProxy(RemotingProxy value) { }

}

