public class LTSeq // TypeDefIndex: 5574
{	// Fields
	public LTSeq previous; // 0x10
	public LTSeq current; // 0x18
	public LTDescr tween; // 0x20
	public float totalDelay; // 0x28
	public float timeScale; // 0x2C
	private int debugIter; // 0x30
	public uint counter; // 0x34
	public bool toggle; // 0x38
	private uint _id; // 0x3C

	// Properties
	public int id { get; }

	// Methods

	// RVA: 0x21AB630 Offset: 0x21A9C30 VA: 0x1821AB630
	public int get_id() { }

	// RVA: 0x21AB730 Offset: 0x21A9D30 VA: 0x1821AB730
	public void reset() { }

	// RVA: 0x21AB640 Offset: 0x21A9C40 VA: 0x1821AB640
	public void init(uint id, uint global_counter) { }

	// RVA: 0x21AACE0 Offset: 0x21A92E0 VA: 0x1821AACE0
	private LTSeq addOn() { }

	// RVA: 0x21AADB0 Offset: 0x21A93B0 VA: 0x1821AADB0
	private float addPreviousDelays() { }

	// RVA: 0x21AB600 Offset: 0x21A9C00 VA: 0x1821AB600
	public LTSeq append(float delay) { }

	// RVA: 0x21AADF0 Offset: 0x21A93F0 VA: 0x1821AADF0
	public LTSeq append(Action callback) { }

	// RVA: 0x21AAFC0 Offset: 0x21A95C0 VA: 0x1821AAFC0
	public LTSeq append(Action<object> callback, object obj) { }

	// RVA: 0x21AB250 Offset: 0x21A9850 VA: 0x1821AB250
	public LTSeq append(GameObject gameObject, Action callback) { }

	// RVA: 0x21AB410 Offset: 0x21A9A10 VA: 0x1821AB410
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj) { }

	// RVA: 0x21AB1C0 Offset: 0x21A97C0 VA: 0x1821AB1C0
	public LTSeq append(LTDescr tween) { }

	// RVA: 0x21AB6B0 Offset: 0x21A9CB0 VA: 0x1821AB6B0
	public LTSeq insert(LTDescr tween) { }

	// RVA: 0x21AB840 Offset: 0x21A9E40 VA: 0x1821AB840
	public LTSeq setScale(float timeScale) { }

	// RVA: 0x21AB780 Offset: 0x21A9D80 VA: 0x1821AB780
	private void setScaleRecursive(LTSeq seq, float timeScale, int count) { }

	// RVA: 0x21AB770 Offset: 0x21A9D70 VA: 0x1821AB770
	public LTSeq reverse() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

